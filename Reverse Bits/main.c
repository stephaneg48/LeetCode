#include <stdio.h>
#include <stdlib.h>
#include <stdint-gcc.h>

uint32_t reverseBits(uint32_t n)
{
    uint32_t res = 0;
    int i;
    for (i = 0; i < 32; i++) // may consist of just left shifts at some point (n = 0)
    {
       res = res << 1;
       res += n & 1;
       n = n >> 1;
    }
    return res;
}

int main()
{
    uint32_t num = 38;
    uint32_t result = reverseBits(num);
    printf("%u", result);
    return 0;
}
