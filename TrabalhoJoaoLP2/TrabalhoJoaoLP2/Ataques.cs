using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoJoaoLP2
{
    internal abstract class Ataques
    {
        public string tipoAtaque;
        public int codTipoAtaque;
        public int Usages;
        public int dano;
        public bool isEffective;
        public abstract void ataqueAction();
    }
}
