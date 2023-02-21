#include <stdio.h>
#include <string.h>

char findTheDifference(char * s, char * t)
{
    // same idea as previous string problem: make a map

    int i;
    int map_one[26];
    int map_two[26];

    for (i = 0; i < sizeof(map_one)/sizeof(map_one[0]); i++)
    {
        map_one[i] = 0;
        map_two[i] = 0;
    }

    for (i = 0; i < strlen(s); i++)
    {
        int char_index = s[i] - 'a';
        // b - a = 2 - 1 = 1 (1 in terms of index)
        // ...
        // z - a = 26 - 1 = 25 (25 in terms of index)
        map_one[char_index]++;
    }

    for (i = 0; i < strlen(t); i++)
    {
        int char_index = t[i] - 'a';
        // b - a = 2 - 1 = 1 (1 in terms of index)
        // ...
        // z - a = 26 - 1 = 25 (25 in terms of index)
        map_two[char_index]++;
    }

    // now iterate through the string from the beginning
    // the first character to have a count of 1, based on the "map", has the index to return
    for (i = 0; i < strlen(t); i++)
    {
        // something here, ignore the above two comments
        int char_index = t[i] - 'a';
        if (map_one[char_index] != map_two[char_index])
            return t[i];
    }

    return -1;
}

int main()
{
    char *s = "abcd";
    char *t = "abcde";
    printf("%c", findTheDifference(s,t));
    return 0;
}