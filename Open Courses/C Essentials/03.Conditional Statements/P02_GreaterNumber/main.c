#include <stdio.h>
#include <stdlib.h>

int main()
{
    int num1, num2;
    scanf("%d %d", &num1, &num2);

    if(num1 >= num2) {
        printf("%d", num1);
    }
    else {
        printf("%d", num2);
    }

    return 0;
}