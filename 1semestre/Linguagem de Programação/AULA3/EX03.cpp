#include <stdio.h>
#include <locale.h>

int main(){
	setlocale(LC_ALL, "");

	double peso;

	printf("Insira o seu peso para que possa ser designado à uma categoria: ");
	scanf("%lf", &peso);

	if (peso < 65.0){
		printf("Este lutador pesa %.1lf kg e se enquadra na categoria peso pena", peso);
	}
	else if ((peso >= 65 && peso < 72 )){
		printf("Este lutador pesa %.1lf kg e se enquadra na categoria peso leve", peso);
	}
	else if ((peso >= 72 && peso < 79 )){
		printf("Este lutador pesa %.1lf kg e se enquadra na categoria peso ligeiro", peso);
	}
	else if ((peso >= 79 && peso < 93 )){
		printf("Este lutador pesa %.1lf kg e se enquadra na categoria peso médio", peso);
	}
	else if ((peso >= 93 && peso < 100 )){
		printf("Este lutador pesa %.1lf kg e se enquadra na categoria peso meio pesado", peso);
	}
	else if (peso >= 100 ){
		printf("Este lutador pesa %.1lf kg e se enquadra na categoria peso pesado", peso);
	}

	printf("\n\nFim do programa");
	return 0;	
}
