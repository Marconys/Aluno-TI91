algoritmo "Ano Bissexto"
// Função : Calcular ano bissexto
// Autor :  marconys
// Data : 31/01/2022
// Seção de Declarações 
var
sbi, nbi, ano: inteiro
inicio
// Digitando o o ano pelo teclado

escreval("Digite um ano com 4 digitos")
leia(ano)
se(ano mod 400 = 0) ou (ano mod 4 = 0) e (ano mod 100 <> 0) entao
 escreval(ano," é um ano bissexto")
 senao
 escreval(ano," não é um ano bissexto")
 
 fimse
fimalgoritmo
