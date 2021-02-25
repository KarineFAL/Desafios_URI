/* Read two integer values, in this case, the variables A and B. After this, calculate the sum between them and assign it to the variable SOMA. Write the value of this variable.

Input
The input file contains 2 integer numbers.

Output
Print the message "SOMA" with all the capital letters, with a blank space before and after the equal signal followed by the corresponding value to the sum of A and B. Like all the problems, don't forget to print the end of line, otherwise you will receive "Presentation Error"*/

/* Leia dois valores inteiros, neste caso, as variáveis ​​A e B. Em seguida, calcule a soma entre eles e atribua à variável SOMA . Escreva o valor desta variável.

Entrada
O arquivo de entrada contém 2 números inteiros.

Resultado
Imprima a mensagem "SOMA" com todas as letras maiúsculas, com um espaço em branco antes e depois do sinal de igual seguido do valor correspondente à soma de A e B. Como todos os problemas, não se esqueça de imprimir o final da linha , caso contrário, você receberá "Erro de apresentação"*/


using System ;

class Desafio3 {

    static void Main(){

        int A,B;

        
        A = Convert.ToInt32(Console.ReadLine());
        B = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("SOMA = {0}",A+B,"\n");
    }
}
