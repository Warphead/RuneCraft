using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;
using System.Collections.Generic;

public class City : MonoBehaviour
{

    private int CharacterPointer;        // points to character, 1. Warrior, 2 Ninja, 3. Wizard, 4. Tinkerer

    public Texture2D Banner;
    public Texture2D CityBackground;
    public Texture2D SelectionRed;
    public Texture2D SelectionBlue;
    public Texture2D SelectionBoth;

    private int SelectionBluePointer = 1;
    private int SelectionRedPointer = 1;

    public Texture2D ButtonUp;

    public Main main;
    public Audio audio;

    private Rect Fullscreen = new Rect(0, 0, Screen.width, Screen.height);
    private Rect LogoCenter = new Rect(Screen.width / 2 - 400, 20, 800, 100);
    private Rect AttributesAlignment = new Rect(40, 180, 100, 40);
    private Rect PopUp = new Rect(Screen.width / 2 - 300, 300, 600, 600);
    private Rect ToolTipRect = new Rect(100, 100, 100, 100);

    private Color gold = new Color(0.255F, 0.215F, 0.0F);

    public string[] Texts;
    
    private Rect RedRect = new Rect(50, 50, 500, 400);
    private Rect BlueRect = new Rect(Screen.width - 550, 50, 500, 400);

    private Rect RedTextRect = new Rect(70, 70, 500, 400);
    private Rect BlueTextRect = new Rect(Screen.width - 530, 70, 500, 400);


    private Rect BlacksmthRect = new Rect(50, 650, 200, 200);
    private Rect MinesthRect = new Rect(300, 500, 200, 200);
    private Rect TowerhRect = new Rect(650, 450, 200, 200);
    private Rect GatehRect = new Rect(850, 450, 200, 200);
    private Rect ShophRect = new Rect(1750, 600, 200, 200);
    private Rect TavernhRect = new Rect(1600, 550, 200, 200);
    private Rect HallRect = new Rect(1450, 500, 200, 200);


    public int i;
    private float DelayTime = 0.9F;
    private float TimeStamp;

