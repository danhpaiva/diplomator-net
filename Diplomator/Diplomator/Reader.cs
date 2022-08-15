using static System.Console;

namespace Diplomator
{
    public class Reader
    {
        public static string Validate(ref string option)
        {
            while (option != "1" && option != "2")
            {
                Clear();
                Message.Crocodile();
                Message.ErrorOption();
                Message.QuestionOne();
                option = ReadLine()!;
            }
            return option;
        }
    }
}
