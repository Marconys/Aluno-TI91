algoritmo "Ordenaçao"
// Função : Ordenando numeros na ordem crescente
// Autor :  Marconys
// Data : 31/01/2022
// Seção de Declarações 
var
numero: vetor[0..2] de inteiro
i, a , b, t: inteiro
inicio
// Digitando os valores de I
escreval("Digite 3 numeros")
para i de 0 ate 2 passo 1 faca
     leia(numero[i])
     
fimpara
// ordenando valores
para i de 0 ate 2 faca
       para b de a+1 ate 2 faca
       se numero[a] > numero[b] entao
       t <- numero[a]
       numero[a] <- numero[b]
       numero[b] <- t
       
       fimse
       fimpara
fimpara
// exibindo ordenação
escreval("Essa é a ordem crescente do numero digitado")
para i de 0 ate 2 faca
escreval(numero[i])

fimpara
fimalgoritmo
