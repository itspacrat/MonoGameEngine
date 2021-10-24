﻿using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace MonoGame_Core.Scripts
{
    public class Button : WorldObject
    {
        public Button(string deselectedTex, string selectedTex, string name, Vector2 pos, byte layer, BehaviorHandler.Act onClick) : base(deselectedTex, name, new string[] { "button" }, pos, layer)
        {
            SpriteRenderer.IsHUD = true;
            CollisionBox cb = (CollisionBox)AddComponent(new CollisionBox(this, "myBox", true, ResourceManager.GetTextureSize(deselectedTex)));
            ButtonData b = (ButtonData)componentHandler.Add(new ButtonData(this, "buttonData", selectedTex, deselectedTex));
            behaviorHandler.Add("Hover", Behaviors.ButtonSwapImagesOnHover, new Component[] { Transform, b });
            if(onClick != null)
                behaviorHandler.Add("OnClick", onClick);
        }
    }
}
