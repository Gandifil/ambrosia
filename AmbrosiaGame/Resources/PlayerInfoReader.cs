using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmbrosiaGame.Resources
{
    struct PlayerInfoHelper
    {
        public string id;
        public string texture;
    }

    public class PlayerInfoReader : ContentTypeReader<PlayerInfo>
    {
        protected override PlayerInfo Read(ContentReader reader, PlayerInfo existingInstance)
        {
            if (existingInstance != null)
                return existingInstance;

            var helper = JsonConvert.DeserializeObject<PlayerInfoHelper>(reader.ReadString());

            var instance = new PlayerInfo()
            {
                Id = reader.AssetName,
                Texture = reader.ContentManager.Load<Texture2D>("images/" + helper.texture)
            };
            return instance;
        }
    }
}
