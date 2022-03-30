algoritmo "Tipos de Triangulo"
// Função :  lendo valores e determinando o tipo de triangulo
// Autor :   marconys
// Data : 31/01/2022
// Seção de Declarações 
var
a, b, c: real
inicio
// Digitando os valores de A B e C
escreval("Digite o valor de A")
leia(a)
escreval("Digite o valor de B")
leia(b)
escreval("Digite o valor de C")
leia(c)
        // determinado os tipos de triangulo
        se(a = b) e (a = c) entao
        escreval("A, B e C foram um triângulo Equilatero!")
        senao
        se(a = b) e (a <> c) ou (a = c) e (a <> b) ou (b = c) e ( b<>a) entao
        escreval("A, B e C foram um triângulo Isócele!")
        senao
        se(a <> b) e (a <> c) entao
        escreval("A, B e C foram um triângulo Escaleno!")
           fimse
        fimse
     fimse
fimalgoritmo
