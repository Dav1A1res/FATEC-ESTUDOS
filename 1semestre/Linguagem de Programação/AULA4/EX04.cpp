#include <stdio.h>
#include <locale.h>

int main() {
    setlocale(LC_ALL, "");

    int num, maior, menor, soma = 0, qtd = 0;
	double media;
	
    printf("Digite números positivos e inteiros. Quando terminar digite 0 ou um número negativo para encerrar o programa e mostrar os resultados.\n\n");
 

   do {
        printf("Digite um número: ");
        scanf("%d", &num);

        if (num > 0) {
            soma += num;
            qtd++;

            if (qtd == 1) {
                maior = menor = num;
            } else {
            	
                if (num > maior) {
                    maior = num;
                }

                if (num < menor) {
                    menor = num;
                }
            }
        }
    } while (num > 0);

    if (qtd > 0) {
        media = (soma / qtd);

        printf("\nMaior valor: %d\n", maior);
        printf("Menor valor: %d\n", menor);
        printf("Quantidade de valores: %d\n", qtd);
        printf("Soma dos valores: %d\n", soma);
        printf("Média dos valores: %.1lf\n", media);
    } else {
        printf("Nenhum valor positivo foi inserido.\n");
    }
    printf("\nFim do programa");
    return 0;
}

