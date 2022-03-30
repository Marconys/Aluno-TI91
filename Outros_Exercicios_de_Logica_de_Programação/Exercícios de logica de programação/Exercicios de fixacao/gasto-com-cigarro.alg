algoritmo "Cigarro"
// Função : Calcular o gasto com cigarros
// Autor :  Marconys
// Data : 28/01/2022
// Seção de Declarações 
var
tempoFumante, cigarroPorDia, maco: real
precoMaco: real
inicio
// Declarando valores
escreval("A quanto tempo você fuma?")
leia(tempoFumante)
   tempoFumante <- tempoFumante * 365
   
escreval("Você fuma quantos cigarros por dia?")
leia(cigarroPorDia)
   cigarroPorDia <- (cigarroPorDia *  tempoFumante)
   
escreval("Qual o valor do maço de cigarro?")
escreva("R$: ")
leia(precoMaco)
   // calculando quantidade de maço por ano
       maco <- (cigarroPorDia / 20)
       escreval("")
     escreva("Em ",tempoFumante / 365," anos você fumou ")
     escreva(maco," macos de cigarros ")
     escreval("e gastou R$",maco * precoMaco," reais")
fimalgoritmo
