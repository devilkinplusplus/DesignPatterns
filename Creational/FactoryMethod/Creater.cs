using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class Creater
    {
        public Game FactoryMethod(GamePlatforms platform)
        {
            Game game = null;
            switch(platform)
            {
                case GamePlatforms.Atari:
                    game = new Atari();
                    break;
                case GamePlatforms.PS:
                    game = new PS();
                    break;
                 case GamePlatforms.PC:
                    game = new PC();
                    break;
            }
            return game;
        }
    }
}
