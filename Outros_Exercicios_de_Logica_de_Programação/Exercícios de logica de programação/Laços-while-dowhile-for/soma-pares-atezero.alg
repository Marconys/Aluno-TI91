algoritmo "Pares"
// Função : Somar a quantidade de numeros pares
// Autor : Marconys
// Data : 24/01/2022
// Seção de Declarações 
var
i, a, n, n1: inteiro
inicio
i<- 1
repita
se (i mod 2 = 0) entao
n <-n+1
fimse
i <- i + 1
ate i > 100
fimrepita

escreval("De 0 até 100 você tem",n, " Numeros pares!")

// intervalo digitado pelo usuário
Escreval(" Digite o ultimo numero do intervalo [300,400]")
leia(a)
repita
se (a mod 2 = 0) entao
n1 <-n1+1
fimse
a <- a - 1
ate a < 300
fimrepita
escreval("De 300 ao numero digitado, existem ",n1, " Numeros pares!")
fimalgoritmo
