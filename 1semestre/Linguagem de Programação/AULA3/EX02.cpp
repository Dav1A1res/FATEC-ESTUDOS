#include <stdio.h>
#include <locale.h>

int main(){
	setlocale(LC_ALL, "");
	
	int numero;
	
	printf("Insira um número: ");
	scanf("%d", &numero);
	
	if (numero < 0 ) {
		printf("%d é negativo", numero);
	}
	else if (numero == 0){
		printf("%d é zero", numero);
	}
	else{
		printf("%d é positivo", numero);
	}
	printf("\n\nFim de programa");
	return 0;
}
