algoritmo "Matriz cont par"
// Função : contar numeros pares da matriz
// Autor :  Marconys
// Data : 27/01/2022
// Seção de Declarações 
var
m: vetor[0..4, 0..4] de inteiro
l, c, par: inteiro
inicio
para l de 0 ate 4 faca
       para c de 0 ate 4 faca
       m[l,c]  <- randi(50)
       escreva(m[l,c])
       fimpara
       escreval("")
fimpara
para l de 0 ate 4 faca
       para c de 0 ate 4 faca
       se (m[l,c] mod 2 = 0) entao
            par <- par +1
       fimse
       fimpara
fimpara
escreval("A matriz possui",par," numeros pares")
fimalgoritmo
