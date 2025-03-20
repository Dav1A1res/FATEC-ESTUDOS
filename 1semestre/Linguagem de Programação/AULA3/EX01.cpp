#include <stdio.h>
#include <locale.h>

int main(){
	setlocale(LC_ALL, "");
	
	int numero, resultado;
	
	printf("Insira um número: ");
	scanf("%d", &numero);
	
	resultado = numero % 2;
	
	if (resultado >= 1 ){
		printf("%d é ímpar!", numero);
	}
	else{
		printf("%d é par!", numero);
	}
	
	printf("\n\nFim do programa");
	return 0;
}
