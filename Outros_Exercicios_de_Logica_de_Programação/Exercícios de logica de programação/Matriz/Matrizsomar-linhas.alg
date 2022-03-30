algoritmo "Matriz"
// Função : Somar Linhas
// Autor : Marconys
// Data : 27/01/2022
// Seção de Declarações 
var
m: vetor[0..2,0..2] de inteiro
soma: vetor[0..2] de inteiro
l, c: inteiro
inicio
// carregar / preencher / ler matriz 3x3
para l de 0 ate 2 faca
     para c de 0 ate 2 faca
     m[l,c] <- randi(50)
     escreva (m[l,c]) // exibir conteúdo da matriz
     fimpara
     escreval("")   // quebra de linha para imprimir matriz
fimpara
 // Somar linhas da matriz
para l de 0 ate 2 faca
     para c de 0 ate 2 faca
     soma[l] <- soma[l] + m[l,c]
     fimpara
     escreval("A soma da linha ",l, " é:", soma[l])
fimpara
fimalgoritmo
