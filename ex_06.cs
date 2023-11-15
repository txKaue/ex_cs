//Você deve fazer um programa que leia um valor qualquer e apresente uma mensagem dizendo em qual dos seguintes intervalos ([0,25], (25,50], (50,75], (75,100]) este valor se encontra. Obviamente se o valor não estiver em nenhum destes intervalos, deverá ser impressa a mensagem “Fora de intervalo”

using System;

namespace exercicios{
    class ex_06{
        static void Main(){
            Console.WriteLine("Digite um número: ");
            int num = int.Parse(Console.ReadLine());
            if(num>=0&&num<25){
                Console.WriteLine("Entre 0 e 25");
            }else if(num>=25&&num<50){
                Console.WriteLine("Entre 25 e 50");
            }else if(num>=50&&num<75){
                Console.WriteLine("Entre 50 e 75");
            }else if(num>=75&&num<100){
                Console.WriteLine("Entre 75 e 100");
            }else{
                Console.WriteLine("Número fora do intervalo");
            }
            Console.ReadKey();
        }
    }
}