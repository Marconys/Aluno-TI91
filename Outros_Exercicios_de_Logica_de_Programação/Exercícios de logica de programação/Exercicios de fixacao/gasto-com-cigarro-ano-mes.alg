algoritmo "Cigarro"
// Função : Calcular o gasto com cigarros
// Autor :  Marconys
// Data : 28/01/2022
// Seção de Declarações 
var
tempoFumante, cigarroPorDia, maco: real
precoMaco: real
res: caracter
inicio
// Declarando valores

escreval("Você fuma a mais de um ano?")
leia(res)
se(res = "sim") entao
escreval("A quantos anos você fuma?")
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
          senao
          se (res = "não") entao
           escreval("A quantos meses você fuma?")
leia(tempoFumante)
   tempoFumante <- tempoFumante * 30

escreval("Você fuma quantos cigarros por dia?")
leia(cigarroPorDia)
   cigarroPorDia <- (cigarroPorDia *  tempoFumante)

escreval("Qual o valor do maço de cigarro?")
escreva("R$: ")
leia(precoMaco)
   // calculando quantidade de maço por mês
       maco <- (cigarroPorDia / 20)
       escreval("")
     escreva("Em ",tempoFumante / 30," meses você fumou ")
     escreva(maco," macos de cigarros ")
     escreval("e gastou R$",maco * precoMaco," reais")
          fimse
     fimse

fimalgoritmo
