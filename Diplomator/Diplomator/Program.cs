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
int option = int.Parse(ReadLine()!);

while (option != 1 && option != 2)
{
    Clear();
    Write("\tDIGITE A OPÇÃO CORRETA! ");
    WriteLine("\nO diploma foi entregue?\nDigite: 1[SIM] 2[NAO]");
    option = int.Parse(ReadLine()!);
}

switch (option)
{
    case 1:
        Clear();
        WriteLine("\nParabéns Daniel, você está graduado!");
        break;
    case 2:
        Calculate calculate = new();
        calculate.PrintDays(Calculate.CalculateDays());
        break;
    default:
        break;
}