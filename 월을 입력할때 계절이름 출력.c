#include<stdio.h>

int main(void)
{
	int a;
	printf("월을 입력해주세요 : ");
	scanf("%d",&a);
	
	if(a < 0 || a > 12)
	{
		printf("정상적인 월이 입력되지 않았습니다");
	}
	else
	{
		switch(a)
		{
			case 12:
			case 1:
			case 2:
				printf("winter");
			break;
			case 3:
			case 4:
			case 5:
				printf("spring");
			break;
			case 6:
			case 7:
			case 8:
				printf("summer");
			break;
			case 9:
			case 10:
			case 11:
				printf("fall");
		}	
	} 
	return 0;
}
