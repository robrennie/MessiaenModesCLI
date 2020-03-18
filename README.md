# MessiaenModesCLI
This simple C# command line app searches through a specified space of potential scales looking for Messiaen scales (or modes). 
For more information about these, please refer to https://en.wikipedia.org/wiki/Mode_of_limited_transposition

Here's a sample run with the following command line parameters:

* -maxchromatic:4 -scaleroot:Db -sharps:false -minnotes:5 -maxnotes:9

Output:
```
Db - D - Eb - F - G - Ab - A - B - Db
1 - 1 - 2 - 2 - 1 - 1 - 2 - 2

Db - D - Eb - G - Ab - A - Db
1 - 1 - 4 - 1 - 1 - 4

Db - D - E - F - G - Ab - Bb - B - Db
1 - 2 - 1 - 2 - 1 - 2 - 1 - 2

Db - D - E - Gb - G - Ab - Bb - C - Db
1 - 2 - 2 - 1 - 1 - 2 - 2 - 1

Db - D - E - G - Ab - Bb - Db
1 - 2 - 3 - 1 - 2 - 3

Db - D - F - Gb - A - Bb - Db
1 - 3 - 1 - 3 - 1 - 3

Db - D - F - G - Ab - B - Db
1 - 3 - 2 - 1 - 3 - 2

Db - D - Gb - G - Ab - C - Db
1 - 4 - 1 - 1 - 4 - 1

Db - Eb - E - F - G - A - Bb - B - Db
2 - 1 - 1 - 2 - 2 - 1 - 1 - 2

Db - Eb - E - Gb - G - A - Bb - C - Db
2 - 1 - 2 - 1 - 2 - 1 - 2 - 1

Db - Eb - E - G - A - Bb - Db
2 - 1 - 3 - 2 - 1 - 3

Db - Eb - F - Gb - G - A - B - C - Db
2 - 2 - 1 - 1 - 2 - 2 - 1 - 1

Db - Eb - F - G - A - B - Db
2 - 2 - 2 - 2 - 2 - 2

Db - Eb - Gb - G - A - C - Db
2 - 3 - 1 - 2 - 3 - 1

Db - E - F - G - Bb - B - Db
3 - 1 - 2 - 3 - 1 - 2

Db - E - F - Ab - A - C - Db
3 - 1 - 3 - 1 - 3 - 1

Db - E - Gb - G - Bb - C - Db
3 - 2 - 1 - 3 - 2 - 1

Db - F - Gb - G - B - C - Db
4 - 1 - 1 - 4 - 1 - 1

Total Scales Searched:1202
Total Messiaen Scales Found:18
```
