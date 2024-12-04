using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace DeckDestroyer;

public class Game1 : Game
{
    Texture2D dragonPurpleTexture;
    Texture2D dragonGreenTexture;

    Vector2 dragonPurpleTexturePosition;
    Vector2 dragonGreenTexturePosition;

    private GraphicsDeviceManager _graphics;
    private SpriteBatch _spriteBatch;

    public Game1()
    {
        _graphics = new GraphicsDeviceManager(this);
        Content.RootDirectory = "Content";
        IsMouseVisible = true;
    }

    protected override void Initialize()
    {
        // TODO: Add your initialization logic here
        dragonPurpleTexturePosition = new Vector2(_graphics.PreferredBackBufferWidth / 2,
                                                 _graphics.PreferredBackBufferHeight / 2);
        dragonGreenTexturePosition = new Vector2(_graphics.PreferredBackBufferWidth / 4,
                                                 _graphics.PreferredBackBufferHeight / 4);
        base.Initialize();
    }

    protected override void LoadContent()
    {
        _spriteBatch = new SpriteBatch(GraphicsDevice);

        // TODO: use this.Content to load your game content here
        dragonPurpleTexture = Content.Load<Texture2D>("fantasy_monster_128x128");
        dragonGreenTexture = Content.Load<Texture2D>("fantasy_monster_128x128_1");
    }

    protected override void Update(GameTime gameTime)
    {
        if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
            Exit();

        // TODO: Add your update logic here

        base.Update(gameTime);
    }

    protected override void Draw(GameTime gameTime)
    {
        GraphicsDevice.Clear(Color.CornflowerBlue);

        // TODO: Add your drawing code here
        _spriteBatch.Begin();
        _spriteBatch.Draw(dragonPurpleTexture, dragonPurpleTexturePosition, null, Color.White, 0f, new Vector2(dragonPurpleTexture.Width / 2, dragonPurpleTexture.Height / 2), Vector2.One, SpriteEffects.None, 0f);
        _spriteBatch.Draw(dragonGreenTexture, dragonGreenTexturePosition, null, Color.White, 0f, new Vector2(dragonGreenTexture.Width / 2, dragonGreenTexture.Height / 2), Vector2.One, SpriteEffects.None, 0f);
        _spriteBatch.End();

        base.Draw(gameTime);
    }
}
