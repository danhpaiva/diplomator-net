using static System.Console;

namespace Diplomator
{
    public class Message
    {
        public static void Crocodile() =>
            WriteLine(@"
                  ─────▄████▀█▄
                  ───▄█████████████████▄
                  ─▄█████.▼.▼.▼.▼.▼.▼▼▼▼
                  ▄███████▄.▲.▲▲▲▲▲▲▲▲
                  ████████████████████▀▀");

        public static void Sucess() =>
            WriteLine("\n\tDaniel, Parabénssss! Você está oficialmente diplomadoooo!");

        public static void Insucess(string days) =>
            WriteLine($"\n\tDaniel, Infelizmente a entrega do diploma está atrasada há: {days} DIAS.\n\tAté a próxima consulta!");

        public static void QuestionOne() =>
            WriteLine("\n\tDaniel, o seu diploma já foi entregue?\n\tDigite: 1[SIM] 2[NAO]");

        public static void ErrorOption() =>
            Write("\n\tDIGITE A OPÇÃO CORRETA!");

        public static void Final(string option)
        {
            if (option == "1") Message.Sucess();
            else
            {
                DateTime dateUniversity = new(2022, 03, 29);
                Message.Insucess(Calculate.CalculateDays(dateUniversity, DateTime.Now));
            }
        }
    }
}
