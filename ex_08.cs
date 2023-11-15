//Em um país imaginário denominado Lisarb, todos os habitantes ficam felizes em pagar seus impostos, pois sabem que nele não existem políticos corruptos e os recursos arrecadados são utilizados em benefício da população, sem qualquer desvio. A moeda deste país é o Rombus, cujo símbolo é o R$.
//Leia um valor com duas casas decimais, equivalente ao salário de uma pessoa de Lisarb. Em seguida, calcule e mostre o valor que esta pessoa deve pagar de Imposto de Renda, segundo a tabela abaixo.

using System;
namespace exercicios{
    class ex_08{
        static void Main(){
            Console.WriteLine("Digite o seu salário: ");
            double salario = double.Parse(Console.ReadLine());
            double imposto;
            if (salario<=2000){
                Console.WriteLine("Isento de impostos");
            }else if(salario>2000&&salario<=3000){
                imposto = salario * 1.08;
                Console.WriteLine("8% de imposto.\nValor a pagar: R$"+imposto.ToString("F2"));
            }else if(salario>3000&&salario<=4500){
                imposto = salario * 1.18;
                Console.WriteLine("18% de imposto.\nValor a pagar: R$"+imposto.ToString("F2"));
            }else{
                imposto = salario * 1.28;
                Console.WriteLine("28% de imposto.\nValor a pagar: R$"+imposto.ToString("F2"));
            }
            
            Console.ReadKey();
        }
    }
}