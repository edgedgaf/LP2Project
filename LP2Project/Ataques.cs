using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace LP2Project
{
    class Ataques
    {   
        public string nome;
        public string tipoAtaque;
        public int codTipoAtaque;
        public int Usages;
        public double dano;

        public override string ToString()
        {
            return nome;
        }
    }
}