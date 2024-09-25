namespace TrabalhoJoao;

public class Pokemon
{
    private int HP;
    private int lvl;
    private string nome;
    private string tipo;
    private List<string> ataques = new List<string>; 
    public Pokemon(int x)
    {
        switch (x)
        {
            case 1:
                HP = 100;
                nome = "Charmander";
                tipo = "Fogo";
                ataques.AddRange("Ataque 1", "Ataque 2", "Ataque 3", "Ataque 4");
                break;
            case 2: 
                HP = 100;
                nome = "Pikachu";
                tipo = "Elétrico";
                ataques.AddRange("Ataque 1", "Ataque 2", "Ataque 3", "Ataque 4");
                break;
            case 3: 
                HP = 100;
                nome = "Squirtle";
                tipo = "Água";
                ataques.AddRange("Ataque 1", "Ataque 2", "Ataque 3", "Ataque 4");
                break;
            case 4:
                HP = 100;
                nome = "Bulbasaur";
                tipo = "Planta";
                ataques.AddRange("Ataque 1", "Ataque 2", "Ataque 3", "Ataque 4");
                break;
        }


    }

    public override string ToString()
    {
        return nome + tipo + HP;
    }
}