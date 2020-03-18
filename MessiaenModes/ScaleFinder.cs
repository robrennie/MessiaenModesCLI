using System.Collections.Generic;

namespace MessiaenModes
{
    public class ScaleFinder
    {
        public List<Scale> Scales { get; set; } = new List<Scale>();
        public int ScaleCount { get; set; } = 0;
        public int MessiaenCount { get; set; } = 0;
        public int MaxChromatic { get; set; } = 12;
        public int MinNotes { get; set; } = 0;
        public int MaxNotes { get; set; } = 0;

        public void CreateScales()
        {
            Scale scale = new Scale(true);
            CreateScale(scale);

            ScaleCount = Scales.Count;
            foreach(Scale scount in Scales)
            {
                if (scount.IsMessiaen)
                    MessiaenCount++;
            }
        }

        protected void CreateScale(Scale scale)
        {
            // semitone
            ExtendScale(scale, 1);

            // tone
            ExtendScale(scale, 2);

            // minor third
            ExtendScale(scale, 3);

            // major third
            ExtendScale(scale, 4);

            // perfect 4th
            ExtendScale(scale, 5);

            // augmented 4th
            ExtendScale(scale, 6);
        }

        protected void ExtendScale(Scale scale, byte interval)
        {
            Scale extendedScale = scale.Duplicate();
            extendedScale.Extend(interval);
            if (!extendedScale.IsDone)
                CreateScale(extendedScale);
            else if( extendedScale.IsValid )
            {
                if( ValidateMinMax(extendedScale))
                    Scales.Add(extendedScale);
            }
        }

        protected bool ValidateMinMax(Scale extendedScale)
        {
            if ((extendedScale.NoteCount - 1) > MaxNotes || (extendedScale.NoteCount - 1) < MinNotes || extendedScale.ChromaticCount > MaxChromatic)
                return false;
            return true;
        }
    }
}
