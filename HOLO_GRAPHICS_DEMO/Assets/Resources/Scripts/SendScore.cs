using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SendScore : MonoBehaviour
{
    public float TTL = 10.0f;

    void OnTriggerEnter(Collider c)
    {
        Rigidbody rb = GetComponent<Rigidbody>();

        if (c.gameObject.name=="1" || c.gameObject.name == "2" || c.gameObject.name == "3"
            || c.gameObject.name == "4" || c.gameObject.name == "5")
        {
            TargetManager manager = c.gameObject.transform.parent.GetComponent<TargetManager>();
            manager.SendScore(c.gameObject.name);

            
            rb.constraints = RigidbodyConstraints.FreezePosition | RigidbodyConstraints.FreezeRotation;

            StartCoroutine(Timer());
        }else if(c.gameObject.name == "Wall")
        {
            rb.mass *= 10;
        }

    }

    IEnumerator Timer()
    {
        yield return new WaitForSeconds(TTL);
        Destroy(transform.gameObject);
    }
}
