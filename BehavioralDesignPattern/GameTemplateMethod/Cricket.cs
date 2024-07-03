using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralDesignPattern.GameTemplateMethod
{
    public class Cricket:Game
    {
        public override void endGame()
        {
            Console.WriteLine("Cricket Game Ended");
        }

        public override void initialize()
        {
            Console.WriteLine("Cricket initialized");
        }

        public override void startGame()
        {
            Console.WriteLine("Cricket Game Started");
        }
    }
}
