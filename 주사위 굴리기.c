#include<stdio.h>
#include<stdlib.h>
#include<time.h>

int main(void)
{
	int i,num;
	srand(time(NULL));
	printf("�ֻ��� ���� Ƚ���� �Է����ּ��� :  ");
	scanf("%d",&num);
	
	for (i = 0;i < num;i++)
	{
		printf("�ֻ����� ���� : %d\n",(rand() % 6) + 1);
	}
	return 0;
}
