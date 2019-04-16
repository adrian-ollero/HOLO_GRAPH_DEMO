using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetManager : MonoBehaviour
{
    // Parent target
    public Placeable Target;

    public GameObject Background;


    private Color defaultColor;
    private Renderer background_render;

    void Start()
    {
        background_render = Background.GetComponent<Renderer>();
        defaultColor = background_render.material.color;
    }

    public void OnSelect()
    {
        // Call the FixPlace fucntions in the father 
        Target.FixPosition();
        // Destroy this gameobject
        Destroy(transform.gameObject);
    }

    // Gaze funciton to change material
    public void OnGazeEnter()
    {
        background_render.material.color = defaultColor + new Color(0.5f, 0.5f, 0.5f, 1.0f);
        // background_render.material.color
    }

    public void OnGazeLeave()
    {
        background_render.material.color = defaultColor;
    }
}
