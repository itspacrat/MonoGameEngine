using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;

namespace MonoGame_Core.Scripts.GameObjects.Base.UI
{
    class Slider : WorldObject
    {
        public Slider(string sliderTex, string name, Vector2 pos, byte layer, BehaviorHandler.Act onClick) : base(sliderTex, name, new string[] { "ui" }, pos, layer)
        {

        }

        public double GetAngle(Vector2 startPos, Vector2 endPos)
        {
            return (double)Math.Atan2(endPos.Y - startPos.Y, endPos.X - startPos.X);
        }
        
    }

}
