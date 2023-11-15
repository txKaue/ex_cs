//Leia 2 valores com uma casa decimal (x e y), que devem representar as coordenadas de um ponto em um plano. A seguir, determine qual o quadrante ao qual pertence o ponto, ou se está sobre um dos eixos cartesianos ou na origem (x = y = 0). Se o ponto estiver na origem, escreva a mensagem “Origem”. Se o ponto estiver sobre um dos eixos escreva “Eixo X” ou “Eixo Y”, conforme for a situação

using System;

namespace exercicios{
    class ex_07{
        static void Main(){
            
            float x,y;
            Console.WriteLine("Digite o eixo x:");
            x = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o eixo y:");
            y = float.Parse(Console.ReadLine());

            if (x>0&&y>0){
                Console.WriteLine("Primeiro quadrante\nX = "+x.ToString("F1")+" e Y = "+y.ToString("F1"));
            }else if(x>0&&y<0){
                Console.WriteLine("Segundo quadrante\nX = "+x.ToString("F1")+" e Y = "+y.ToString("F1"));
            }else if(x<0&&y<0){
                Console.WriteLine("Terceiro quadrante\nX = "+x.ToString("F1")+" e Y = "+y.ToString("F1"));
            }else if(x<0&&y>0){
                Console.WriteLine("Quarto quadrante\nX = "+x.ToString("F1")+" e Y = "+y.ToString("F1"));
            }else{
                Console.WriteLine("Origem,\nX = 0 e Y = 0");
            }

            Console.ReadKey();
        }
    }
}