#include <stdio.h>
#include <locale.h>

int main(){
	setlocale(LC_ALL, "");
	
	double n, r, p, c, soma;
	
	// n=quantidade de vezes que haverá multiplicação
	// r=razão
	// p= primeiro número
	
	printf("Digite o primeiro número da progressão: ");
	scanf("%lf", &p);
	
	printf("\nDigite a razão da progressão geométrica: ");
	scanf("%lf", &r);
	
	printf("\nDigite quantas vezes você deseja multiplicar %.0lf por %.0lf: ", p, r);
	scanf("%lf", &n);
	
	// mostra "P" antes da soma sem interferir no loop
	printf("\n%.0lf ", p);
	
	//atribui o valor de "P" para a variável soma
	soma = p;
	
	for(c=1; c<=n; c++){
		double nrp = (p *= r);
		
		// realiza a soma ao mesmo tempo que a multiplicação, enquanto "soma" contém o valor de "P"
		soma += nrp + p; 
		printf("%.0lf ", nrp);
	}

	printf("\nSOMA = %.0lf", soma);
	
	printf("\n\nFim do programa");
	return 0;
}
