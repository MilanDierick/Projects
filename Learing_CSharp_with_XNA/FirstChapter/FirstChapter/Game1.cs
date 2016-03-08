using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
class Game1 : Game
{
    GraphicsDeviceManager graphics;
    SpriteBatch spriteBatch; Color background;

    public Game1()
    {
        Content.RootDirectory = "Content"; graphics = new GraphicsDeviceManager(this);
    }
    protected override void LoadContent()
    {
        spriteBatch = new SpriteBatch(GraphicsDevice);
    }
    protected override void Update(GameTime gameTime)
    {
        int red = gameTime.TotalGameTime.Milliseconds; background = new Color(red, 0, 0);
    }
    protected override void Draw(GameTime gameTime)
    {
        GraphicsDevice.Clear(background);
    }
}
