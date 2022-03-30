algoritmo "Vetor contagem"
// Função : Contar numeros positivios
// Autor :  Marconys
// Data : 26/01/2022
// Seção de Declarações 
var
numero: vetor[0..14] de inteiro
i, contPositivo: inteiro
inicio
// Seção de Comandos
contPositivo <- 0
para i de 0 ate 14 passo 1 faca
       leia(numero[i])
       se(numero[i] >= 0) entao
            contPositivo <- contPositivo + 1
       fimse
fimpara

escreva("O vetor possui ",contPositivo," numeros positivos")
fimalgoritmo
