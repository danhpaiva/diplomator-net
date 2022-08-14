using Diplomator;
using static System.Console;

WriteLine(@"

██████╗░██╗██████╗░██╗░░░░░░█████╗░███╗░░░███╗░█████╗░████████╗░█████╗░██████╗░
██╔══██╗██║██╔══██╗██║░░░░░██╔══██╗████╗░████║██╔══██╗╚══██╔══╝██╔══██╗██╔══██╗
██║░░██║██║██████╔╝██║░░░░░██║░░██║██╔████╔██║███████║░░░██║░░░██║░░██║██████╔╝
██║░░██║██║██╔═══╝░██║░░░░░██║░░██║██║╚██╔╝██║██╔══██║░░░██║░░░██║░░██║██╔══██╗
██████╔╝██║██║░░░░░███████╗╚█████╔╝██║░╚═╝░██║██║░░██║░░░██║░░░╚█████╔╝██║░░██║
╚═════╝░╚═╝╚═╝░░░░░╚══════╝░╚════╝░╚═╝░░░░░╚═╝╚═╝░░╚═╝░░░╚═╝░░░░╚════╝░╚═╝░░╚═╝
");
WriteLine("\nO seu diploma já foi entregue?\nDigite: 1[SIM] 2[NAO]");
string option = ReadLine()!;

while (option != "1" && option != "2")
{
    Clear();
    Write("\nDIGITE A OPÇÃO CORRETA!");
    WriteLine("\t\nO diploma foi entregue?\nDigite: 1[SIM] 2[NAO]");
    option = ReadLine()!;
}

switch (option)
{
    case "1":
        Clear();
        WriteLine(@"
                    ──────▄▀─
                    ─█▀▀▀█▀█─
                    ──▀▄░▄▀──
                    ────█────
                    ──▄▄█▄▄──
                 ");
        WriteLine("\n\tEi Daniel, Parabénssss! Você está oficialmente diplomadoooo! =)");
        break;
    case "2":
        Calculate calculate = new();
        calculate.PrintDays(Calculate.CalculateDays());
        break;
    default:
        break;
}