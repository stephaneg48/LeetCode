#include <stdio.h>

int findComplement(int num)
{
    long long res = 0;
    long long i = 1;
    while (num)
    {
        if (!(num & 1))
            res += i;
        num >>= 1;
        i *= 2;
    }
    return (int)res;
}

int main()
{
    printf("complement of 5 is: %d", findComplement(5));
    return 0;
}