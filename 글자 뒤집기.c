#include<stdio.h>

int main(void)
{

   char *a = "12¾È³çÇÏ¼¼¿ä34 abcd";
   char *b;

   for(b=a;*b;b++);
   for(b--;b >= a;b--){
      if(*b & 0x80) {
         b--;
         printf("%c%c", *b, *(b+1));
      }else{
         printf("%c", *b);
      }
   }
}
