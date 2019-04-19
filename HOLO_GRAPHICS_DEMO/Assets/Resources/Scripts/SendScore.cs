using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SendScore : MonoBehaviour
{
    void OnTriggerEnter(Collider otherObject)

    {

        Debug.Log("Ha entrado " + otherObject.gameObject.name);

    }
}
