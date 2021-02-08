using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeyInput : MonoBehaviour
{
    public GUITexture graphic;
    public Text textLable;
    public Texture2D standard;
    public Texture2D downgfx;
    public Texture2D upgfx;
    public Texture2D heldgfx;

    void Start()
    {
        graphic.texture = standard;
    }

    void Update()
    {
        bool down = Input.GetKeyDown(KeyCode.Space);
        bool held = Input.GetKey(KeyCode.Space);
        bool up = Input.GetKeyUp(KeyCode.Space);

        if (down)
        {
            graphic.texture = downgfx;
        }
        else if (held)
        {
            graphic.texture = standard;
        }
        else
        {
            graphic.texture = standard;
        }

        textLable.text = " " + down + "\n " + held + "\n " + up;
    }
}
