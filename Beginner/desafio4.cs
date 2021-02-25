/*Read two integer values. After this, calculate the product between them and store the result in a variable named PROD. Print the result like the example below. Do not forget to print the end of line after the result, otherwise you will receive “Presentation Error”.

Input
The input file contains 2 integer numbers.

Output
Print the message "PROD" and PROD according to the following example, with a blank space before and after the equal signal.

Leia dois valores inteiros. Depois disso, calcule o produto entre eles e armazene o resultado em uma variável chamada PROD . Imprima o resultado como no exemplo abaixo. Não se esqueça de imprimir o final da linha após o resultado, caso contrário, você receberá “Erro de apresentação” .

Entrada
O arquivo de entrada contém 2 números inteiros.

Resultado
Imprima a mensagem "PROD" e PROD de acordo com o exemplo a seguir, com um espaço em branco antes e depois do sinal de igual.*/

using System ;

class Desafio4{

    static void Main(){

        int v1,v2,PROD;

        Console.WriteLine("Digite um valor : ");
        v1 = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("Diigite um outro valor : ");
        v2 = Convert.ToInt32(Console.ReadLine());

        PROD = v1 * v2 ;

        Console.WriteLine("PROD = {0}",PROD, "\n");



    }
}