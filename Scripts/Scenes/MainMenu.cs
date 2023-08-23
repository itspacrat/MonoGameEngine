using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Media;
using MonoGame_Core.Scripts.GameObjects.Base.UI;

namespace MonoGame_Core.Scripts
{
    public class MainMenu : Scene
    {
        protected override void loadContent()
        {
            ResourceManager.AddSong("Melody", "Music/TestSong");
            SoundManager.PlaySong("Melody");

            ResourceManager.AddTexture("PlayBtn", "Images/Default UI/btn_play");
            ResourceManager.AddTexture("SelPlayBtn", "Images/Default UI/btn_play_sel");
            ResourceManager.AddTexture("ExitBtn", "Images/Default UI/btn_exit");
            ResourceManager.AddTexture("SelExitBtn", "Images/Default UI/btn_exit_sel");
            ResourceManager.AddTexture("SettingsBtn", "Images/Default UI/btn_settings");
            ResourceManager.AddTexture("SelSettingsBtn", "Images/Default UI/btn_settings_sel");
            // load switch test textures
            ResourceManager.AddTexture("SwitchBaseDeselected", "Images/Default UI/switch_base");
            ResourceManager.AddTexture("SwitchBaseSelected", "Images/Default UI/switch_base_sel");
            ResourceManager.AddTexture("SwitchOn", "Images/Default UI/switch_on");
            ResourceManager.AddTexture("SwitchOff", "Images/Default UI/switch_off");
            // load the slider test textures
            ResourceManager.AddTexture("SliderBase", "Images/Default UI/slider");
            ResourceManager.AddTexture("SliderBitDeselected", "Images/Default UI/slider_bit");
            ResourceManager.AddTexture("SliderBitSelected", "Images/Default UI/slider_bit_sel");

        }

        protected override void loadObjects()
        {

            gameObjects = new List<GameObject>();

            InitGameObject(new Button("PlayBtn", "SelPlayBtn", "PlayButton", new Vector2(500, 100), 1, Behaviors.LoadSceneOnClick));
            InitGameObject(new Button("ExitBtn", "SelExitBtn", "QuitButton", new Vector2(500, -20), 1, Behaviors.QuitOnClick));
            InitGameObject(new Button("SettingsBtn", "SelSettingsBtn", "SettingsButton", new Vector2(500, 40), 1, null));
            
            // hybrid dead hover button + switch combo
            InitGameObject(new Button("SwitchBaseDeselected", "SwitchBaseSelected","ComplexSwitchBase", new Vector2(500, 160), 1, Behaviors.OnClickTemplate)); // for implementation purposes; you can also pass null here
            InitGameObject(new Switch("SwitchOn", "SwitchOff","ComplexSwitch", new Vector2(500, 160), 1, Behaviors.SwitchOnClick)); // TODO make this relative to switch base
            
            InitGameObject(new Button("SwitchBaseDeselected", "SwitchBaseSelected","DraggableThing", new Vector2(500, 220), 1, Behaviors.OnClickTemplate));
            WorldObject draggy = (WorldObject)GetObjectByName("DraggableThing");
            draggy.AddBehavior("DraggableThing",Behaviors.DragDrop,new Component[] {draggy.GetComponent("transform"),draggy.GetComponent("myBox")});

            InitGameObject(new Slider("SliderBase","testslider",new Vector2(-200,100),0,100,1,null));
            Slider sld = (Slider)GetObjectByName("testslider") ;
            InitGameObject(new Button("SliderBitDeselected","SliderBitSelected","testsliderbit",new Vector2(-200,50),1,null));
            Button sldbit = (Button)GetObjectByName("testsliderbit");

            sldbit.AddBehavior("Drag",Behaviors.DragDrop,new Component[] {});
            //sldbit.AddBehavior("Slider",Behaviors.RestrictToSlider,new Component[] {sld.GetComponent("sliderData"),sld.GetComponent("transform"),sld.GetComponent("myBox")});
            ((Transform)sldbit.GetComponent("transform")).Attach((Transform)sld.GetComponent("transform"));
            
        }
    }
}
