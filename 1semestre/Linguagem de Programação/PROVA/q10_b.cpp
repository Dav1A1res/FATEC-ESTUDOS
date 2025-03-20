#include <stdio.h>
#include <stdlib.h>
#include <locale.h>

int main(){
	setlocale(LC_ALL, "");
	printf("Davi Aires Castanho\n");
	printf("Quest�o 01\n\n");
	
	int min, max, i=0, num_esc, qtde_p=0, respu;
	int v = 0;
	int *P= NULL; 

do{		
	printf("Insira o valor M�nimo: ");
	scanf("%d", &min);
	
	printf("Insira o valor M�ximo: ");
	scanf("%d", &max);
	
	printf("N�mero pensado pelo humano: ");
	scanf("%d", &num_esc);
	
	if (num_esc < min || num_esc > max){
		printf("\nN�mero inv�lido, digite algum que esteja entre o intervalo de min e max\n\n");
	}
}while(num_esc < min || num_esc > max);
	if (max < min + 100){
		printf("\nValores inv�lidos. O valor m�ximo deve ser pelo menos o valor de m�nimo + 100.");
	}
	else {
			do{
				if(i == 0) {
				P = (int *)malloc(qtde_p * sizeof(int)); 
				} 
				P[i] = rand() % (max + 1 - min) + min;
				printf("\nPalpite %d:", qtde_p+1);
				
				if (P[i] < num_esc){
					printf("\n%d", P[i]);

				}
				
				else if (P[i] > num_esc){
					printf("\n%d errado: seu palpite deve ser menor\n", P[i]);

				}
				
				i++;
				qtde_p++;
			} while(P[i-1] != num_esc);
					printf("\nAcertou!!!");
					printf("\nResultado:");
					printf("\nForam %d palpites at� o computador acertar", qtde_p);
					printf("\nE os palpites foram: ");
					
					for(int j = 0; j < qtde_p; j++) {
			    	printf("%d, ", P[j]);
			        }
					
					
		free(P);
		}
	printf("\n\nFim do programa");
	return 0;
}
