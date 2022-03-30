algoritmo "busca no array"
// Função : Somar array
// Autor : Marconys
// Data : 26/01/2022
// Seção de Declarações 
var
array: vetor[0..9] de inteiro
valor, i : inteiro

Inicio
// Array preenchido
array[0] <- 10
array[1] <- 5
array[2] <- 3
array[3] <- 50
array[4] <- 20
array[5] <- 30
array[6] <- 60
array[7] <- 80
array[8] <- 70
array[9] <- 90
// entrar com valor a pesquisar
escreval("Digite o valor a pesquisar no vetor")
leia(valor)
i <- 0

// pesquisar no array e imprimir o resultado
enquanto (i < 10) e (array[i] <> valor) faca
i <- i + 1
fimenquanto
se (array[i] = valor) entao
escreval("O Numero ",valor, " Encontrado na posição",i+1,"º do vetor")
senao
escreval("O Numero", valor," não foi encontrado no vetor")
fimse
fimalgoritmo
