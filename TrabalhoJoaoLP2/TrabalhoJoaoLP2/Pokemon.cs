namespace TrabalhoJoaoLP2;

public class Pokemon
{
    private int lvl = 8;
    private int HP;
    private string nome;
    public int codTipoAtaque;
    private string tipo;
    public string[] ataques = new string[4];
    public bool isEfective;
    public Pokemon(int x)
    {
        switch (x)
        {
            case 1:
                HP = 100;
                nome = "Charmander";
                tipo = "Fogo";
                for (int i = 0; i < 4; i++) ataques[i] = $"Ataque {i + 1}";
                break;
            case 2:
                HP = 100;
                nome = "Pikachu";
                tipo = "Elétrico";
                for (int i = 0; i < 4; i++) ataques[i] = $"Ataque {i + 1}";
                break;
            case 3:
                HP = 100;
                nome = "Squirtle";
                tipo = "Água";
                for (int i = 0; i < 4; i++) ataques[i] = $"Ataque {i + 1}";
                break;
            case 4:
                HP = 100;
                nome = "Bulbasaur";
                tipo = "Planta";
                for (int i = 0; i < 4; i++) ataques[i] = $"Ataque {i + 1}";
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