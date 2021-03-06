﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using LibraryEngine.Components;


namespace LibraryEngine.Systems
{
    public class SpriteRenderer : ISystem
    {
        private SpriteBatch spriteBatch;
        public SpriteRenderer(SpriteBatch spriteBatch)
        {
            this.spriteBatch = spriteBatch;
        }


        public void Update(Scene scene, GameTime gameTime)
        {
            var spriteEntities = scene.Entities
                .Where(e => e.HasComponent<Sprite>())
                .Where(e => e.HasComponent<Transform>());

            Rectangle sourceRect;

            foreach(var entity in spriteEntities)
            {
                var sprite = entity.GetComponent<Sprite>();
                var transform = entity.GetComponent<Transform>();
                
                spriteBatch.Draw(sprite.Texture, new Rectangle((int)transform.Position.X, (int)transform.Position.Y, sprite.Texture.Width, sprite.Texture.Height), sprite.sourceRect, Color.White, (float)transform.Rotation.Z, new Vector2(sprite.Texture.Width/2, sprite.Texture.Height / 2), SpriteEffects.None, 1);
                // spriteBatch.Draw(sprite.Texture, new Rectangle((int)transform.Position.X, (int)transform.Position.Y, sprite.Texture.Width, sprite.Texture.Height), Color.White);

            }


        }
    }
}