    public Texture2D Paper;
    private int CityPointer = 0;


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
        if (Input.GetKey(KeyCode.LeftArrow) && Time.time > TimeStamp)
        {
            SelectionRedPointer--;
            TimeStamp = Time.time + DelayTime;
            if (SelectionRedPointer == 0)
            {
                SelectionRedPointer = 7;
            }
        }
        if (Input.GetKey(KeyCode.RightArrow) && Time.time > TimeStamp)
        {
            SelectionRedPointer++;
            TimeStamp = Time.time + DelayTime;
            if (SelectionRedPointer == 8)
            {
                SelectionRedPointer = 1;
            }
        }
    }
    

    private void OnGUI()
    {
        Font DnDFont = (Font)Resources.Load("Fonts/DnDFont", typeof(Font));

        GUIStyle HeaderText = new GUIStyle();

        HeaderText.normal.textColor = Color.black;
        HeaderText.fontSize = 128;
        HeaderText.font = DnDFont;

        HeaderText.alignment = TextAnchor.MiddleCenter;

        GUIStyle HugeText = new GUIStyle();

        HugeText.normal.textColor = Color.black;
        HugeText.fontSize = 86;
        HugeText.font = DnDFont;
        HugeText.alignment = TextAnchor.UpperLeft;

        GUIStyle LargeText = new GUIStyle();



        LargeText.normal.textColor = Color.yellow;
        LargeText.fontSize = 70;
        LargeText.font = DnDFont;
        LargeText.alignment = TextAnchor.MiddleCenter;

        GUIStyle MediumText = new GUIStyle();

        MediumText.normal.textColor = Color.black;
        MediumText.fontSize = 48;
        MediumText.font = DnDFont;
        MediumText.alignment = TextAnchor.UpperLeft;

        GUIStyle SmallText = new GUIStyle();

        SmallText.normal.textColor = Color.black;
        SmallText.fontSize = 32;
        SmallText.font = DnDFont;
        SmallText.alignment = TextAnchor.UpperLeft;

        //GUI.backgroundColor = new Color(0, 0, 0, 0);




        //if (main.ShowCity == 1)
        //{

        GUI.DrawTexture(Fullscreen, CityBackground);
            GUI.DrawTexture(LogoCenter, Banner);
            GUI.Label(LogoCenter, "You are at RuneCity", LargeText);

            

            

            GUI.Button(BlacksmthRect, new GUIContent("", "Visit blacksmith"));
            if (GUI.Button(BlacksmthRect, "Blacksmith")) ;

            if (SelectionBluePointer == 1)
        {
            GUI.DrawTexture(BlacksmthRect, SelectionBlue);
        }

        if (SelectionRedPointer == 1)
        {
            GUI.DrawTexture(BlacksmthRect, SelectionRed);
        }

        if (SelectionBluePointer == 1 && SelectionRedPointer == 1)
        {
            GUI.DrawTexture(BlacksmthRect, SelectionBoth);
        }


        GUI.Button(MinesthRect, new GUIContent("", "Go to mines"));
        if (GUI.Button(MinesthRect, "Mines")) ;

        if (SelectionBluePointer == 2)
        {
            GUI.DrawTexture(MinesthRect, SelectionBlue);
        }

        if (SelectionRedPointer == 2)
        {
            GUI.DrawTexture(MinesthRect, SelectionRed);
        }

        if (SelectionBluePointer == 2 && SelectionRedPointer == 2)
        {
            GUI.DrawTexture(MinesthRect, SelectionBoth);
        }

        GUI.Button(TowerhRect, new GUIContent("", "Visit tower"));
        if (GUI.Button(TowerhRect, "Tower")) ;

        if (SelectionBluePointer == 3)
        {
            GUI.DrawTexture(TowerhRect, SelectionBlue);
        }

        if (SelectionRedPointer == 3)
        {
            GUI.DrawTexture(TowerhRect, SelectionRed);
        }

        if (SelectionBluePointer == 3 && SelectionRedPointer == 3)
        {
            GUI.DrawTexture(TowerhRect, SelectionBoth);
        }

        GUI.Button(GatehRect, new GUIContent("", "Leave city"));
        if (GUI.Button(GatehRect, "Leave")) ;

        if (SelectionBluePointer == 4)
        {
            GUI.DrawTexture(GatehRect, SelectionBlue);
        }

        if (SelectionRedPointer == 4)
        {
            GUI.DrawTexture(GatehRect, SelectionRed);
        }

        if (SelectionBluePointer == 4 && SelectionRedPointer == 4)
        {
            GUI.DrawTexture(GatehRect, SelectionBoth);
        }

        GUI.Button(HallRect, new GUIContent("", "Hall of Champions"));
        if (GUI.Button(HallRect, "Hall of Heroes"))
        {
            main.ShowCity = 0;

            main.ShowCharacterSheet = 1;

        }

        if (SelectionBluePointer == 5)
        {
            GUI.DrawTexture(HallRect, SelectionBlue);
        }

        if (SelectionRedPointer == 5)
        {
            GUI.DrawTexture(HallRect, SelectionRed);
        }

        if (SelectionBluePointer == 5 && SelectionRedPointer == 5)
        {
            GUI.DrawTexture(HallRect, SelectionBoth);
        }

        
        GUI.Button(TavernhRect, new GUIContent("", "Visit the Laughing Goblin tavern"));
            if (GUI.Button(TavernhRect, "Tavern")) ;

        if (SelectionBluePointer == 6)
        {
            GUI.DrawTexture(TavernhRect, SelectionBlue);
        }

        if (SelectionRedPointer == 6)
        {
            GUI.DrawTexture(TavernhRect, SelectionRed);
        }

        if (SelectionBluePointer == 6 && SelectionRedPointer == 6)
        {
            GUI.DrawTexture(TavernhRect, SelectionBoth);
        }

        GUI.Button(ShophRect, new GUIContent("", "Visit store"));
            if (GUI.Button(ShophRect, "Store")) ;

        if (SelectionBluePointer == 7)
        {
            GUI.DrawTexture(ShophRect, SelectionBlue);
        }

        if (SelectionRedPointer == 7)
        {
            GUI.DrawTexture(ShophRect, SelectionRed);
        }

        if (SelectionBluePointer == 7 && SelectionRedPointer == 7)
        {
            GUI.DrawTexture(ShophRect, SelectionBoth);
        }



        GUI.DrawTexture(RedRect, Paper);
        GUI.Label(RedTextRect, Texts[SelectionRedPointer], MediumText);
        GUI.DrawTexture(BlueRect, Paper);
        GUI.Label(BlueTextRect, "This works only to red player so\n far, use arrow keys to navigate.", MediumText);




        GUI.Label(new Rect(Screen.width / 2, Screen.height - 40, 200, 40), GUI.tooltip);

            // Buttons

            //GUI.Button(new Rect(Screen.width - 200, Screen.height - 200, 200, 200), new GUIContent("", "Visit Hall of Heroes"));
            
        //GUI.Label(AttributesAlignment, "<b>Attributes</b>", HeaderText);
        //GUI.Label(AttributesAlignment, "<b>Attributes</b>\nAgility\nCharisma\nMana\nIntelligence\nSpeed\nStamina\nStrength\nToughness", LargeText);



        //}

    }
}