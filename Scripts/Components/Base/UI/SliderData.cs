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
        /// holds slider base info (start and end points, the angle the slider moves, and texture info)
        /// </summary>
        /// <param name="go"></param>
        /// <param name="name"></param>
        /// <param name="selectedTex"></param>
        /// <param name="max"></param>
        /// <param name="min"></param>
        /// <param name="start"></param>
        public SliderData(GameObject go, string name, string selectedTex, float max, float min) : base(go, name)
        {
            SliderTexID = selectedTex;
            MaxVal = max;
            MinVal = min;
        }
    }
}
