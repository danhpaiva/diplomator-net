using static System.Console;

namespace Diplomator
{
    public class Message
    {
        public static void PrintAligator()
        {
            WriteLine(@"
                  ─────▄████▀█▄
                  ───▄█████████████████▄
                  ─▄█████.▼.▼.▼.▼.▼.▼▼▼▼
                  ▄███████▄.▲.▲▲▲▲▲▲▲▲
                  ████████████████████▀▀");
        }

        public static void Sucess()
        {
            WriteLine("\n\tEi Daniel, Parabénssss! Você está oficialmente diplomadoooo!");
        }

        public static void Insucess(string days)
        {
            WriteLine($"\nEi Daniel,\nInfelizmente a entrega do diploma está atrasada há: {days} DIAS.\nAté a próxima consulta!");
        }

        public static void QuestionOne()
        {
            WriteLine("\nO seu diploma já foi entregue?\nDigite: 1[SIM] 2[NAO]");
        }

        public static void ErrorOption()
        {
            Write("\nDIGITE A OPÇÃO CORRETA!");
        }
    }
}
