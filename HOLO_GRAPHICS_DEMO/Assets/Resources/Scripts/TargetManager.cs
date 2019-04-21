using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class TargetManager : MonoBehaviour
{
    public TextMesh grollars_score;
 
    public void SendScore(string name)
    {
        int score = Convert.ToInt32(name) + Convert.ToInt32(grollars_score.text);
        grollars_score.text = "" + score;
    }


}
