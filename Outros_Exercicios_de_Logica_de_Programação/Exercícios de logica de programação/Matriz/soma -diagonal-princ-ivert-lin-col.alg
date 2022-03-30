algoritmo "Matriz diagonal principal"
// Função : somar a diagonal principal
// Autor : marconys
// Data : 28/01/2022
// Seção de Declarações 
var
m:vetor[0..4,0..4] de inteiro // matriz quadrada 5x5
l, c, dp, di, sl, sc: inteiro
inicio
// Seção de Comandos
// preenchendo a matriz
para l de 0 ate 4 faca
sl <- 0
para c de 0 ate 4 faca
//se (l=c) entao
m[l,c] <- randi(9)
// fimse
sl <- sl + m[l,c] // soma da linha da matriz
escreva(" ",m[l,c])
fimpara
escreva(" <-",sl)
escreval("")
fimpara
// somando as colunas da matriz
para c de 0 ate 4 faca
sc <- 0
para l de 0 ate 4 faca
sc <- sc + m[l,c]
fimpara
escreva(sc)
fimpara
escreval("")



// somando a diagonal principal
para l de 0 ate 4 faca
para c de 0 ate 4 faca
se (l=c) entao
dp <- dp + m[l,c]
fimse
fimpara
fimpara
escreval("A soma da diagonal principal é:", dp)
// somando a diagonal invertida
para l de 0 ate 4 faca
para c de 0 ate 4 faca
se ((l+c)=4) entao
di <- di + m[l,c]
fimse
fimpara
fimpara
escreval("A soma da diagonal invertida é:", di)
fimalgoritmo
