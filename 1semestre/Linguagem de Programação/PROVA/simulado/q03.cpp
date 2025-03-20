#include <stdio.h>
#include <stdlib.h>
#include <locale.h>

int main(){
	setlocale(LC_ALL, "");
	printf("Davi Aires Castanho\n");
	printf("Questão 03\n\n");
	
	int nv, prv, pra, qv;
	int cod;
	int i=0;
	
		printf("Insira o número de vendas realizadas: ");
		scanf("%d", &nv);
		
		int V[nv];	
		
		if (nv > 0 ){
				printf("           COD      QV");
			for (i=0; i < nv; i++){
				
				printf("\nVenda %d", nv);
				printf("\nCOD: ");
				scanf("%d", &cod);
				printf("QV: ");
				scanf("%d", qv);
			}
		
		
		
		
		
		}
		else{
			printf("NV: %d é inválido", nv);
		}
		
		
	printf("\n\nFim do Programa");
	return 0;
}
