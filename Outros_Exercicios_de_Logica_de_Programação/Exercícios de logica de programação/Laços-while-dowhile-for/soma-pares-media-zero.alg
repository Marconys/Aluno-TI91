algoritmo "Pares media"
// Função : Calcular a média se os numeros digitados forem pares
// Autor : Marconys
// Data : 24/01/2022
// Seção de Declarações 
var
a, b: inteiro
inicio
repita
escreval("Digite o valor de A")
leia(a)
escreval("Digite o valor de B")
leia(b)
se( a mod 2 = 0) e (b mod 2 = 0) entao
escreval("A média de A + B é:",(a + b) /2)
fimse
ate (a < 1) ou (b < 1)
fimrepita
fimalgoritmo
