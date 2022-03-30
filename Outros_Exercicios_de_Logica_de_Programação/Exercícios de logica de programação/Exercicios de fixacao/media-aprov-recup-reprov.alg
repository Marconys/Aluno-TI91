algoritmo "Aprovado-recuperação-reprovado"
// Função : Calcular a média de um aluno
// Autor : Marconys
// Data : 28/01/2022
// Seção de Declarações 
var
nota1, nota2, nota3, media: real
inicio
// Inserindo o valor das notas
escreval("Digite o valor das três notas do aluno")
leia(nota1)
leia(nota2)
leia(nota3)
// calculando a média e exibindo o resultado final
           media <- (nota1 + nota2 + nota3) / 3
           se(media >= 7) entao
                escreval("Média",media,", aluno aprovado")
                senao
                se(media < 7) e (media > 5) entao
                     escreval("Média",media,", aluno em recuperação")
                     senao
                     se(media < 5) entao
                          escreval("Média",media,", aluno reprovado")
                     fimse
                fimse
           fimse
           
fimalgoritmo
