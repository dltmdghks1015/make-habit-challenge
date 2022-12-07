#include <stdio.h>
#include <stdlib.h> // 난수 생성을 위해 라이브러리를 가져옴
#include <time.h> // 난수 생성을 위해 라이브러리를 가져옴

void main()
{
	int list[10], i, j, k, tmp,arrsize;
	arrsize = sizeof(list) / sizeof(list[0]); // 배열의 길이 (파이썬에선 len)
	srand((unsigned)time(NULL)); // 난수 생성
	for (i = 0; i < arrsize; i++)
		list[i] = rand() % (70 - 21 + 1) + 21; // 난수의 범위 지정 (21 ~ 70의 난수)
	printf("발행난수 : ");
	for (i = 0; i < arrsize; i++)
		printf("%5d", list[i]);
	printf("\n\n");

	for (i = 0; i < arrsize - 1; i++)
	{
		for (j = i + 1; j < arrsize; j++)
		{
			if (list[i] > list[j])
			{
				tmp = list[i];
				list[i] = list[j];
				list[j] = tmp;
			}
		}
	}
	printf("소트된수 : ");
	for (i = 0; i < arrsize; i++)
		printf("%5d", list[i]);
	printf("\n\n");
}

// 또 다른 삽입 정렬

/*
#include <stdio.h>
#include <stdlib.h>
#include <time.h>

void main()
{
	int list[10], i, j, k, tmp;
	srand((unsigned)time(NULL));
	for (i = 0; i < 10; i++)
		list[i] = rand() % (70 - 21 + 1) + 21; // 21 ~ 70의 난수
	printf("발행난수 : ");
	for (i = 0; i < 10; i++)
		printf("%5d",list[i]);
	printf("\n");
	// 삽입 정렬 알고리즘
	for (i = 0; i < 10; i++)
	{
		for (j = i + 1; j <= 10; j++)
		{
			if (list[i] > list[j])
			{
				tmp = list[i];
				for (k = i; k > j; k--)
				{
					list[k] = list[k - 1];
				}
				list[j] = tmp;
			}
		}
		printf("%d 단계 : ",i);
		for (k = 0; k < 10; k++)
			printf("%5d", list[k]);
		printf("\n");
	}
	printf("소트된수 : ");
	for (i = 0; i < 10; i++)
		printf("%5d", list[i]);
	printf("\n");
}
*/