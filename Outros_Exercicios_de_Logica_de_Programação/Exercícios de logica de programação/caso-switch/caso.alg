algoritmo "caso"
// Função :  condicional
// Autor :   Marconys
// Data : 21/01/2022
// Seção de Declarações 
var
time: caractere
inicio
escreval("Entre com um nome de um time de futebol!")
leia(time)
escolha time
caso "Palmeiras", "São Paulo", "Corinthians"
escreval(time, " É um Time Paulista")
caso "Flamengo", "Fluminense", "vasco", "Botafogo"
escreval(time, " É um Time Carioca")
caso "Gremio", "Internacional", "Caxias"
escreval(time, " É um Time Gaúcho")
outrocaso
escreval(time, " É de outro estado.")
fimescolha
fimalgoritmo
