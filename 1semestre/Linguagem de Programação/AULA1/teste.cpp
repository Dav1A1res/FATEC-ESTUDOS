#include <stdio.h>
#include <locale.h>
	int main() {
	int X;
	setlocale(LC_ALL, "");
	printf("Digite o valor de x: ");
	scanf("%d", &X);
	if (X > 0)
		printf("%d � positivo", X);
	else
		printf("%d � negativo", X);
	return 0;
}
