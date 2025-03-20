#include <stdio.h>
#include <stdlib.h>
#include <locale.h>

int main(){
	setlocale(LC_ALL, "");
	printf("Davi Aires Castanho\n");
	printf("Questão 01\n\n");
	
	int min, max, i=0, num_esc, qtde_p=0, resp;
	int v = 0;
	int *P= NULL; 
		
	printf("Insira o valor Mínimo: ");
	scanf("%d", &min);
	
	printf("Insira o valor Máximo: ");
	scanf("%d", &max);
	
	printf("Número pensado pelo humano: ");
	scanf("%d", &num_esc);
	
	if (num_esc < min || num_esc > max){
		printf("Número inválido, digite algum que esteja entre o intervalo de min e max");
	}
	
	if (max < min + 100){
		printf("\nValores inválidos. O valor máximo deve ser pelo menos o valor de mínimo + 100.");
	}
	else {
			do{
				if(i == 0) {
				P = (int *)malloc(qtde_p * sizeof(int)); 
				} 
				
				P[i] = rand() % (max + 1 - min) + min;
				printf("\nPalpite %d: %d", qtde_p+1, P[i]);
				
				if (P[i] < num_esc){
					printf("\n errado: seu palpite deve ser maior\n");
				}
				
				else if (P[i] > num_esc){
					printf("\n errado: seu palpite deve ser menor\n");
				}
				
				i++;
				qtde_p++;
				
			} while(P[i-1] != num_esc);
		
					printf("\nAcertou!!!");
					printf("\n\nResultado:");
					printf("\nForam %d palpites até o computador acertar", qtde_p);
					printf("\nE os seus palpites foram: ");
					
					for(int j = 0; j < qtde_p; j++) {
			    	printf("%d, ", P[j]);
			        }
					
					
		free(P);
		}
	printf("\n\nFim do programa");
	return 0;
}
