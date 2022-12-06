#include <stdio.h>
#include <stdlib.h>

int main (void)
{
	int *pi; //Pointer Integer
	pi = (int *)malloc(sizeof(int));
	if(pi == NULL)
	{
		printf("동적 메모리 할당에 실패했습니다.\n");
		exit(1);
	}
	*pi = 100;
	printf("%d",*pi);
	/* 동적 메모리 사용한 이후에는 무조건 해당 메모리를 반환합니다. */
	free(pi);
	return 0;
}
