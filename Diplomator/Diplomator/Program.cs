using Diplomator;
using static System.Console;

Calculate calculate = new();
Message message = new();
message.PrintMessageInitial();

WriteLine("\nO seu diploma já foi entregue?\nDigite: 1[SIM] 2[NAO]");
string option = ReadLine()!;

while (option != "1" && option != "2")
{
    Write("\nDIGITE A OPÇÃO CORRETA!");
    WriteLine("\t\nO diploma foi entregue?\nDigite: 1[SIM] 2[NAO]");
    option = ReadLine()!;
}

switch (option)
{
    case "1":
        Clear();
        message.PrintAligator();
        WriteLine("\n\tEi Daniel, Parabénssss! Você está oficialmente diplomadoooo! =)");
        break;
    case "2":
        Clear();
        message.PrintAligator();
        calculate.PrintDays(Calculate.CalculateDays());
        break;
    default:
        break;
}