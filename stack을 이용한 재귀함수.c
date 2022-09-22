#include <stdio.h>

void print_back();

int main()
{
	printf("문자열을 입력하세요 : "); print_back();
	printf("\n");
}

//stack의 원리를 이용한 재귀함수
void print_back()
{
	int ch;
	if ((ch = getchar()) != '\n') { //한글자를 입력받고 개행문자인지 확인
		print_back();				// 개행문자가 아니면 재귀호출
	}
	putchar(ch);					// 재귀호출이 끝나면 입력받은 문자 표시 
}
