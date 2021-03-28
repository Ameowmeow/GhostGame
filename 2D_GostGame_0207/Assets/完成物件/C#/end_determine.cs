using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class end_determine : MonoBehaviour
{
    public GameObject HappyEnding;
    public GameObject BadEnding;


    static int x;

    static string char1_text;

    public void char1_click()
    {
        x = 1;
    }

    public void char2_click()
    {
        x = 2;
    }

    public void char3_click()
    {
        x = 3;
    }

    public void char4_click()
    {
        x = 4;
    }

    public void char_click()
    {
        print(x);
        if (x == 2)
        {
            HappyEnding.SetActive(true);
        }
        else if ( x == 1 || x == 3 || x == 4)
        {
            BadEnding.SetActive(true);
        }

    }

}
