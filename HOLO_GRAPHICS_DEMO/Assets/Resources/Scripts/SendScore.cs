using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SendScore : MonoBehaviour
{

    void OnTriggerEnter(Collider c)
    {
        if(c.gameObject.name=="1" || c.gameObject.name == "2" || c.gameObject.name == "3"
            || c.gameObject.name == "4" || c.gameObject.name == "5")
        {
            TargetManager manager = c.gameObject.transform.parent.GetComponent<TargetManager>();
            manager.SendScore(c.gameObject.name);

            
        }

    }
}
