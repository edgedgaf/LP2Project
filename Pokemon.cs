namespace TrabalhoJoao;

public class Pokemon
{
    private int HP;
    private string nome;
    private string tipo;
    public Pokemon(int x)
    {
        switch (x)
        {
            case 1:
                HP = 100;
                nome = "Charmander";
                tipo = "Fogo";
                break;
            case 2: 
                HP = 100;
                nome = "Pikachu";
                tipo = "Elétrico";
                break;
            case 3: 
                HP = 100;
                nome = "Squirtle";
                tipo = "Água";
                break;
            case 4:
                HP = 100;
                nome = "Bulbasaur";
                tipo = "Planta";
                break;
        }


    }

    public override string ToString()
    {
        return nome + tipo + HP;
    }
}