#include<stdio.h>

int main(void)
{
	int i,j;
	int k = 65;
	for (i = 1; i <= 14; i++)
	{
		k = 65;
		for (j = 1; j<=14 - i;j++)
		{
			printf(" ");
		}
		for (j = 1; j <= (2 * i) - 1;j++)
		{
			printf("%c",k);
			if(k == 90)
			{
				break;
			}
			k++;
		}
		printf("\n");
	}
	return 0;
}
