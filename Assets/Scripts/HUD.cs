using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HUD : MonoBehaviour
{

    // References to other scripts.

    public CharacterSheet characterSheet;

    // Boolean variables

    // Integer and float variables.

    private int PlayerOneHealth = 100;
    private int PlayerTwoHealth = 100;
    private int PlayerOneStamina = 100;
    private int PlayerTwoStamina = 100;
    private int PlayerOneMana = 100;
    private int PlayerTwoMana = 100;

    // Vectors.

    public Vector2 pos = new Vector2(20, 40);
    public Vector2 size = new Vector2(200, 100);

    // Textures.

    public Texture2D progressBarEmpty;
    public Texture2D progressBarFull;

    

    void OnGUI()
    {
        Font DnDFont = (Font)Resources.Load("Fonts/DnDFont", typeof(Font));
        GUIStyle HugeText = new GUIStyle();

        HugeText.normal.textColor = Color.black;
        HugeText.fontSize = 32;
        HugeText.font = DnDFont;
        HugeText.alignment = TextAnchor.UpperCenter;

        // draw the background:
        //GUI.BeginGroup(new Rect(pos.x, pos.y, size.x, size.y));
        //GUI.Box(new Rect(0, 0, size.x, size.y), progressBarEmpty);

        
        GUI.DrawTexture(new Rect(20, 20, 200, 40), progressBarEmpty);
        GUI.DrawTexture(new Rect(20, 20, 0 + PlayerOneHealth, 40), progressBarFull);
        GUI.Label(new Rect(20, 20, 200, 30), "Health", HugeText);

        GUI.DrawTexture(new Rect(20, 70, 200, 40), progressBarEmpty);
        GUI.DrawTexture(new Rect(20, 70, 0 + PlayerOneStamina, 40), progressBarFull);
        GUI.Label(new Rect(20, 70, 200, 30), "Stamina", HugeText);

        GUI.DrawTexture(new Rect(20, 120, 200, 40), progressBarEmpty);
        GUI.DrawTexture(new Rect(20, 120, 0 + PlayerOneMana, 40), progressBarFull);
        GUI.Label(new Rect(20, 120, 200, 30), "Mana", HugeText);
        // draw the filled-in part:
        //GUI.BeginGroup(new Rect(0, 0, size.x * PlayerOneHealth, size.y));
        //GUI.Box(new Rect(0, 0, size.x, size.y), progressBarFull);
        //GUI.EndGroup();

        //GUI.EndGroup();

    }

    void Update()
    {
        // for this example, the bar display is linked to the current time,
        // however you would set this value based on your desired display
        // eg, the loading progress, the player's health, or whatever.
        PlayerOneHealth = 100;
    }
}