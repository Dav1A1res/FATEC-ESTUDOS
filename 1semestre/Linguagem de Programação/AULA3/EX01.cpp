#include <stdio.h>
#include <locale.h>

int main(){
	setlocale(LC_ALL, "");
	
	int numero, resultado;
	
	printf("Insira um n�mero: ");
	scanf("%d", &numero);
	
	resultado = numero % 2;
	
	if (resultado >= 1 ){
		printf("%d � �mpar!", numero);
	}
	else{
		printf("%d � par!", numero);
	}
	
	printf("\n\nFim do programa");
	return 0;
}
