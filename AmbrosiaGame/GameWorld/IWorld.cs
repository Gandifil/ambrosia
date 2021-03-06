﻿using MonoGame.Extended.Tiled;
using System.Collections.Generic;

namespace AmbrosiaGame.GameWorld
{
    interface IWorld
    {
        IEnumerable<GameObject> GetGameObjects();

        TiledMap GetTiledMap();

        bool IsFreeCell(int x, int y);

        GameObject GetGameObjectOnCell(int x, int y);

        Player GetPlayer();
    }
}
