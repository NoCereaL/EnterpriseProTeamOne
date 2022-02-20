using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighlightScript : MonoBehaviour
{
    public MeshRenderer[] meshRenderers;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        try
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            // Casts the ray and get the first game object hit
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.transform.name == transform.name)
                {
                    for (int i = meshRenderers.Length - 1; i >= 0; i--)
                    {
                        meshRenderers[i].material.color = Color.yellow;         //Set Building Parts colors
                    }
                }
                else
                {
                    for (int i = meshRenderers.Length - 1; i >= 0; i--)
                    {
                        meshRenderers[i].material.color = Color.white;
                    }
                }
            }
            else
            {
                for (int i = meshRenderers.Length - 1; i >= 0; i--)
                {
                    meshRenderers[i].material.color = Color.white;
                }
            }
        }
        catch (Exception e){}
    }
}
