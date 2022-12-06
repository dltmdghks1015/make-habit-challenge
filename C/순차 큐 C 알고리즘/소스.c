#include<stdio.h>

void QueueView(int Q[], int, int);
void enQueue(int Q[], int*);
void deQueue(int Q[], int*, int*); 

void main()
{
	int Q[5], front = -1, rear = -1;
	int sel;
	while (1)
	{
		QueueView(Q, front, rear);
		printf("\n\n\t\t[Queue]\n\n");
		printf("\t\t 1. enQueue\n\n");
		printf("\t\t 2. deQueue\n\n");
		printf("\t\t 0. Exit\n\n");
		printf("\t\t    .....[ ]\b\b");
		scanf_s("%d", &sel);
		if (sel == 1) enQueue(Q, &rear);
		else if (sel == 2) deQueue(Q, &front, &rear);
		else if (sel == 0) break;
		else printf("\n\n\t\t�޴��� �߸� �����Ͽ����ϴ�\n\n");
	}
	printf("\n\n\t\t bye \n\n");
}

void QueueView(int Q[], int front, int rear)
{
	int i;
	if (front == rear) printf("\n\n Queue is Empty front = %d, rear = %d \n\n", front, rear);
	else
	{
		printf("\n\n\t\t Queue [ ");
		for (i = front + 1; i <= rear; i++)
		{
			printf("%5d", Q[i]);
		}
		printf(" ] front = %d, rear = %d\n\n", front, rear);
	}
}
void enQueue(int Q[], int* rear)
{
	int data;
	if ((*rear) == 4) printf("\n\n\t Queue is Full \n\n"); // ť�� ���� ���ִ��� �˻�
	else
	{
		// �ڷ� �Է�
		printf("\n\n\t\t enQueue Data : ");
		scanf_s("%d", &data);
		// rear ������ ����
		(*rear)++;
		// Q�� �ڷ� �Է�
		Q[(*rear)] = data;
	}
}
void deQueue(int Q[], int* front, int* rear)
{
	if ((*front) == (*rear)) printf("\n\n\t Queue is Empty \n\n");// Queue �� ����ִ��� �˻�
	else
	{
		// front �� 1 ����
		(*front)++;
		// deQueue �� ���� ����Ѵ�.
		printf("\n\n\t\t deQueue Data is [%d]\n\n",	 Q[*front]);
	}
}