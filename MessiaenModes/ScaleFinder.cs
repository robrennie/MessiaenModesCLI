using System;
using System.Collections.Generic;
using System.Text;

namespace MessiaenModes
{
    public class ScaleFinder
    {
        public List<Scale> Scales { get; set; } = new List<Scale>();
        public int ScaleCount { get; set; } = 0;
        public int MessiaenCount { get; set; } = 0;
        public int maxChromatic { get; set; } = 12;
        public int minNotes { get; set; } = 0;
        public int maxNotes { get; set; } = 0;

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
            if ((extendedScale.NoteCount - 1) > maxNotes || (extendedScale.NoteCount - 1) < minNotes || extendedScale.ChromaticCount > maxChromatic)
                return false;
            return true;
        }
    }
}
