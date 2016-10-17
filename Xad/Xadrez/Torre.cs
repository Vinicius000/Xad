using System;
using tabuleiro;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xadrez
{
    class Torre : Peca
    {
        public Torre(Tabuleiro tab, Cor cor) : base(tab, cor)
        {
        }

        public override string ToString()
        {
            return "T";
        }
    }
}
