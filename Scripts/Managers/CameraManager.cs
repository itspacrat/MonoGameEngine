﻿using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using System.Linq;
using Microsoft.Xna.Framework.Graphics;

namespace MonoGame_Core.Scripts
{
    /// <summary>
    /// Static management class to handle the collection of cameras in the game and their rendering
    /// </summary>
    public static class CameraManager
    {
        static List<Camera> cameras;
        public static List<Camera> Cameras { get { return cameras; } }
        public static Camera MainCamera { get { return cameras[0]; } }
        public static void Initilize()
        {
            cameras = new List<Camera>();
            //MainCamera should always been the 0th element in the cameras list
            cameras.Add(new Camera("MainCamera", 0, 0, new Vector2(Globals.SCREEN_WIDTH, Globals.SCREEN_HEIGHT), new Vector2(Globals.SCREEN_WIDTH, Globals.SCREEN_HEIGHT) * -.5f, new Vector2(Globals.SCREEN_WIDTH, Globals.SCREEN_HEIGHT) * .5f, new Vector2(), new Vector2()));

        }

        public static void Add(Camera c)
        {
            cameras.Add(c);
        }

        /// <summary>
        /// Render all cameras to the screen, except the MainCamera, which defaults to the BackBuffer
        /// </summary>
        /// <param name="sb">The current spriteBatch</param>
        public static void Draw(SpriteBatch sb)
        {
            //Cameras are unique compaired to other game objects in that they don't require a spriteRenderer component
            //They manage thier own drawing
            for(int i = 0; i < cameras.Count; ++i)
            {
                if(cameras[i].Target != 0)
                    cameras[i].Draw(sb);
            }
        }

        /// <summary>
        /// Perform any behaviors that the cameras have attached
        /// </summary>
        /// <param name="dt">Game Time</param>
        public static void Update(float dt)
        {
            //Cameras are GameObjects and need to be updated like them
            foreach (Camera c in cameras)
            {
                c.Update(dt);
            }
        }
    }
}
