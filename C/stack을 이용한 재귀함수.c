#include <stdio.h>

void print_back();

int main()
{
	printf("���ڿ��� �Է��ϼ��� : "); print_back();
	printf("\n");
}

//stack�� ������ �̿��� ����Լ�
void print_back()
{
	int ch;
	if ((ch = getchar()) != '\n') { //�ѱ��ڸ� �Է¹ް� ���๮������ Ȯ��
		print_back();				// ���๮�ڰ� �ƴϸ� ���ȣ��
	}
	putchar(ch);					// ���ȣ���� ������ �Է¹��� ���� ǥ�� 
}
