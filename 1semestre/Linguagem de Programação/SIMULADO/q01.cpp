#include <stdio.h>
#include <stdlib.h>
#include <locale.h>

int main(){
	setlocale(LC_ALL, "");
	printf("Davi Aires Castanho\n");
	printf("Quest�o 01\n\n");
	
	int min, max, i=0, num, qtde_p=0;
	int *P= NULL; 
	
	printf("Insira o valor M�nimo: ");
	scanf("%d", &min);
	
	printf("Insira o valor M�ximo: ");
	scanf("%d", &max);
	
	num = rand() % (max + 1 - min) + min;
	
	if (max < min + 100){
		printf("\nValores inv�lidos. O valor m�ximo deve ser pelo menos o valor de m�nimo + 100.");
	}
	else {
			do{
				if(i == 0) {
				P = (int *)malloc(qtde_p * sizeof(int)); 
				} 
				
				printf("\nPalpite %d: ", qtde_p+1);
				scanf("%d", &P[i]);
				
				if (P[i] < num){
					printf("errado: seu palpite deve ser maior\n\n");
				}
				else if (P[i] > num){
					printf("errado: seu palpite deve ser menor\n\n");	
				}
				
				i++;
				qtde_p++;
				
			} while(P[i-1] != num);
		
					printf("Acertou!!!");
					printf("\n\nResultado:");
					printf("\nForam %d palpites at� voc� acertar", qtde_p);
					printf("\nE os seus palpites foram: ");
					
					for(int j = 0; j < qtde_p; j++) {
			    	printf("%d ", P[j]);
			        }
					
					
		free (P);
		}
	printf("\n\nFim do programa");
	return 0;
}
