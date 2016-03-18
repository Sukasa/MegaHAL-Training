using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MarkovBot;

namespace MarkovBot_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Markov Bot = new Markov();
            //*
            Bot.LoadAuxiliaries("Auxiliaries.txt");
            Bot.LoadBanList("Bans.txt");
            Bot.LoadSwapList("Swaps.txt");
            Bot.Train("Training.txt");
            Bot.SaveBrain("BRAIN");
            /*/
            Bot.LoadBrain("BRAIN");
            //*/
            while (true) {
                Console.Write("> ");
                String Text = null;
                while (Text == null)
                    Text = Console.ReadLine();

                Console.WriteLine(Bot.GenerateReply(Text));
            }

        }
    }
}
