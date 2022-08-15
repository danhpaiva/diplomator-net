using Diplomator;
using static System.Console;

Message.Crocodile();
Message.QuestionOne();
string option = ReadLine()!;

Reader.Validate(ref option);

Clear();
Message.Crocodile();

Message.Final(option);