#include<stdio.h>

int main(void)
{
	int i,sum,max = 0;
	int num,age;
	int min = 100;
	double avg;
	
	
	printf("사람수를 입력해주세요 : ");
	scanf("%d",&num);
	for(i = 0; i < num;i++)
	{
		printf("나이(1~99)를 입력해주세요 : ");
		scanf("%d",&age);
		if (age > 99 || age < 1)
		{
			printf("범위에 맞지 않는 나이입니다.\n");
		}
		else
		{
			sum += age;
			if(max < age){
				max = age;	
			} 
			if (min > age){
				min = age;	
			}
		}
	}
	avg = sum / num;
	
	printf("평균 나이 : %.2lf,최연소 : %d,최고령 : %d",avg,min,max);
	return 0;
}
