using AmbrosiaGame.GameWorld;
using AmbrosiaGame.Resources;
using AmbrosiaGame.Screens;
using AmbrosiaGame.Utils;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using MonoGame.Extended;
using MonoGame.Extended.Screens;
using MonoGame.Extended.Screens.Transitions;
using MonoGame.Extended.Tiled;
using MonoGame.Extended.Tiled.Renderers;
using MonoGame.Extended.ViewportAdapters;

namespace AmbrosiaGame
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        ScreenManager screenManager;

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            screenManager = Components.Add<ScreenManager>();
        }

        protected override void Initialize()
        {
            base.Initialize();

            graphics.PreferredBackBufferWidth = GraphicsDevice.DisplayMode.Width;
            graphics.PreferredBackBufferHeight = GraphicsDevice.DisplayMode.Height;
            graphics.ApplyChanges();

            Content.RootDirectory = "Content";

            Mouse.SetCursor(MouseCursor.FromTexture2D(Content.Load<Texture2D>("images/cursor"), 0, 0));
            IsMouseVisible = true;

            InfoManager.Initialize(Content);
            GameLog.Initialize(Content);
        }

        protected override void LoadContent()
        {
            base.LoadContent();

            screenManager.LoadScreen(new GameProcessScreen(this), new FadeTransition(GraphicsDevice, Color.Black, 0.5f));
        }
    }
}
