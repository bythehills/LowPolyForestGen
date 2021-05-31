using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorLight : MonoBehaviour
{

    public Light l;
    Color c;
    void Start()
    {
        //change color of light based on theme
        if (PlayerPrefs.GetString("Theme", "Summer").Equals("Summer"))
        {
            c = Random.ColorHSV(0f, 0.3f, 0.1f, 0.5f, 1, 1);
        }
        else
        {
            c = Random.ColorHSV(0.5f, 0.8f, 0.1f, 0.4f, 0.5f, 0.7f);

        }
        l.color = c;
    }

}
