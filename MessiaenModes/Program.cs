using System;

namespace MessiaenModes
{
    class Program
    {
        static void Main(string[] args)
        {
            // parse command line parameters
            bool showAll = false;
            int maxChromatic = 13;
            int minNotes = 0;
            int maxNotes = 13;
            string scaleRoot = "C";
            bool sharps = false;
            foreach (string arg in args)
            {
                if (arg.Equals("-showall", StringComparison.OrdinalIgnoreCase))
                    showAll = true;
                else if (arg.StartsWith("-maxchromatic:", StringComparison.OrdinalIgnoreCase))
                    maxChromatic = int.Parse(arg.Substring(14));
                else if (arg.StartsWith("-minnotes:", StringComparison.OrdinalIgnoreCase))
                    minNotes = int.Parse(arg.Substring(10));
                else if (arg.StartsWith("-maxnotes:", StringComparison.OrdinalIgnoreCase))
                    maxNotes = int.Parse(arg.Substring(10));
                else if (arg.StartsWith("-minnotes:", StringComparison.OrdinalIgnoreCase))
                    minNotes = int.Parse(arg.Substring(10));
                else if (arg.StartsWith("-scaleroot:", StringComparison.OrdinalIgnoreCase))
                    scaleRoot = arg.Substring(11);
                else if (arg.StartsWith("-sharps:", StringComparison.OrdinalIgnoreCase))
                    sharps = bool.Parse(arg.Substring(8));
            }

            // create the finder and all potential scales
            ScaleFinder finder = new ScaleFinder()
            {
                maxChromatic = maxChromatic,
                minNotes = minNotes,
                maxNotes = maxNotes
            };
            finder.CreateScales();

            // display scales
            foreach (Scale scale in finder.Scales)
            {
                if (!showAll && !scale.IsMessiaen)
                    continue;

                Console.WriteLine(scale.GetScaleString(scaleRoot, sharps));
                Console.WriteLine(scale.GetIntervalString());
                Console.WriteLine();
            }

            Console.WriteLine("Total Scales Searched:" + finder.ScaleCount);
            Console.WriteLine("Total Messiaen Scales Found:" + finder.MessiaenCount);
        }
    }
}
