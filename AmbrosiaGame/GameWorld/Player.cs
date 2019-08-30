using AmbrosiaGame.Resources;
using AmbrosiaMechanics;

namespace AmbrosiaGame.GameWorld
{
    sealed class Player:  Creature
    {
        public Player(int x, int y, PlayerInfo info)
            : base(x, y, info.Texture)
        {
            Body = new PlayerBody();
        }
    }
}
