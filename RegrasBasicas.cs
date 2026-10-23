using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEscolar
{
    namespace SistemaEscolar
    {
        public class RegrasBasicas
        {
            private int contador = 1;

            public int ProximaPosicao()
            {
                int posicaoAtual = contador;
                contador++;
                return posicaoAtual;
            }

            public string Espacamento()
            {
                return "-----------------";
            }

            public void ReiniciarContador()
            {
                contador = 1;
            }
        }
    }
}
