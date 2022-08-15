using Diplomator;
using static System.Console;

Message.Crocodile();
Message.QuestionOne();
string option = ReadLine()!;
Reader.Validate(ref option);
Clear();
Message.Crocodile();

if (option == "1") Message.Sucess();
else
{
    DateTime dateUniversity = new(2022,03,29);
    Message.Insucess(Calculate.CalculateDays(dateUniversity, DateTime.Now));
}