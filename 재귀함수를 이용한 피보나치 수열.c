#include<stdio.h>

int fibo(int n){
	if (n == 0) return 0;
	else if (n == 1) return 1;
	else return fibo(n - 1) + fibo(n - 2);
}

int main(void)
{
	int i,n;
	printf("몇번째까지 구할 것 인가요?: ");
	scanf("%d",&n);
	
	for(i = 0;i < n;i++)
	{
		printf("fib(%d) = %d\n",i,fibo(i));
	}
	return 0;
}
