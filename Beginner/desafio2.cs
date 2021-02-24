/*The formula to calculate the area of a circumference is defined as A = π . R2. Considering to this problem that π = 3.14159:

Calculate the area using the formula given in the problem description.

Input
The input contains a value of floating point (double precision), that is the variable R.

Output
Present the message "A=" followed by the value of the variable, as in the example bellow, with four places after the decimal point. Use all double precision variables. Like all the problems, don't forget to print the end of line after the result, otherwise you will receive "Presentation Error".*/


/* fórmula para calcular a área de uma circunferência é definida como A = π. R 2 . Considerando este problema que π = 3,14159 :

Calcule a área usando a fórmula fornecida na descrição do problema.

Entrada
A entrada contém um valor de ponto flutuante (precisão dupla), que é a variável R .

Resultado
Apresente a mensagem "A =" seguida do valor da variável, como no exemplo abaixo, com quatro casas decimais após a vírgula. Use todas as variáveis ​​de precisão dupla. Como todos os problemas, não se esqueça de imprimir o final da linha após o resultado, caso contrário, receberá "Erro de apresentação".*/


using System;

class Desafio2{

    static void Main(){

    double A,R;

    Console.WriteLine("Digite o valor:");
    R = Convert.ToDouble(Console.ReadLine());

    double n = 3.14159;

    

    A = n *  Math.Pow(R,2) ;

    

    Console.WriteLine("A={0:f4}",A,"\n");

    }
}
