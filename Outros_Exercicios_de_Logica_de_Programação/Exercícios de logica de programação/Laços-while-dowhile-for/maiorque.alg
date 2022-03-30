algoritmo "Maior que"
// Função : localizar o maior numero digitado até que seja igual a zero
// Autor :  Marconys
// Data : 26/01/2022
// Seção de Declarações 
var
n1, n2: real
inicio
repita
 escreval("Digite o primeiro numero")
 leia(n1)
 escreval("Digite o primeiro numero")
 leia(n2)
 se(n1 > n2) entao
         escreval(n1, " é maior que ", n2)
         senao
         se  (n1 < n2) entao
         escreval(n2, " é maior que ", n1)
         senao
         escreval("Os valores são iguais")
         fimse
 fimse
 ate  (n1 < 1) ou (n2 < 1)
 fimrepita
fimalgoritmo
