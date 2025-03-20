#include <stdio.h>
#include <locale.h>

int main(){
	setlocale(LC_ALL, "");
	
	double n, r, p, c, soma;
	
	// n=quantidade de vezes que haver� multiplica��o
	// r=raz�o
	// p= primeiro n�mero
	
	printf("Digite o primeiro n�mero da progress�o: ");
	scanf("%lf", &p);
	
	printf("\nDigite a raz�o da progress�o geom�trica: ");
	scanf("%lf", &r);
	
	printf("\nDigite quantas vezes voc� deseja multiplicar %.0lf por %.0lf: ", p, r);
	scanf("%lf", &n);
	
	// mostra "P" antes da soma sem interferir no loop
	printf("\n%.0lf ", p);
	
	//atribui o valor de "P" para a vari�vel soma
	soma = p;
	
	for(c=1; c<=n; c++){
		double nrp = (p *= r);
		
		// realiza a soma ao mesmo tempo que a multiplica��o, enquanto "soma" cont�m o valor de "P"
		soma += nrp + p; 
		printf("%.0lf ", nrp);
	}

	printf("\nSOMA = %.0lf", soma);
	
	printf("\n\nFim do programa");
	return 0;
}
