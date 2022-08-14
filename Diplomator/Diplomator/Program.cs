using Diplomator;
using static System.Console;

WriteLine("Diplomator");

WriteLine("\nO diploma foi entregue?\nDigite: 1[SIM] 2[NAO]");
int option = int.Parse(ReadLine()!);

switch (option)
{
    case 1:
        WriteLine("\nParabéns, Daniel você está graduado!");
        break;
    case 2:
        Calculate calculate = new Calculate();
        calculate.PrintDays(Calculate.CalculateDays());
        break;
    default:
        Write("\nDigite a opção correta!");
        break;
}