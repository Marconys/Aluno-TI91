algoritmo "Matriz somar coluna"
// Função :  Somar as colunas da matriz
// Autor : Marconys
// Data : 27/01/2022
// Seção de Declarações
var
   m: vetor[0..2, 0..2] de inteiro
   soma: vetor[0..2] de inteiro
   l, c: inteiro
inicio
// declarando a matriz de forma aleatória
para l de 0 ate 2 faca
       para c de 0 ate 2 faca
       m[l,c] <- randi(50)
       escreva(m[l,c])
       fimpara
       escreval("")
fimpara
// soma das colunas
 para l de 0 ate 2 faca
       para c de 0 ate 2 faca
       soma[c] <- soma[c] + m[l,c]
       fimpara
 fimpara
 para c de 0 ate 2 faca
 escreval("A soma da coluna ",c, " é:",soma[c])
 fimpara
fimalgoritmo
