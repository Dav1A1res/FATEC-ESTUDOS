#include <stdio.h>
#include <locale.h>

int main(){
	setlocale(LC_ALL, "");
	
	int numero;
	
	printf("Insira um n�mero: ");
	scanf("%d", &numero);
	
	if (numero < 0 ) {
		printf("%d � negativo", numero);
	}
	else if (numero == 0){
		printf("%d � zero", numero);
	}
	else{
		printf("%d � positivo", numero);
	}
	printf("\n\nFim de programa");
	return 0;
}
