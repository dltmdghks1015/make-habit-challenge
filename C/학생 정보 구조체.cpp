#include <stdio.h>
//#include <stdlib.h> C에서 strcpy를 사용하기 위해선 stdlib.h
#include <string.h> // c++ 에선 strcpy를 사용하려면 string.h 

struct student{
	int number;
	char name[10];
	double grade;
};

int main(void){
	struct student s;
	s.number = 20150001;
	strcpy(s.name,"홍길동");
	s.grade = 4.5;
	printf("학번 : %d \n", s.number);
	printf("이름 : %s \n", s.name);
	printf("학점 : %.1f \n", s.grade);
	return 0;
}
