# MessiaenModesCLI
This simple C# command line app searches through a specified space of potential scales looking for Messiaen scales (or modes). 
For more information about these, please refer to https://en.wikipedia.org/wiki/Mode_of_limited_transposition

Here's a sample run with the following command line parameters:

* -maxchromatic:4 -scaleroot:Db -sharps:false -minnotes:5 -maxnotes:9

Output:
```
Db - D - Eb - F - G - Ab - A - B - Db
r - h - h - w - w - h - h - w - w
r - 1 - 1 - 2 - 2 - 1 - 1 - 2 - 2

Db - D - Eb - G - Ab - A - Db
r - h - h - M3 - h - h - M3
r - 1 - 1 - 4 - 1 - 1 - 4

Db - D - E - F - G - Ab - Bb - B - Db
r - h - w - h - w - h - w - h - w
r - 1 - 2 - 1 - 2 - 1 - 2 - 1 - 2

Db - D - E - Gb - G - Ab - Bb - C - Db
r - h - w - w - h - h - w - w - h
r - 1 - 2 - 2 - 1 - 1 - 2 - 2 - 1

Db - D - E - G - Ab - Bb - Db
r - h - w - m3 - h - w - m3
r - 1 - 2 - 3 - 1 - 2 - 3

Db - D - F - Gb - A - Bb - Db
r - h - m3 - h - m3 - h - m3
r - 1 - 3 - 1 - 3 - 1 - 3

Db - D - F - G - Ab - B - Db
r - h - m3 - w - h - m3 - w
r - 1 - 3 - 2 - 1 - 3 - 2

Db - D - Gb - G - Ab - C - Db
r - h - M3 - h - h - M3 - h
r - 1 - 4 - 1 - 1 - 4 - 1

Db - Eb - E - F - G - A - Bb - B - Db
r - w - h - h - w - w - h - h - w
r - 2 - 1 - 1 - 2 - 2 - 1 - 1 - 2

Db - Eb - E - Gb - G - A - Bb - C - Db
r - w - h - w - h - w - h - w - h
r - 2 - 1 - 2 - 1 - 2 - 1 - 2 - 1

Db - Eb - E - G - A - Bb - Db
r - w - h - m3 - w - h - m3
r - 2 - 1 - 3 - 2 - 1 - 3

Db - Eb - F - Gb - G - A - B - C - Db
r - w - w - h - h - w - w - h - h
r - 2 - 2 - 1 - 1 - 2 - 2 - 1 - 1

Db - Eb - F - G - A - B - Db
r - w - w - w - w - w - w
r - 2 - 2 - 2 - 2 - 2 - 2

Db - Eb - Gb - G - A - C - Db
r - w - m3 - h - w - m3 - h
r - 2 - 3 - 1 - 2 - 3 - 1

Db - E - F - G - Bb - B - Db
r - m3 - h - w - m3 - h - w
r - 3 - 1 - 2 - 3 - 1 - 2

Db - E - F - Ab - A - C - Db
r - m3 - h - m3 - h - m3 - h
r - 3 - 1 - 3 - 1 - 3 - 1

Db - E - Gb - G - Bb - C - Db
r - m3 - w - h - m3 - w - h
r - 3 - 2 - 1 - 3 - 2 - 1

Db - F - Gb - G - B - C - Db
r - M3 - h - h - M3 - h - h
r - 4 - 1 - 1 - 4 - 1 - 1

Total Scales Searched:1202
Total Messiaen Scales Found:18
```
