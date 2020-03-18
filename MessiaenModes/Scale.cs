using System.Text;

namespace MessiaenModes
{
    public class Scale
    {
        public bool IsDone { get; set; } = false;
        public bool IsValid { get; set; } = true;
        public bool IsMessiaen { get; set; } = false;
        public int NoteCount { get; set; } = 0;

        protected byte[] Notes { get; set; } = new byte[13];
        protected string[] NoteNames1 = new string[] { "C", "C#", "D", "D#", "E", "F", "F#", "G", "G#", "A", "A#", "B" };
        protected string[] NoteNames2 = new string[] { "C", "Db", "D", "Eb", "E", "F", "Gb", "G", "Ab", "A", "Bb", "B" };
        protected int[] intervals = new int[13];
        protected int intervalCount = 0;
        protected int[,] rotations;

        public Scale(bool initZero)
        {
            for (int i = 0; i < Notes.Length; i++)
                Notes[i] = 0;
            if (initZero)
                Notes[0] = 1;
        }

        public int ChromaticCount
        {
            get
            {
                int chromaticCount = 0;
                for(int i = 0; i < intervalCount; i++ )
                {
                    if (intervals[i] == 1)
                        chromaticCount++;
                }
                return chromaticCount;
            }
        }

        public Scale Duplicate()
        {
            return new Scale(false)
            {
                Notes = (byte[])Notes.Clone()
            };
        }

        public void Extend(byte interval)
        {
            for(int i = 0; i < Notes.Length; i++)
            {
                if (Notes[i] == 0)
                {
                    byte nextNote = (byte)(Notes[i - 1] + interval);
                    if (nextNote == 13)
                    {
                        IsDone = true;
                        IsValid = true;
                        Notes[i] = nextNote;
                        IsMessiaen = TestForMessiaen();
                        NoteCount = i + 1;
                    }
                    else if (nextNote > 13)
                    {
                        IsDone = true;
                        IsValid = false;
                    }
                    else
                        Notes[i] = nextNote;
                    break;
                }
            }
        }

        public string GetScaleString(string rootNote, bool sharps)
        {
            string[] NoteNames = (sharps ? NoteNames1 : NoteNames2);

            // get index of root note
            int rootIndex = 0;
            for(int i = 0; i<NoteNames.Length; i++)
            {
                if (rootNote.Equals(NoteNames[i]))
                {
                    rootIndex = i;
                    break;
                }
            }

            // create return string
            StringBuilder scaleString = new StringBuilder(26);
            for (int i = 0; i < Notes.Length; i++)
            {
                if (Notes[i] == 0)
                    break;

                int noteNameIndex = (Notes[i] + rootIndex) - 1;
                if (noteNameIndex >= 12)
                    noteNameIndex -= 12;
                scaleString.Append( ( i > 0 ? " - " : "" ) + NoteNames[noteNameIndex]);
            }
            return scaleString.ToString();
        }

        public string GetIntervalString(bool intervalNames)
        {
            StringBuilder intervalString = new StringBuilder(26);
            intervalString.Append("r");
            for (int i = 0; i < intervalCount; i++)
                intervalString.Append(" - " + (intervalNames ? IntervalName(intervals[i]) : intervals[i].ToString()));
            return intervalString.ToString();
        }

        protected string IntervalName(int interval)
        {
            switch(interval)
            {
                case 1:
                    return "h";
                case 2:
                    return "w";
                case 3:
                    return "m3";
                case 4:
                    return "M3";
                case 5:
                    return "4";
                case 6:
                    return "4+";
                case 7:
                    return "5";
                case 8:
                    return "5+";
                case 9:
                    return "6";
                case 10:
                    return "b7";
                case 11:
                    return "M7";
            }
            return "U";
        }

        protected bool TestForMessiaen()
        {
            // compute intervals
            intervalCount = 0;
            for(int i = 1; i < Notes.Length && Notes[i] != 0; i++ )
            {
                intervals[i - 1] = Notes[i] - Notes[i - 1];
                intervalCount = i;
            }

            // create matrix of all possible interval rotations
            rotations = new int[intervalCount,intervalCount];
            for(int i = 0; i < intervalCount; i++)
            {
                for(int j = 0; j < intervalCount; j++)
                {
                    int k = (i + j);
                    rotations[i,j] = intervals[(k >= intervalCount) ? k - intervalCount : k];
                }
            }

            // compare each rotation against each other rotation to look for duplicates
            bool isMessiaen = false;
            for(int i = 0; i < intervalCount && !isMessiaen; i++)
            {
                for(int j = 0; j < intervalCount; j++)
                {
                    if (i == j)
                        continue;
                    bool isMatch = true;
                    for(int k = 0; k < intervalCount; k++)
                    {
                        if( rotations[i,k] != rotations[j,k])
                        {
                            isMatch = false;
                            break;
                        }
                    }
                    if( isMatch )
                    {
                        isMessiaen = true;
                        break;
                    }
                }
            }
            return isMessiaen;
        }
    }
}
