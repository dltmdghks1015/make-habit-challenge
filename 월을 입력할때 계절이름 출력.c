#include<stdio.h>

int main(void)
{
	int a;
	printf("���� �Է����ּ��� : ");
	scanf("%d",&a);
	
	if(a < 0 || a > 12)
	{
		printf("�������� ���� �Էµ��� �ʾҽ��ϴ�");
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
