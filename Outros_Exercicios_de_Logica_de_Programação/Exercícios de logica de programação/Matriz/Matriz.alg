algoritmo "Matriz"
// Função : Criando uma Matriz
// Autor : Marconys
// Data : 27/01/2022
// Seção de Declarações 
var
m: vetor[0..2,0..2] de inteiro
l, c: inteiro
inicio
// carregar / preencher / ler matriz 3x3
para l de 0 ate 2 faca
     para c de 0 ate 2 faca
     leia(m[l,c])
     fimpara
fimpara

// exibir conteúdo da matriz
para l de 0 ate 2 faca
     // poderiamos ordenar a linha aqui
     para c de 0 ate 2 faca
     escreva(m[l,c])
     fimpara
     escreval("")
fimpara
fimalgoritmo
