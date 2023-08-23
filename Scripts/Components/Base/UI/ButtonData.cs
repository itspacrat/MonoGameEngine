using System;
using System.Collections.Generic;
using System.Text;

namespace MonoGame_Core.Scripts
{
    public class ButtonData : Component
    {
        public string DeselectedTexID;
        public string SelectedTexID;
        public bool Holding;

        public ButtonData(GameObject go, string name, string selectedTex, string deselectedTex) : base(go, name)
        {
            DeselectedTexID = deselectedTex;
            SelectedTexID = selectedTex;
            Holding = false;
        }
    }
}
