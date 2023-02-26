using System;

namespace HelloWorldApp {

    class Geeks {

        static void Main(string[] args) {

            double metros = 0;
            double resultadocm = 0;
            double resultadomm = 0;

            Console.WriteLine("Converter medidas de metros para centimetros");

            Console.WriteLine("Insira uma medida em metros: ");
            metros = Convert.ToDouble(Console.ReadLine());

            resultadocm = (metros*100);
            Console.WriteLine("Sua medida em centimetros é: " + resultadocm.ToString());
            Console.ReadLine();

            resultadomm = (metros*1000);
            Console.WriteLine("Sua medida em milimetros é: " + resultadomm.ToString());
            Console.ReadLine();
        }
    }
}