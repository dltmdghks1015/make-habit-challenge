#include<stdio.h>

int main(void)
{
	int list[7] = { 10,20,40,50,60,70 };
	int i, data,index;

	printf("���Կ��� : ");
	scanf("%d", &data);
	
	//���Ұ� �� ��ġ ã�� : index ����
	if (data < list[0]) index = 0;
	else
	{
		for (i = 0; i < 6; i++)
		{
			if (list[i] <= data && data <= list[i + 1])
			{
				index = i + 1;
				break;
			}
		}
		if (i == 6) index = i;
	}
	//������ ���Һ��� index��ġ�� ���ұ��� �ڷ� �̵�
	for (i = 6; i > index; i--)
	{
		list[i] = list[i - 1];
	}
	//index ��ġ�� ������ ���� �ֱ�
	list[index] = data;
	//��������Ʈ ���
	for (i = 0; i < 7; i++)
		printf("%d\t", list[i]);
	printf("\n");
	printf("====�����˰���====\n\n");
	printf(" ���� ���� : ");
	scanf("%d", &data);

	for (i = 0; i < 7; i++)
		if (list[i] == data)
		{
			index = i;
			break;
		}
	if (i == 7) printf("������ ���Ҹ� ã�� ���߽��ϴ�.\n");
	else
	{
		for (i = index; i < 6; i++)
		{
			list[i] = list[i + 1];
		}
		list[i] = 0;
	}
	for (i = 0; i < 7; i++)
		printf("%d\t", list[i]);
	printf("\n");
	return 0;
}