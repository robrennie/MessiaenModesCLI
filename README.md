# MessiaenModesCLI
This simple C# command line app searches through a specified space of potential scales looking for Messiaen scales (or modes). 
For more information about these, please refer to https://en.wikipedia.org/wiki/Mode_of_limited_transposition

Here's a sample run with the following command line parameters:

* -maxchromatic:4 -scaleroot:Bb -sharps:false

Output:
```
Bb - B - C - Db - Eb - E - F - G - A
1 - 1 - 2 - 2 - 1 - 1 - 2 - 2

Bb - B - C - Eb - E - F - A
1 - 1 - 4 - 1 - 1 - 4

Bb - B - C - Db - Eb - E - Gb - G - A
1 - 2 - 1 - 2 - 1 - 2 - 1 - 2

Bb - B - C - D - Eb - E - Gb - Ab - A
1 - 2 - 2 - 1 - 1 - 2 - 2 - 1

Bb - B - C - Eb - E - Gb - A
1 - 2 - 3 - 1 - 2 - 3

Bb - B - Db - D - F - Gb - A
1 - 3 - 1 - 3 - 1 - 3

Bb - B - Db - Eb - E - G - A
1 - 3 - 2 - 1 - 3 - 2

Bb - B - D - Eb - E - Ab - A
1 - 4 - 1 - 1 - 4 - 1

Bb - B - Eb - E - A
1 - 5 - 1 - 5

Bb - C - C - Db - Eb - F - Gb - G - A
2 - 1 - 1 - 2 - 2 - 1 - 1 - 2

Bb - C - C - D - Eb - F - Gb - Ab - A
2 - 1 - 2 - 1 - 2 - 1 - 2 - 1

Bb - C - C - Eb - F - Gb - A
2 - 1 - 3 - 2 - 1 - 3

Bb - C - Db - D - Eb - F - G - Ab - A
2 - 2 - 1 - 1 - 2 - 2 - 1 - 1

Bb - C - Db - Eb - F - G - A
2 - 2 - 2 - 2 - 2 - 2

Bb - C - D - Eb - F - Ab - A
2 - 3 - 1 - 2 - 3 - 1

Bb - C - Eb - F - A
2 - 4 - 2 - 4

Bb - C - Db - Eb - Gb - G - A
3 - 1 - 2 - 3 - 1 - 2

Bb - C - Db - E - F - Ab - A
3 - 1 - 3 - 1 - 3 - 1

Bb - C - D - Eb - Gb - Ab - A
3 - 2 - 1 - 3 - 2 - 1

Bb - C - Eb - Gb - A
3 - 3 - 3 - 3

Bb - Db - D - Eb - G - Ab - A
4 - 1 - 1 - 4 - 1 - 1

Bb - Db - Eb - G - A
4 - 2 - 4 - 2

Bb - Db - F - A
4 - 4 - 4

Bb - D - Eb - Ab - A
5 - 1 - 5 - 1

Bb - Eb - A
6 - 6

Total Scales Searched:1353
Total Messiaen Scales Found:25
```
