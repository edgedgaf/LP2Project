namespace LP2Project;

class Batalhas
{
    public static int escolherPokemon()
    {
        ConsoleKeyInfo option;
        int seletor = 1;
        int counter = 0;
        bool isSelected = false;
        string setinha = "->";
        (int X, int Y) = Console.GetCursorPosition();

        while (!isSelected)
        {
            Console.SetCursorPosition(X, Y);

            Console.WriteLine($"{(seletor == 1 ? setinha : "  ")}1. Charmander");
            Console.WriteLine($"{(seletor == 2 ? setinha : "  ")}2. Pikachu");
            Console.WriteLine($"{(seletor == 3 ? setinha : "  ")}3. Squirtle");
            Console.WriteLine($"{(seletor == 4 ? setinha : "  ")}4. Bulbasaur");
            option = Console.ReadKey();

            switch (option.Key)
            {
                case ConsoleKey.DownArrow:
                    seletor = (seletor == 4 ? 1 : seletor + 1);
                    break;

                case ConsoleKey.UpArrow:
                    seletor = (seletor == 1 ? 4 : seletor - 1);
                    break;

                case ConsoleKey.Enter:
                    isSelected = true;
                    break;
            }
        }
        return seletor;
    }
    
    public static int battleActions()
    {
        ConsoleKeyInfo option;
        int seletor = 1;
        int counter = 0;
        bool isSelected = false;
        string setinha = "->";
        (int X, int Y) = Console.GetCursorPosition();

        while (!isSelected)
        {
            Console.SetCursorPosition(X, Y);

            Console.WriteLine($"{(seletor == 1 ? setinha : "  ")}1. Lutar");
            Console.WriteLine($"{(seletor == 2 ? setinha : "  ")}2. Mochila");
            Console.WriteLine($"{(seletor == 3 ? setinha : "  ")}3. Fugir");
            option = Console.ReadKey();

            switch (option.Key)
            {
                case ConsoleKey.DownArrow:
                    seletor = (seletor == 3 ? 1 : seletor + 1);
                    break;

                case ConsoleKey.UpArrow:
                    seletor = (seletor == 1 ? 3 : seletor - 1);
                    break;

                case ConsoleKey.Enter:
                    isSelected = true;
                    break;
            }
        }
        return seletor;
    }
public static int chooseAttack(Pokemon pokemon)
{
    ConsoleKeyInfo option;
        int seletor = 0;
        int counter = 0;
        bool isSelected = false;
        string setinha = "->";
        (int X, int Y) = Console.GetCursorPosition();

        while (!isSelected)
        {
            Console.SetCursorPosition(X, Y);

            Console.WriteLine($"{(seletor == 0 ? setinha : "  ")}1. {pokemon.attack[0]}");
            Console.WriteLine($"{(seletor == 1 ? setinha : "  ")}2. {pokemon.attack[1]}");
            Console.WriteLine($"{(seletor == 2 ? setinha : "  ")}3. {pokemon.attack[2]}");
            Console.WriteLine($"{(seletor == 3 ? setinha : "  ")}4. {pokemon.attack[3]}");
            option = Console.ReadKey();

            switch (option.Key)
            {
                case ConsoleKey.DownArrow:
                    seletor = (seletor == 3 ? 0 : seletor + 1);
                    break;

                case ConsoleKey.UpArrow:
                    seletor = (seletor == 0 ? 3 : seletor - 1);
                    break;

                case ConsoleKey.Enter:
                    isSelected = true;
                    break;
            }
        }
        return seletor;
}
public static double resolveAttack(Ataques ataque, Pokemon pokemon)
{
    return ataque.dano * Multiplicador.danoMultiplicador[ataque.codTipoAtaque, pokemon.codTipoPokemon];
}
public static void start(Pokemon a, Pokemon b)
    {
        Console.Clear();
        int windowSizeY = Console.WindowWidth;
        int windowSizeX = Console.WindowHeight;
        Console.SetCursorPosition(windowSizeY/2 - 8 , windowSizeX/2 - 4);
        Console.WriteLine("Batalha começando...");
        Thread.Sleep(1500);
        Console.Clear();
        int counter = 0;
        int action;
        int idAttack = 1;
        double dano;
        while(true)
        {
            
            Console.WriteLine($"HP do Player 1: {(a.HP < 0 ? 0 : a.HP)}");
            Console.WriteLine($"HP do Player 2: {(b.HP < 0 ? 0 : b.HP)}");

            if (a.HP <= 0)
            {
                Console.WriteLine("O player 1 foi derrotado(a)");
                break;
            }
            else if (b.HP <= 0)
            {
                Console.WriteLine("O player 2 foi derrotado(a)");
                break;
            }
                
            if (counter == 0 || counter %2 == 0)
            {
                Console.Clear();
                Console.WriteLine("Vez do Player 1! ");
                Console.WriteLine("Escolha sua ação: ");
                action = Batalhas.battleActions();
                if(action == 1)
                {
                    Console.Clear();
                    idAttack = Batalhas.chooseAttack(a);
                }
                if(a.attack[idAttack].isOffensive)
                {
                    dano = resolveAttack(b.attack[idAttack], a);
                    b.HP = b.HP - dano;
                    Console.WriteLine($"O jogador a causou {dano} de dano \nvida do jogador B {b.HP}/{b.hpMAX}");
                    Console.ReadKey();
                }
                counter++;
            }
            else if (counter % 2 != 0)
            {
                Console.Clear();
                Console.WriteLine("Vez do Player 2!");
                Console.WriteLine("Escolha sua ação: ");
                action = Batalhas.battleActions();
               
                if(action == 1)
                {
                    Console.Clear();
                    idAttack = Batalhas.chooseAttack(b);  
                }
                if(b.attack[idAttack].isOffensive)
                {
                    dano = resolveAttack(b.attack[idAttack], a);
                    a.HP = a.HP - dano;
                    Console.WriteLine($"O jogador b causou {dano} de dano \nvida do jogador A {a.HP}/{a.hpMAX}");
                    Console.ReadKey();
                }
                counter++;
            }


        }
    }

}