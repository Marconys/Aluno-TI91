algoritmo "Preço do carro"
// Função : Calcular o valor final de um carro
// Autor :  Marconys
// Data : 31/01/2022
// Seção de Declarações 
var
precoCarFabr,imposto,lucro, precoFinal:real
inicio
// declarando valor imposto e lucro
imposto <- 0.45
lucro <- 0.12

// desclaro variavel precoFabr pelo teclado
escreval("Digite o custo de fabrica do carro")
leia(precoCarFabr)

// calculando o valor do imposto e o lucro do vendedor

imposto <- precoCarFabr * 0.45
lucro <- precoCarFabr * 0.12

// calculando o precço final

precoFinal <- precoCarFabr + imposto + lucro

// exbindo o valor final

escreval("O valor final do carro é:",precoFinal)
escreval(" dos quais",imposto,"são de imposto e ",lucro, " O lucro do fabricanre")

fimalgoritmo
