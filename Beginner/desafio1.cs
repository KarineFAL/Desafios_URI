
/* Read 2 variables, named A and B and make the sum of these two variables, assigning its result to the variable X. Print X as shown below. Print endline after the result otherwise you will get “Presentation Error”.

Input
The input file will contain 2 integer numbers.

Output
Print the letter X (uppercase) with a blank space before and after the equal signal followed by the value of X, according to the following example.

Obs.: don't forget the endline after all.*/

/* Leia 2 variáveis, denominadas A e B e fazer a soma dessas duas variáveis, atribuindo o resultado à variável X . Imprima X conforme mostrado abaixo. Imprima a linha final após o resultado, caso contrário, você obterá “ Erro de apresentação ”.

Entrada
O arquivo de entrada conterá 2 números inteiros.

Resultado
Imprime a letra X (maiúscula) com um espaço em branco antes e depois do sinal de igual seguido do valor de X, conforme exemplo a seguir.

Obs .: afinal não se esqueça da linha final.*/


using System;

class Desafio1{

    static void Main(){
        int A,B;

        
        
        A = Convert.ToInt32(Console.ReadLine());

        
        
        B = Convert.ToInt32(Console.ReadLine());

       

        Console.WriteLine("X = {0}",A+B, "\n");
       

      
    }
}