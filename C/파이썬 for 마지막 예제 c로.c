#include<stdio.h>

int main(void)
{
	int i,sum,max = 0;
	int num,age;
	int min = 100;
	double avg;
	
	
	printf("������� �Է����ּ��� : ");
	scanf("%d",&num);
	for(i = 0; i < num;i++)
	{
		printf("����(1~99)�� �Է����ּ��� : ");
		scanf("%d",&age);
		if (age > 99 || age < 1)
		{
			printf("������ ���� �ʴ� �����Դϴ�.\n");
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
	
	printf("��� ���� : %.2lf,�ֿ��� : %d,�ְ�� : %d",avg,min,max);
	return 0;
}
