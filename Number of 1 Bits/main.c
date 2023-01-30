#include <stdio.h>
#include <stdlib.h>
#include <stdint-gcc.h>

int hammingWeight(uint32_t n)
{
    int j;
    int count = 0;
    for (j = 0; j < 32; j++)
    {
        if ((n & (1U << j)))
        {
            count+=1;
        }
    }
    return count;
}

int main()
{
    unsigned int num;
    scanf("%i", &num);
    printf("%d",hammingWeight(num));
    return 0;
}

