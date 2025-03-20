#include <stdio.h>
#include <stdlib.h>
#include <locale.h>

int main(){
	setlocale(LC_ALL, "");
	printf("Davi Aires Castanho\n");
	printf("Quest�o 02\n");

	int n, vpar;
	int i=0, vv=0, j;
	
	do {
		printf("\nEntrada: ");
		scanf("%d", &n);
		
		vpar = n % 2;
		
		if (vpar == 1 || n < 6 || n > 32){
			printf("O n�mero %d � inv�lido!\n", n);
		}
		else {
			printf("O n�mero %d � v�lido!\n", n);
			
			//imprimir as primeiras duas linhas
			printf(" ");
		    for (i = 0; i < n - 2; i++) {
		        printf("*");
		    }
		    printf("\n");
		    
		    for (i = 0; i < n; i++){
		    	printf("*");
			}
		    printf("\n");
		    
		    // Loop para imprimir as linhas internas do "0" sem espa�os laterais
		    for (i = 0; i < n - 2; i++) {
		        printf("**");
		        for (j = 0; j < n - 4; j++) {
		            printf(" ");
		        }
		        printf("**\n");
		    }
		    
		    for (i = 0; i < n; i++){
		    	printf("*");
			}
			printf("\n");
		    
		    // Imprimir a �ltima linha com um espa�o � esquerda
		    printf(" ");
		    for (i = 0; i < n - 2; i++) {
		        printf("*");
		    }
		    printf("\n");
			vv++;
		}
	}while(vv == 0);
	
	
	printf("\n\nFim do programa");
	return 0;
}
