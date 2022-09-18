#include <stdio.h>
int main()
{
    int a, b, c;
    scanf("%d", &a);
    if (a < 60){
    printf("0일 0시간 0분 %d초", a);
	}
    else if (60 <= a && a < 3600){
    printf("0일 0시간 %d분 %d초", a / 60, a % 60);
	}
    else if (3600 <= a && a < 86400){
	printf("0일 %d시간 %d분 %d초", a / 3600, a / 60 % 60, a % 3600 % 60);
	}
    else {
	printf("%d일 %d시간 %d분 %d초", a / 86400, a / 3600 % 24, a / 60 % 60, a % 86400 % 60);
	}
	return 0;
}
