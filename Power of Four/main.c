#include <stdio.h>
#include <stdlib.h>
#include <stdbool.h>

bool isPowerOfFour(int n)
{
    if (n == 1)
        return true;
    if (n < 4)
        return false;
    while (n % 4 == 0)
        n /= 4;
    return n == 1;
}

int main()
{
    printf("%i",isPowerOfFour(16));
    return 0;
}