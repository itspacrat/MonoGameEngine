using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;

namespace MonoGame_Core.Scripts.GameObjects.Base.UI
{
    class Slider : WorldObject
    {
        public Slider(string sliderTex, string name, Vector2 pos, float max, float min, byte layer, BehaviorHandler.Act onClick) : base(sliderTex, name, new string[] { "ui" }, pos, layer)
        {
            SpriteRenderer.IsHUD = true;
            CollisionBox collisionBox = (CollisionBox)AddComponent(new CollisionBox(this, "myBox", true, ResourceManager.GetTextureSize(sliderTex)));

            SliderData sliderData = (SliderData)ComponentHandler.Add
            (
                new SliderData(this, "sliderData", sliderTex, max, min)
            );
        }

        public double GetAngle(Vector2 startPos, Vector2 endPos)
        {
            return (double)Math.Atan2(endPos.Y - startPos.Y, endPos.X - startPos.X);
        }

    }

}
