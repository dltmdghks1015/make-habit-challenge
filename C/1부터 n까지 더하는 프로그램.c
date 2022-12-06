#include<stdio.h>

int main(void)
{
	int num,sum,i;
	printf("숫자를 입력해주세요 :");
	scanf("%d",&num);
	for(i = 1;i <= num;i++){
		sum += i;
		if(i == num)
		{
			printf("%d = %d",num,sum);
		}
		else
		{
			printf("%d + ",i);
		}
	}
	return 0;
}
