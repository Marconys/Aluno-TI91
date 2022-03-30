algoritmo "Cilindo"
// Função : Calcular a área total e volume de um cilindro
// Autor : Marconys
// Data : 28/01/2022
// Seção de Declarações 
var
alt, raio, al, ab, at, vol: real
inicio
// inserindo altura e raio
escreval("Digite o valor da altura em cm")
leia(alt)
escreval("Digite o valor do raio em cm")
leia(raio)
// calculando a area lateral do cilindo
   al <-  2 * 3.14 * raio * alt
// calculando a area da base do cilindo
   ab <- 3.14 * raio * raio
// calculando a area total do cilindo
   at <- 2 * ab + al
// calculando o volume do cilindo
   vol <- ab * alt
   escreval("A área total do cilindro é: ",at,".PI cm²")
   escreval("")
   escreval("O volume do cilindro é: ",vol,".PI cm²")
fimalgoritmo
