using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoJoaoLP2.packAttacks
{
    internal class Ember : Ataques
    {
        public Ember()
        {
            this.tipoAtaque = "Fogo";
            this.Usages = 10;
            this.dano = 30;
        }

        public override void ataqueAction()
        {
               
        }
    }
}
