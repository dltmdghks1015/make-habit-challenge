#include<stdio.h>
#include<stdlib.h>
#include<time.h>

int main(void)
{
	int i,num;
	srand(time(NULL));
	printf("주사위 던질 횟수를 입력해주세요 :  ");
	scanf("%d",&num);
	
	for (i = 0;i < num;i++)
	{
		printf("주사위의 숫자 : %d\n",(rand() % 6) + 1);
	}
	return 0;
}
