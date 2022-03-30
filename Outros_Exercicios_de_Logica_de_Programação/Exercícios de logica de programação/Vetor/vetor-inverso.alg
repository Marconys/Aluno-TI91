algoritmo "Digitar vetor2"
// Função : Imprimir vetor na ordem inversa que foi digitado
// Autor : Marconys
// Data : 26/01/2022
// Seção de Declarações 
var
v: vetor[0..10] de inteiro
i: inteiro
inicio
// Seção de Comandos
para i de 0 ate 9 faca
//escreval("Digite o ",i+1,"º valor")
leia(v[i])
v[10] <- v[i] // soma
fimpara
// ler o vetor na posição do acumulador - soma
escreval(" A ordem inversa digitada do vetor é:")
escreval(v[9])
escreval(v[8])
escreval(v[7])
escreval(v[6])
escreval(v[5])
escreval(v[4])
escreval(v[3])
escreval(v[2])
escreval(v[1])
escreval(v[0])

fimalgoritmo
