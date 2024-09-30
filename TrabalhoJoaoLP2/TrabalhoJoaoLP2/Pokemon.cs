using System.Drawing;

namespace TrabalhoJoaoLP2;

 class Pokemon
{
    private int lvl = 8;
    private int HP;
    private string nome;
    public int codTipoAtaque;
    private string tipo;
    public  ConsoleColor cor;
    public Ataques[] attack = new Ataques[4];
    public bool isEfective;
    public Pokemon(int x)
    {
        switch (x)
        {
            case 1:
                HP = 100;
                nome = "Charmander";
                tipo = "Fogo";
                cor = ConsoleColor.Red;
                
                break;
            case 2:
                HP = 100;
                nome = "Pikachu";
                tipo = "Elétrico";
                cor = ConsoleColor.Yellow;
                
                break;
            case 3:
                HP = 100;
                nome = "Squirtle";
                tipo = "Água";
                cor = ConsoleColor.Blue;
                
                break;
            case 4:
                HP = 100;
                nome = "Bulbasaur";
                tipo = "Planta";
                cor = ConsoleColor.Green;
                
                break;
            default:
                return;

        }


    }

    public string printAtaques()
    {
        string resultado = "";
        for (int i = 0; i < 4; i++)
        {
            resultado += ataques[i] + "\n";
        }
        return resultado;
    }
    public int hpPlayer()
    {
        return HP;
    }


    public override string ToString()
    {
        
        return lvl + nome + tipo + HP;
        

    }
}