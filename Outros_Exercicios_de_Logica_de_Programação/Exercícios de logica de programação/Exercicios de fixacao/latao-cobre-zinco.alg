algoritmo "Latão"
// Função : Calcular a diferenca de cobre e zinco
// Autor :  Marconys
// Data : 31/01/2022
// Seção de Declarações 
var
cob, zin, latc, latz, dzin, dcob: real
inicio
// inicializando valiaveis
cob <- 70
zin <- 30
Escreval("Digite o valor que você tem de cobre")
leia(latc)
Escreval("Digite o valor que você tem de zinco")
leia(latz)
  // calculando a diferença entre os componente
  
  dcob <- cob - latc
  dzin <- zin - latz
  se( cob = latc) e (zin = latz) entao
       escreval("Parabens! Você possui todos os componentes")
       senao
       escreval("")
       escreva("Você precisa de mais ",dcob, "% de cobre e ")
       escreval(dzin,"% de zinco")
  fimse
fimalgoritmo
