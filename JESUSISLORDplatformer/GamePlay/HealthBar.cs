//JESUS IS LORD AND THE LIGHT OF THE WORLD!
// JESUS IS THE KING OF KINGS AND THE LORD OF LORD!
// THIS IS THE CODE FOR CREATING BARS OF HEALTH AND FOR THE APPEARING CODE FOR THE PADDLE!
// THANK YOU JESUS CHRIST WHO IS GOD!
/*

using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace JESUSISLORDplatformer
{
    /// <summary>
    /// This is the main type for your game
    /// </summary>
    public class HealthBar : GameScreen
    {

        #region Fields
        SpriteBatch mBatch;
        Texture2D mHealthBar;
        int mCurrentHealth = 100;
        
        SpriteBatch spriteBatch;
        Texture2D JESUSISGOD;
        #endregion

        #region JESUS IS LORD constructors
        public HealthBar()
        {

        }
        #endregion

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        public void Initialize()
        {
            // TODO: Add your initialization logic here

            
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        public override void LoadContent(ContentManager Content)
        {
            // Create a new SpriteBatch, which can be used to draw textures.
              base.LoadContent(Content);
            JESUSISGOD = content.Load<Texture2D>("JESUSISGOD");
            // TODO: Load any ResourceManagementMode.Automatic content

            //Initialize the Sprite batch
            //mBatch = new SpriteBatch(this.graphics.GraphicsDevice);

            //Create the content manager to load the images
            //ContentManager aLoader = new ContentManager(this.Services);

            //Load the HealthBar image from the disk into the Texture2D object
            mHealthBar = content.Load<Texture2D>("HealthBar");


            // TODO: use this.Content to load your game content here
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// all content.
        /// </summary>
        public override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        public override void Update(GameTime gameTime)
        {
            // Allows the game to exit
            

            // TODO: Add your update logic here

            //Get the current keyboard state (which keys are currently pressed and released)
            KeyboardState mKeys = Keyboard.GetState();

            //If the Up Arrow is pressed, increase the Health bar
            if (mKeys.IsKeyDown(Keys.Up) == true)
            {
                mCurrentHealth += 1;
            }

            //If the Down Arrowis pressed, decrease the Health bar
            if (mKeys.IsKeyDown(Keys.Down) == true)
            {
                mCurrentHealth -= 1;
            }

            //Force the health to remain between 0 and 100
            mCurrentHealth = (int)MathHelper.Clamp(mCurrentHealth, 0, 100);


          //  base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        public override void Draw(SpriteBatch spriteBatch)
        {
            


            //TODO: Add your drawing code here
            spriteBatch.Begin();
            spriteBatch.Draw(JESUSISGOD, new Rectangle(100, GraphicsAdapter.DefaultAdapt / 2 - 100, JESUSISGOD.Width / 3, JESUSISGOD.Height / 3), Color.White);
            //Draw the negative space for the health bar
            spriteBatch.Draw(mHealthBar, new Rectangle(this.Window.ClientBounds.Width / 2 - mHealthBar.Width / 2,

                 30, mHealthBar.Width, 44), new Rectangle(0, 45, mHealthBar.Width, 44), Color.Gray);


            //Draw the current health level based on the current Health
            spriteBatch.Draw(mHealthBar, new Rectangle(this.Window.ClientBounds.Width / 2 - mHealthBar.Width / 2,
                 30, (int)(mHealthBar.Width * ((double)mCurrentHealth / 100)), 44),
                 new Rectangle(0, 45, mHealthBar.Width, 44), Color.Red);

            //Draw the box around the health bar
            spriteBatch.Draw(mHealthBar, new Rectangle(this.Window.ClientBounds.Width / 2 - mHealthBar.Width / 2,

                30, mHealthBar.Width, 44), new Rectangle(0, 0, mHealthBar.Width, 44), Color.White);
            spriteBatch.End();

            // TODO: Add your drawing code here

            //base.Draw(gameTime);
        }
    }
}
*/