using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OneMoremanagerForTargetColliders : MonoBehaviour
{
    // Delegate the call to the Dart Trhown
    void OnSelect()
    {
       GameObject.Find("Wall").SendMessage("OnSelect");
    }
}
