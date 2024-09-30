namespace TrabalhoJoaoLP2;

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
    /*public static int ataque(Pokemon a, Pokemon b)
    {
       0 if(a.codTipo 1)





        return dano;
}*/
 

public static bool isEffective()
 {

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
        Random random = new Random();
        int numeroAleatorio = random.Next(1, 101);
        bool isCrit = numeroAleatorio < 30;
        Console.WriteLine(numeroAleatorio);
        Console.WriteLine(isCrit);
        int counter = 0;

        while(true)
        {
            if (a.hpPlayer() == 0)
                break;
            else if (b.hpPlayer() == 0)
                break;
            if (counter == 0 || counter %2 == 0)
            {
                Console.Clear();
                Console.WriteLine("Vez do Player 1! ");
                Console.WriteLine("Escolha sua ação: ");
                Batalhas.battleActions();
                counter++;
            }
            else if (counter % 2 != 0)
            {
                Console.Clear();
                Console.WriteLine("Vez do Player 2!");
                Console.WriteLine("Escolha sua ação: ");
                Batalhas.battleActions();
                counter++;
            }


        }
    }

}