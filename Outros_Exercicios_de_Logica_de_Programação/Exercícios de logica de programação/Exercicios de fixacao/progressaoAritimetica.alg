algoritmo "Progressão aritimética"
// Função : Calcular a razão da PA e somar os dois valores de entrada
// Autor : Marconys
// Data : 29/01/2022
// Seção de Declarações 
var
   n1, n2, r, i, p: inteiro
inicio
// Entrando com os valores de n1 e n2

escreval("Digite o primeiro numero da PA")
leia(n1)
escreval("Digite o segundo numero da PA")
leia(n2)
  // buscando a razão da PA
se (n1 > n2) entao
     r <- n1 - n2
     senao
     r <- n2 - n1
     fimse
se(n1 > n2) entao
     p <- n2
     senao
     p <- n1
     fimse
 escreva("PA")
 // construindo a PA
para i de 0 ate 10 faca

escreva(p)
p <-p + r

fimpara
escreval("")
escreval ("A soma do de N1 + N2 é: ", n1 + n2,", e a razão sa PA é:", r)

fimalgoritmo
