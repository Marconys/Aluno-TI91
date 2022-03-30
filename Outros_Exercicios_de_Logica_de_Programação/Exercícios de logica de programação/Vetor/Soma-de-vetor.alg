algoritmo "Soma de Vetores"
// Função : Somar vetor
// Autor : Marconys
// Data : 26/01/2022
// Seção de Declarações 
var
array: vetor[0..10] de inteiro
i: inteiro
inicio
// preencher array e declarar posição
para i de 0 ate 9 faca
escreval("Digite o ",i+1,"º valor")
leia(array[i])
// somar array
array[10] <- array[10] + array[i]
fimpara
// ler o vetor na posição do acumulador - soma
escreval("A soma dos valores do vetor é:",array[10])
fimalgoritmo
