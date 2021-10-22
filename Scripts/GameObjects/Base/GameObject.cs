﻿using Microsoft.Xna.Framework;

namespace MonoGame_Core.Scripts
{
    public class GameObject
    {
        protected ComponentHandler componentHandler;
        protected BehaviorHandler behaviorHandler;
        protected string name;
        protected string[] tags;
        protected bool destroy = false;

        public string Name { get { return name; } }
        public bool ToDestroy { get { return destroy; } }
        public string[] Tags { get { return tags; } }
        public ComponentHandler ComponentHandler { get { return componentHandler; } }
        public BehaviorHandler BehaviorHandler { get { return behaviorHandler; } }

        public GameObject(string name, string[] tags)
        {
            this.tags = tags;
            behaviorHandler = new BehaviorHandler(this);
            componentHandler = new ComponentHandler(this);
        }

        public virtual void Initilize()
        {
            componentHandler.Initilize();
            behaviorHandler.Inizilize();
        }

        public virtual void Update(float dt)
        {
            if (destroy)
            {
                OnDestroy();
            }
            else
            {
                behaviorHandler.Update(dt);
            }
        }

        public virtual void OnCreate()
        {

        }

        public void Destroy()
        {
            destroy = true;
        }

        public virtual void OnDestroy()
        {
            behaviorHandler.OnDestroy();
            componentHandler.OnDestroy();
        }
    }
}
