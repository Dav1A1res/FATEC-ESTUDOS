#include <stdio.h>
#include <locale.h>

int main() {
    setlocale(LC_ALL, "");

    int c, num, neg = 0, pos = 0;

    printf("Digite um valor inteiro e o programa ir� lhe informar se ele � negativo ou positivo. Quando terminar digite 0.\n\n");
 
 	do {
 		printf("Digite um n�mero: ");
 		scanf("%d", &num);
 		
 		if (num > 0) {
		 	printf("%d � positivo!\n", num);
		 } else if (num < 0) {
		 	printf("%d � negativo!\n", num);
		 }
	 } while (num != 0);

    printf("\nFim do programa");
    return 0;
}

