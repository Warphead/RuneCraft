﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Credits : MonoBehaviour {

    public Main main;
    
    public Audio audio;

    private int CharacterPointer;        // points to character, 1. Warrior, 2 Ninja, 3. Wizard, 4. Tinkerer

    public Texture2D Warrior;
    public Texture2D Ninja;
    public Texture2D Wizard;
    public Texture2D Tinkerer;

    public Texture2D ButtonLeft;
    public Texture2D ButtonRight;
    public Texture2D ButtonDown;
    public Texture2D ButtonUp;
    public Texture2D ButtonExit;


    

    private Rect Fullscreen = new Rect(0, 0, 1920, Screen.height);
    private Rect LogoCenter = new Rect(Screen.width / 2, 20, 100, 100);
    
    private Rect PopUp = new Rect(Screen.width / 2 - 300, 300, 600, 600);
    

    
    public Texture2D Paper;
    

    private void Awake()
    {

    }

    // Use this for initialization
    void Start()
    {

        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnGUI()
    {
        Font DnDFont = (Font)Resources.Load("Fonts/DnDFont", typeof(Font));

        GUIStyle HugeText = new GUIStyle();

        HugeText.normal.textColor = Color.black;
        HugeText.fontSize = 86;
        HugeText.font = DnDFont;
        HugeText.alignment = TextAnchor.UpperLeft;

        GUIStyle LargeText = new GUIStyle();

        LargeText.normal.textColor = Color.black;
        LargeText.fontSize = 64;
        LargeText.font = DnDFont;
        LargeText.alignment = TextAnchor.UpperLeft;

        GUIStyle MediumText = new GUIStyle();

        MediumText.normal.textColor = Color.black;
        MediumText.fontSize = 48;
        MediumText.font = DnDFont;
        MediumText.alignment = TextAnchor.UpperLeft;

        if (main.ShowCredits == 1)
        {

            GUI.DrawTexture(Fullscreen, Paper);

            GUI.Label(new Rect(50, 100, 100, 100), "RuneCraft was created for JamCraft 2018. It's meant to be played by SNES USB-controllers, but works with keyboard too. We intend to publish the final version on Steam.", HugeText);

            GUI.Label(new Rect(50, 200, 100, 100), "Programmed by: Ville Sippola, Omar Ourahou and Leo", HugeText);
            GUI.Label(new Rect(50, 300, 100, 100), "Game design: Ville Sippola, Magnus Nordmyr, Kristian Maeenpaeae", HugeText);

            
            if (GUI.Button(new Rect(Screen.width / 2, Screen.height - 100, 50, 50), ButtonExit))
            {

                main.ShowCredits = 0;
                main.ShowMenu = 1;
            }

            if (GUI.Button(new Rect(50, Screen.height - 100, 50, 50), ButtonLeft))
            {
                CharacterPointer--;
            }
            if (GUI.Button(new Rect(Screen.width - 100, Screen.height - 100, 50, 50), ButtonRight))
            {
                CharacterPointer++;
            }





        }
    }
}