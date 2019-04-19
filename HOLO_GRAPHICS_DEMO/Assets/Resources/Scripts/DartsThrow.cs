using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DartsThrow : MonoBehaviour
{
    public GameObject dart;

    public float Fuerza = 1.0f;

    public GameObject target;

    private GameObject origin;

    // Start is called before the first frame update
    void Start()
    {
        origin = GameObject.Find("DartOrigin");
    }

    void OnSelect()
    {
        if (target.GetComponent<Placeable>().IsPlaced)
        {
            GameObject d = GameObject.Instantiate(dart, origin.transform.position, origin.transform.rotation);
            d.GetComponent<Rigidbody>().AddForce(Camera.main.transform.forward * Fuerza, ForceMode.Impulse);
        }
            
    }
}
