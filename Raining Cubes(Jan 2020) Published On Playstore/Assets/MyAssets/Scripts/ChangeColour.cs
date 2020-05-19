using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColour : MonoBehaviour
{
    public Material[] material;
    private Renderer rend;
    public ParticleSystem playerPS;
    private Renderer PSRend;

    public static int ColorID;
    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
        rend.sharedMaterial = material[ColorID];
        PSRend = playerPS.GetComponent<Renderer>();
        PSRend.sharedMaterial = material[ColorID];

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }






    public void ColorRed()
    {
        rend.sharedMaterial = material[1];
        PSRend.sharedMaterial = material[1];
        ColorID = 1;
    }
    public void ColorPink()
    {
        rend.sharedMaterial = material[2];
        PSRend.sharedMaterial = material[2];
        ColorID = 2;
    }
    public void ColorPurple()
    {
        rend.sharedMaterial = material[3];
        PSRend.sharedMaterial = material[3];
        ColorID = 3;
    }
    public void ColorBlue()
    {
        rend.sharedMaterial = material[4];
        PSRend.sharedMaterial = material[4];
        ColorID = 4;
    }
    public void ColorGreen()
    {
        rend.sharedMaterial = material[5];
        PSRend.sharedMaterial = material[5];
        ColorID = 5;
    }
    public void DarkGreen()
    {
        rend.sharedMaterial = material[6];
        PSRend.sharedMaterial = material[6];
        ColorID = 6;
    }
    public void ColorDarkBlue()
    {
        rend.sharedMaterial = material[7];
        PSRend.sharedMaterial = material[7];
        ColorID = 7;
    }
    public void ColorOrange()
    {
        rend.sharedMaterial = material[8];
        PSRend.sharedMaterial = material[8];
        ColorID = 8;
    }
    public void ColorYellow()
    {
        rend.sharedMaterial = material[9];
        PSRend.sharedMaterial = material[9];
        ColorID = 9;
    }
    public void ColorBlack()
    {
        rend.sharedMaterial = material[10];
        PSRend.sharedMaterial = material[10];
        ColorID = 10;
    }
    public void ColorBrown()
    {
        rend.sharedMaterial = material[11];
        PSRend.sharedMaterial = material[11];
        ColorID = 11;
    }
    public void ColorWhite()
    {
        rend.sharedMaterial = material[12];
        PSRend.sharedMaterial = material[12];
        ColorID = 12;
    }
}
