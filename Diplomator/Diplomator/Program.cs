using Diplomator;
using static System.Console;

Message.PrintAligator();
Message.QuestionOne();
string option = ReadLine()!;

while (option != "1" && option != "2")
{
    Clear();
    Message.PrintAligator();
    Message.ErrorOption();
    Message.QuestionOne();
    option = ReadLine()!;
}

switch (option)
{
    case "1":
        Clear();
        Message.PrintAligator();
        Message.Sucess();
        break;
    case "2":
        Clear();
        Message.PrintAligator();
        Message.Insucess(Calculate.CalculateDays());
        break;
    default:
        break;
}