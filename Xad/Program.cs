using System;
using tabuleiro;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xad
{
    class Program
    {
        static void Main(string[] args)
        {
            Posicao P;

            P = new Posicao(3, 4);

            Console.WriteLine("Posicao: " + P);

            Console.ReadLine();
        }
    }
}
