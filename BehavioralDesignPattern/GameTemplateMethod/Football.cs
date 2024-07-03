using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralDesignPattern.GameTemplateMethod
{
    public class Football:Game
    {
        public override void endGame()
        {
            Console.WriteLine("Football Game Ended");
        }

        public override void initialize()
        {
            Console.WriteLine("Football initialized");
        }

        public override void startGame()
        {
            Console.WriteLine("Football Game Started");
        }
    }
}
