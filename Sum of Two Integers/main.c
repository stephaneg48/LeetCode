#include <stdio.h>

int getSum(int a, int b)
{
    while (b != 0)
    {
        unsigned carry = (unsigned int) (a & b);
        a = a ^ b;
        b = carry << 1;
    }
    return a;
}

/*

- clearly a bitwise problem, but where to start...

2 = 0010
3 = 0011

5 = 0101

- one gate (AND, OR, XOR, NOR) clearly won't work
- probably won't involve just bit shifting
    - so a combination of both, then?

2 & 3 = 0010 & 0011 = 0010 = "carry" = 2

2 ^ 3 = 0010 ^ 0011 = 0001 = 1

3 -> carry = 0010 << 1 = 0100 = 4

-----

1 & 4 = 0001 & 0100 = 0000 = carry

1 ^ 4 = 0001 ^ 0100 = 0101 = 5

4 -> carry = 0000 << 1 = 0000 = 0

2, 3 -> 1, 4 -> 0, 5... looks good

*/

int main()
{
    printf("%d", getSum(-8,12));
    return 0;
}