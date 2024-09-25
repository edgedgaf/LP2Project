namespace TrabalhoJoao;

public class Batalhas
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

            switch(option.Key)
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


    
}