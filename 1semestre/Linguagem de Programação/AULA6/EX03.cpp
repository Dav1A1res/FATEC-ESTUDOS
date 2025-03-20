#include <stdio.h>
#include <locale.h>

int main() {
	setlocale(LC_ALL, "");
	
    int V[15] = {17, 4, 53, 38, 22, 40, 25, 16, 31, 64, 45, 32, 20, 12, 29};
    int A;

    do {
        printf("Digite um valor inteiro (ou 0 para parar): ");
        scanf("%d", &A);

        if (A > 0) {
            int i;
            int encontrado = 0;

            for (i = 0; i < 15; i++) {
                if (V[i] == A) {
                    printf("O valor %d está no vetor na posição %d \n\n", A, i);
                    encontrado = 1;
                }
            }

            if (!encontrado) {
                printf("O valor %d não está no vetor \n\n", A);
            }
        }
    } while (A > 0);

    printf("\nFim do programa");

    return 0;
}
