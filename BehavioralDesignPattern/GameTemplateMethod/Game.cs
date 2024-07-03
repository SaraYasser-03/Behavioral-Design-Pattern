using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralDesignPattern.GameTemplateMethod
{
    public abstract class Game
    {
        public abstract void initialize();
        public abstract void startGame();
        public abstract void endGame();
        public void play()
        {
            initialize();
            startGame();
            endGame();
        }
    }
}
