﻿using Diplomator;
using static System.Console;

Message.Crocodile();
Message.QuestionOne();
string option = ReadLine()!;
Reader.Validate(ref option);
Clear();
Message.Crocodile();

if (option == "1")
    Message.Sucess();
else
{
    Calculate calculate = new();
    Message.Insucess(calculate.CalculateDays());
}