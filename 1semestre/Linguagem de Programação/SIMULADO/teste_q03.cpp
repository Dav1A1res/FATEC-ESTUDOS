#include <stdio.h>

// Fun��o para encontrar o pre�o unit�rio baseado na quantidade vendida
float encontrarPrecoUnitario(int codigo, int quantidade, int QMA) {
    float precoVarejo[] = {14.34, 35.12, 19.35, 63.40};
    float precoAtacado[] = {12.93, 29.85, 16.76, 58.25};
    
    if (quantidade < QMA)
        return precoVarejo[codigo];
    else
        return precoAtacado[codigo];
}

int main() {
    int codigo, quantidade, QMA;
    int NV, i;
    float totalVarejo = 0, totalAtacado = 0, totalVendas = 0;

    // Defini��o da quantidade m�nima para atacado (QMA)
    int quantidadesMinimasAtacado[] = {50, 100, 70, 40};

    printf("Informe o n�mero de vendas realizadas: ");
    scanf("%d", &NV);

    for (i = 0; i < NV; i++) {
        printf("Informe o c�digo e a quantidade da venda %d: ", i+1);
        scanf("%d %d", &codigo, &quantidade);

        // Verificar se o c�digo � v�lido
        if (codigo >= 0 && codigo < 4) {
            QMA = quantidadesMinimasAtacado[codigo];
            float precoUnitario = encontrarPrecoUnitario(codigo, quantidade, QMA);
            float valorVenda = precoUnitario * quantidade;

            // Verificar se a venda pertence ao grupo Varejo ou Atacado
            if (quantidade < QMA)
                totalVarejo += valorVenda;
            else
                totalAtacado += valorVenda;

            // Total de vendas
            totalVendas += valorVenda;
        } else {
            printf("C�digo inv�lido.\n");
            i--; // Decrementa i para repetir a leitura deste par de dados
        }
    }

    // Apresentar os resultados
    printf("\nTotal de vendas no Grupo Varejo: R$ %.2f\n", totalVarejo);
    printf("Total de vendas no Grupo Atacado: R$ %.2f\n", totalAtacado);
    printf("Valor total de vendas: R$ %.2f\n", totalVendas);

    return 0;
}

