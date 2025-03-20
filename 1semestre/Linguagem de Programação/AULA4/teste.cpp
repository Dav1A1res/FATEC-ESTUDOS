#include <stdio.h>
#include <locale.h>

int main(){
	setlocale(LC_ALL, "");
	
	int A;
	int soma=0, qtd=0;
	
	printf("Digite A: ");
	scanf("%d", &A);
	
	while (A != 0){
	soma = soma + A;
	qtd++;
	
	printf("Digite A: ");
	scanf("%d", &A);
	}
	
	printf("Soma = %d ", soma);
	printf("Quantidade = %d ", qtd);	

	printf("\n\nFim do programa");
	return 0;
}
