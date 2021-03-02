using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CauculadoraDeVolumee
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {

            
               
                double raio, altura, volume, AreaBaseDoCilindro, pi;
                pi = 3.1415;
                
                  Console.Write("Por favor informe a medida do raio da basedo cilindro: ");
                 raio = double.Parse(Console.ReadLine());
               
                Console.Write("Por favor informe a medida da altura docilindro: ");
                altura = double.Parse(Console.ReadLine());
                // Realiza o cálculo do Área da base do Cilindro
                AreaBaseDoCilindro = (pi * raio * raio);
                // Realiza o cálculo do Volume do Cilindro
                volume = (AreaBaseDoCilindro * altura);
                // Exibe o resultado do Volume do Cilindro
                Console.WriteLine("O volume do cilindro é: {0}", volume);
             // Fim do método Main
         // Fim da classe Cilindro
    



            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
