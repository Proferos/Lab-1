using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace GameAccount

{
    internal class Program
    {
        static void Main(string[] args)
        {
            GameAccount.Create("nagibator228");
            GameAccount.Create("ubivator337");

            Game.Play("nagibator228", "ubivator337", 30);
            Game.Play("nagibator228", "ubivator337", 30);
            Game.Play("nagibator228", "ubivator337", 30);
            Game.Play("nagibator228", "ubivator337", 30);
            Game.Play("nagibator228", "ubivator337", 1000);
            Game.Play("nagibator228", "ubivator337", 0);
            Game.Play("nagibator228", "ubivator337", -30);
            GameAccount.GetStats("nagibator228");
            GameAccount.GetStats("ubivator337");


        }
        
    }
    

}