algoritmo "Reajustesalario"
// Função : Reajuste salarial
// Autor : Marconys
// Data : 21/01/2022
// Seção de Declarações 
var
 salario: real
inicio
escreva("Digite o salário R$: ")
leia(salario)
se(salario < 600) entao
escreval(" Salário reajustado em 30%: ", salario * 1.30)
senao
escreval("O funcionário não tem direiro ao reajuste")
fimse
fimalgoritmo
