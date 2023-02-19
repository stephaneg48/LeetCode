#include <stdio.h>
#include <string.h>

int firstUniqChar(char * s)
{
    // can't use a map (doesn't exist in C)
    // ... but it is constrained to lowercase letters only - 26 characters
    // so make one

    int i;
    int map[26];

    for (i = 0; i < sizeof(map)/sizeof(map[0]); i++)
        map[i] = 0;

    for (i = 0; i < strlen(s); i++)
    {
        int char_index = s[i] - 'a';
        // b - a = 2 - 1 = 1 (1 in terms of index)
        // ...
        // z - a = 26 - 1 = 25 (25 in terms of index)
        map[char_index]++;
    }

    // now iterate through the string from the beginning
    // the first character to have a count of 1, based on the "map", has the index to return
    for (i = 0; i < strlen(s); i++)
    {
        int char_index = s[i] - 'a';
        if (map[char_index] == 1)
            return i;
    }

    return -1;
}

int main()
{
    char *s = "loveleetcode";
    printf("%d", firstUniqChar(s));
    return 0;
}