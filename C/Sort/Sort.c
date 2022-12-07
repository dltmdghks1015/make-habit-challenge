#include <stdio.h>

void main()
{
	int list[] = { 69, 10, 30, 2, 16, 8, 31, 22 };
	int i, j, mininx, tmp;
	for (j = 0; j < 7; j++) {
		mininx = j;
		for (i = j; i < 8; i++) {
			if (list[i] < list[mininx]) mininx = i;
		}
		tmp = list[j];
		list[j] = list[mininx];
		list[mininx] = tmp;
	}
	
	for (i = 0; i < 8; i++)
		printf("%5d,", list[i]);
	printf("\n");
}