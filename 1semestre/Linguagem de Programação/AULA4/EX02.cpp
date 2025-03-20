#include <stdio.h>
#include <locale.h>

int main() {
    setlocale(LC_ALL, "");

    int c, num, neg = 0, pos = 0;

    printf("Digite valores inteiros para serem somados. Quando quiser parar, digite 0.\n");
 
 	do {
 		printf("Digite um número: ");
 		scanf("%d", &num);
 		
 		if (num > 0) {
		 	pos += num;
		 } else {
		 	neg += num;
		 }
	 } while (num != 0);

    printf("Total dos negativos = %d\n", neg);
    printf("Total dos positivos = %d\n", pos);

    printf("\nFim do programa");
    return 0;
}

