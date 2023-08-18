using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;

namespace MonoGame_Core.Scripts
{
    public class SliderData : Component
    {

        /// <summary>
        /// 
        /// </summary>
        public string SliderTexID;
        
        /// <summary>
        ///  maximum value of a slider
        /// </summary>
        public float MaxVal;
        
        /// <summary>
        ///  minimum value of a slider
        /// </summary>
        public float MinVal;
        
        /// <summary>
        /// the initial (bottom/left-most) point on a slider
        /// </summary>
        public Vector2 Start;
        
        /// <summary>
        /// the final (top/right-most) point on a slider
        /// </summary>
        public Vector2 End;

        /// <summary>
        /// holds slider base info (start and end points, the angle the slider moves, and texture info)
        /// </summary>
        /// <param name="go"></param>
        /// <param name="name"></param>
        /// <param name="selectedTex"></param>
        /// <param name="max"></param>
        /// <param name="min"></param>
        /// <param name="start"></param>
        public SliderData(GameObject go, string name, string selectedTex, float max, float min, Vector2 start, Vector2 end) : base(go, name)
        {
            SliderTexID = selectedTex;
            MaxVal = max;
            MinVal = min;
            Start = start;
            End = end;
        }
    }
}
