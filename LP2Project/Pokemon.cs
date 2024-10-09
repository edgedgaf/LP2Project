using System.Drawing;

namespace LP2Project;

 class Pokemon
{
    private int lvl = 8;
    public double HP;
    private string nome;
    public int codTipoPokemon;
    private string tipo;
    public  ConsoleColor cor;
    public Ataques[] attack = new Ataques[4];
    public Pokemon(int x)
    {
        switch (x)
        {
            case 1: 
                HP = 100;
                nome = "Charmander";
                tipo = "Fogo";
                cor = ConsoleColor.Red;
                codTipoPokemon = 0;

                
                attack[0] = new Ataques
                {
                    nome = "Scratch",  
                    codTipoAtaque = 1,      
                    Usages = 35,
                    dano = 40
                };

                attack[1] = new Ataques
                {
                    nome = "Ember",    
                    codTipoAtaque = 0,       
                    Usages = 25,
                    dano = 40
                };

                attack[2] = new Ataques
                {
                    nome = "Growl",    
                    codTipoAtaque = 1,      
                    Usages = 40,
                    dano = 0                 
                };

                attack[3] = new Ataques
                {
                    nome = "Flamethrower",  
                    codTipoAtaque = 0,           
                    Usages = 15,
                    dano = 90
                };
                break;

            case 2:  
                HP = 100;
                nome = "Pikachu";
                tipo = "Elétrico";
                cor = ConsoleColor.Yellow;
                codTipoPokemon = 4;

              
                attack[0] = new Ataques
                {
                    nome = "Quick Attack",  
                    codTipoAtaque = 1,            
                    Usages = 30,
                    dano = 40
                };

                attack[1] = new Ataques
                {
                    nome = "Thunder Shock", 
                    codTipoAtaque = 4,            
                    Usages = 30,
                    dano = 40
                };

                attack[2] = new Ataques
                {
                    nome = "Thunder Wave",  
                    codTipoAtaque = 4,            
                    Usages = 20,
                    dano = 0                     
                };

                attack[3] = new Ataques
                {
                    nome = "Thunderbolt",   
                    codTipoAtaque = 4,            
                    Usages = 15,
                    dano = 90
                };
                break;

            case 3:  
                HP = 100;
                nome = "Squirtle";
                tipo = "Água";
                cor = ConsoleColor.Blue;
                codTipoPokemon = 1;

                
                attack[0] = new Ataques
                {
                    nome = "Tackle",        
                    codTipoAtaque = 1,            
                    Usages = 35,
                    dano = 40
                };

                attack[1] = new Ataques
                {
                    nome = "Water Gun",     
                    codTipoAtaque = 1,            
                    Usages = 25,
                    dano = 40
                };

                attack[2] = new Ataques
                {
                    nome = "Tail Whip",     
                    codTipoAtaque = 1,           
                    Usages = 30,
                    dano = 0                    
                };

                attack[3] = new Ataques
                {
                    nome = "Hydro Pump",   
                    codTipoAtaque = 1,           
                    Usages = 5,
                    dano = 110
                };
                break;

            case 4:  
                HP = 100;
                nome = "Bulbasaur";
                tipo = "Planta";
                cor = ConsoleColor.Green;
                codTipoPokemon = 3;

                
                attack[0] = new Ataques
                {
                    nome = "Tackle",        
                    codTipoAtaque = 1,            
                    Usages = 35,
                    dano = 40
                };

                attack[1] = new Ataques
                {
                    nome = "Vine Whip",  
                    codTipoAtaque = 3,          
                    Usages = 25,
                    dano = 45
                };

                attack[2] = new Ataques
                {
                    nome = "Growl",         
                    codTipoAtaque = 1,         
                    Usages = 40,
                    dano = 0                     
                };

                attack[3] = new Ataques
                {
                    nome = "Razor Leaf",   
                    codTipoAtaque = 3,           
                    Usages = 25,
                    dano = 55
                };
                break;

            default:
                return;
        }
    }


  

    public override string ToString()
    {
        
        return lvl + nome + tipo + HP;
        

    }
}