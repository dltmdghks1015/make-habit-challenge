#include <stdio.h>
#include <stdlib.h>
#include <time.h>
void AddItem(int bucket[][8], int bucketinx, int item);

void main()
{
	int list[10], i, j, k, tmp, arrsize;
	int bucket[10][8], bucketinx,inx;
	arrsize = sizeof(list) / sizeof(list[0]);
	srand((unsigned)time(NULL));
	for (i = 0; i < arrsize; i++)
		list[i] = rand() % (70 - 21 + 1) + 21; // 21 ~ 70의 난수
	printf("발행난수 : ");
	for (i = 0; i < arrsize; i++)
		printf("%5d", list[i]);
	printf("\n\n");

	for (i = 0; i < 10; i++)
		for (j = 0; j < 8; j++)
			bucket[i][j] = -999;
	for (i = 0; i < arrsize; i++)
	{
		bucketinx = list[i] % 10;
		AddItem(bucket, bucketinx, list[i]);
	}
	inx = 0;
	for (i = 0; i < 10; i++)
	{
		printf("bucket %d :", i);
		for (j = 0; bucket[i][j] != -999; j++)
		{
			printf("%5d", bucket[i][j]);
			list[inx] = bucket[i][j];
			inx++;
		}
		printf("\n");
	}
	printf("\n일의자리 소트 : ");

	for (i = 0; i < 10; i++)
		for (j = 0; j < 8; j++)
			bucket[i][j] = -999;

	for (i = 0; i < arrsize; i++)
		printf("%5d", list[i]);
	printf("\n");
	for (i = 0; i < arrsize; i++)
	{
		bucketinx = list[i] / 10;
		AddItem(bucket, bucketinx, list[i]);
	}
	inx = 0;
	for (i = 0; i < 10; i++)
	{
		printf("bucket %d :", i);
		for (j = 0; bucket[i][j] != -999; j++)
		{
			printf("%5d", bucket[i][j]);
			list[inx] = bucket[i][j];
			inx++;
		}
		printf("\n");
	}
	printf("\n십의자리 소트 : ");
	for (i = 0; i < arrsize; i++)
		printf("%5d", list[i]);
	printf("\n");
}

void AddItem(int bucket[][8], int bucketinx, int item)
{
	int i;
	for (i = 0; bucket[bucketinx][i] != -999; i++);
	bucket[bucketinx][i] = item;
}