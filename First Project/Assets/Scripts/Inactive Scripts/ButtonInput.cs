using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonInput : MonoBehaviour
{
    public GUITexture graphic;
    public Text textLabel;
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
        bool down = Input.GetButtonDown("Jump");
        bool held = Input.GetButton("Jump");
        bool up = Input.GetButtonUp("Jump");

        if (down)
        {
            graphic.texture = downgfx;
        }
        else if (held)
        {
            graphic.texture = heldgfx;
        }
        else
        {
            {
                graphic.texture = standard;
            }

            textLabel.text = " " + down + "\n " + held + "\n " + up;
        }
    }
}