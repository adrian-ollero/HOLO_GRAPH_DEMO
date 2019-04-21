using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class TargetManager : MonoBehaviour
{
    public TextMesh grollars_score;
    public Text winner_text;

    public void SendScore(string name)
    {
        Debug.Log("Collision: "+ name);
        int score = Convert.ToInt32(name) + Convert.ToInt32(grollars_score.text);
        grollars_score.text = "" + score;
    }


}
