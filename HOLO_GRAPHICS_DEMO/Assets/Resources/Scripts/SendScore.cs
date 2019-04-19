using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SendScore : MonoBehaviour
{
    void OnTriggerEnter(Collider c)

    {

        Debug.Log("Ha entrado " + c.gameObject.name);

    }
}
