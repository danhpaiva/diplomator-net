﻿using static System.Console;

namespace Diplomator
{
    internal class Message
    {
        public void PrintMessageInitial()
        {
            WriteLine(@"
                        ██████╗░██╗██████╗░██╗░░░░░░█████╗░███╗░░░███╗░█████╗░████████╗░█████╗░██████╗░
                        ██╔══██╗██║██╔══██╗██║░░░░░██╔══██╗████╗░████║██╔══██╗╚══██╔══╝██╔══██╗██╔══██╗
                        ██║░░██║██║██████╔╝██║░░░░░██║░░██║██╔████╔██║███████║░░░██║░░░██║░░██║██████╔╝
                        ██║░░██║██║██╔═══╝░██║░░░░░██║░░██║██║╚██╔╝██║██╔══██║░░░██║░░░██║░░██║██╔══██╗
                        ██████╔╝██║██║░░░░░███████╗╚█████╔╝██║░╚═╝░██║██║░░██║░░░██║░░░╚█████╔╝██║░░██║
                        ╚═════╝░╚═╝╚═╝░░░░░╚══════╝░╚════╝░╚═╝░░░░░╚═╝╚═╝░░╚═╝░░░╚═╝░░░░╚════╝░╚═╝░░╚═╝");
        }

        public void PrintAligator()
        {
            WriteLine(@"
                  ─────▄████▀█▄
                  ───▄█████████████████▄
                  ─▄█████.▼.▼.▼.▼.▼.▼▼▼▼
                  ▄███████▄.▲.▲▲▲▲▲▲▲▲
                  ████████████████████▀▀");
        }
    }
}