#include <stdio.h>

void push();
void pop();

int S[5] = { 0 };
int top = -1;

void main()
{
	int sel, i;
	while (1)
	{
		printf("\n\n\ top : %d", top);
		printf("\n\n Stack [");
		for (i = 0; i <= top; i++)
		{
			printf("%5d", S[i]);
		}
		printf(" ] \n\n");

		printf("\n\n[스택 입출력 알고리즘]");
		printf("\n\n 1. 삽입 push() ");
		printf("\n\n 2. 삭제 pop()");
		printf("\n\n 0. 종료");
		printf("\n\n .......[ ]\b\b");
		scanf_s("%d", &sel);
		if (sel == 0) break;
		else if (sel == 1) push();
		else if (sel == 2) pop();
		else printf("\n\n 0~2 사이의 숫자를 입력하세요 \n\n");
	}
}

void push()
{
	int num;
	printf("입력할 숫자 : ");
	scanf_s("%d", &num);
	if (top + 1 > 4) printf("\n\n error .... stack overflow \n\n");
	else
	{
		top++;
		S[top] = num;
	}
}

void pop()
{
	if (top == -1) printf("\n\n error .... stack underflow \n\n");
	else
	{
		printf("\n\n pop data : %d", S[top]);
		S[top] = 0;
		top--;
	}
}