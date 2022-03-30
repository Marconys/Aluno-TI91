algoritmo "Velocidade maxima"
// Função :  calcular a multa por velocidade
// Autor :   Marconys
// Data : 31/01/2022
// Seção de Declarações 
var
multa, veloPer, veloMax, veloDif: inteiro
inicio
// inicializando as variavéis
veloPer <- 10
escreval("Digite a velocidade maxima atingida")
leia(veloMax)
 veloDif <- velomax - veloPer
 se(veloDif <= 10) entao
 escreval("Multa de 50,00 R$")
 senao
 se(veloDif >= 11) e ( veloDif <= 30) entao
 escreval("Multa de 100,00 R$")
 senao
 se(veloDif >= 31) entao
 escreval("Multa de 200,00 R$")
      senao("Dentro da velocidade permitida")
      fimse
 fimse
 fimse
fimalgoritmo
