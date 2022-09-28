#include<stdio.h>

int main(void)
{
	int list[7] = { 10,20,40,50,60,70 };
	int i, data,index;

	printf("삽입원소 : ");
	scanf("%d", &data);
	
	//원소가 들어갈 위치 찾기 : index 변수
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
	//마지막 원소부터 index위치의 원소까지 뒤로 이동
	for (i = 6; i > index; i--)
	{
		list[i] = list[i - 1];
	}
	//index 위치에 삽입할 원소 넣기
	list[index] = data;
	//선형리스트 출력
	for (i = 0; i < 7; i++)
		printf("%d\t", list[i]);
	printf("\n");
	printf("====삭제알고리즘====\n\n");
	printf(" 삭제 원소 : ");
	scanf("%d", &data);

	for (i = 0; i < 7; i++)
		if (list[i] == data)
		{
			index = i;
			break;
		}
	if (i == 7) printf("삭제할 원소를 찾지 못했습니다.\n");
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