#include <stdio.h>

void main()
{
	int list[] = { 69, 10, 30, 2, 16, 8, 31, 22 };
	int i, tmp, j;
	int sizearr;

	sizearr = sizeof(list) / sizeof(list[0]); /* 원소의 개수 구하는 법 */
	printf("원본  :");
	for (i = 0; i < sizearr; i++)
		printf("%5d", list[i]);
	printf("\n");
	for (j = sizearr - 1; j > 0; j--)
	{
		for (i = 0; i < j; i++)
		{
			if (list[i] > list[i + 1])
			{
				tmp = list[i];
				list[i] = list[i + 1];
				list[i + 1] = tmp;
			}
		}
		printf("%d회전 :", sizearr - j);
		for (i = 0; i < sizearr; i++)
			printf("%5d", list[i]);
		printf("\n");
	}
	printf("소트 :");
	for (i = 0; i < 8; i++)
		printf("%5d", list[i]);
	printf("\n");
}