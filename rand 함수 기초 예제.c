#include<stdio.h>
#include<stdlib.h>

int main(void)
{
	int i;
	int random = 0;
	for (i = 0;i<10;i++)
	{
		random = rand()%9;
		printf("%d\n",random);
	}
	return 0;
}
