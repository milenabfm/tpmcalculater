using System;

namespace Teste
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Giovana's red days");
            Console.WriteLine("Início");
            var dia = Console.ReadLine();
            Console.WriteLine("mês");
            var mes = Console.ReadLine();
            
            Console.WriteLine("Final");
            var diafim = Console.ReadLine();
            Console.WriteLine("mês");
            var mesfinal = Console.ReadLine();


            var dianumero = int.Parse(dia);
            var mesnumero=int.Parse(mes);

            var datainicio = new DateTime(2021, mesnumero, dianumero);
            
            var diafinal = int.Parse(diafim);
            var mesfinall = int.Parse(mesfinal);
            
            var datafinal = new DateTime(2021, mesfinall, diafinal);

            var duracao = datafinal - datainicio;
            
            Console.WriteLine(duracao.Days);

            var proxima = datafinal.AddDays(28);
            
            Console.WriteLine(proxima.ToString("dd/MM/yyyy"));
            





        }
    }
}