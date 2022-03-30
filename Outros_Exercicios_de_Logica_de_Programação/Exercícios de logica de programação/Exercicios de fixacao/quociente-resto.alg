algoritmo "Quociente e resto"
// Função : Calcular o quociente e o resto da divisão
// Autor :  Marconys
// Data : 28/01/2022
// Seção de Declarações 
var
x, y: inteiro
q, r: inteiro
inicio
// entrando com o dividendo e divisor
Escreval("Digite o numero dividendo")
leia(x)
Escreval("Digite o numero divisor")
leia(y)

// calculando o quociente e resto da didisão
   q <- (x \ y)
   r <- (x mod y)
   
   escreval("")
   escreva("O quociente de x/y é",q)
   escreval(" e o resto da divisão é",r)
fimalgoritmo
