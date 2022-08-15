using Diplomator;
using static System.Console;

Message.Crocodile();
Message.QuestionOne();
string option = ReadLine()!;

while (option != "1" && option != "2")
{
    Clear();
    Message.Crocodile();
    Message.ErrorOption();
    Message.QuestionOne();
    option = ReadLine()!;
}

Clear();
Message.Crocodile();

if (option == "1")
    Message.Sucess();
else
{
    Calculate calculate = new();
    Message.Insucess(calculate.CalculateDays());
}