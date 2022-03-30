algoritmo "Matriz média"
// Função :calcular a media da matriz
// Autor : marconys
// Data : 27/01/2022
// Seção de Declarações 
var
   m: vetor[0..4, 0..1] de inteiro
   l, c: inteiro
   soma, tam: inteiro
inicio
// preenchendo a matriz
para l de 0 ate 4 faca
       para c de 0 ate 1  faca
       m[l,c] <- randi(50)
       escreva(m[l,c])
       tam <- tam + 1  // calcula o tamanho da matriz
       fimpara
       escreval("")
fimpara
// somar todos os elementos da matriz
para l de 0 ate 4 faca
       para c de 0 ate 1 faca
        soma <- soma + m[l,c]
       fimpara
fimpara
       escreval("A soma de todos elementos da matriz é:", soma)
       escreval("A matriz possui",tam," elementos")
       escreval("A média é:", soma / tam)
fimalgoritmo
