algoritmo "Menor que"
// Função :  digitar dois numeros e identificar o menor deles
// Autor :  Marconys
// Data : 21/01/2022
// Seção de Declarações 
var
n1, n2: real
inicio
 escreval("Digite o primeiro numero")
 leia(n1)
 escreval("Digite o primeiro numero")
 leia(n2)
 se(n1 < n2) entao
         escreval(n1, " É o menor valor digitado")
         senao
         se  (n1 > n2) entao
         escreval(n2, " É o menor valor digitado")
         senao
         escreval("Os valores são iguais")
         fimse
 fimse
fimalgoritmo
