using System.Diagnostics;
using Microsoft.VisualBasic;
using TrabalhoJoao;

Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("Bem vindo(a) ao Nome Genérico");
Console.ResetColor();
Console.WriteLine("O que deseja fazer?");

ConsoleKeyInfo option;
int seletor = 1;
int counter = 0;
bool isSelected = false;
string setinha = "->";
(int X, int Y) = Console.GetCursorPosition();

while (!isSelected)
{
    Console.SetCursorPosition(X, Y);
    
    Console.WriteLine($"{(seletor == 1 ? setinha : "  ")}1. Batalhar");
    Console.WriteLine($"{(seletor == 2 ? setinha : "  ")}2. Abrir mochila");

    option = Console.ReadKey();

    switch(option.Key)
    {
        case ConsoleKey.DownArrow:
            seletor = (seletor == 2 ? 1 : seletor + 1);
            break;
        
        case ConsoleKey.UpArrow:
            seletor = (seletor == 1 ? 2 : seletor - 1);
            break;
        
        case ConsoleKey.Enter:
            isSelected = true;
            break;
    }

}

int p1 = 0;
int p2 = 0;
Pokemon player1;
Pokemon player2;

switch (seletor)
{
    case 1:
        Console.Clear();
        Console.WriteLine("Escolha o pokemon do P1: ");
        p1 = Batalhas.escolherPokemon();
        player1 = new Pokemon(p1);
        Console.WriteLine("Escolha o pokemon do P2: ");
        p2 = Batalhas.escolherPokemon();
        player2 = new Pokemon(p2);
        Console.WriteLine(player1);
        Console.WriteLine(player2);
        break;
        
}





