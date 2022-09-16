#include<stdio.h>

int recursion (int n)
{
	if (n == 0)
	{
		return 0;
	}
	else
	{
		return n + recursion(n - 1); 
	}
}

int main(void)
{
	int a = 10;
	int c = 0;
	c = recursion(a);
	
	printf("a = %d 까지의 합",a);
	printf("recursion : %d\n",c);
	
	return 0;
}
