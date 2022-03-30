algoritmo "Numeros pares"
// Função :  somar a quantidade de numeros pares
// Autor :   marconys
// Data : 31/01/2022
// Seção de Declarações 
var
array: vetor[0..3] de inteiro
i, par, par1: inteiro
inicio
// Digitando os Valores do vetor
para i de 0 ate 3 faca
escreval("Digite o ",i+1,"º valor")
leia(array[i])
se ( array[i] mod 2 = 0) entao
par <- par + array[i]
par1 <- par1 + 1
fimse
fimpara
escreval("")
escreva("O array possui",par1," numero(s) par(es)")
escreva(" e a soma entre eles é: ", par)
escreval("")

fimalgoritmo
