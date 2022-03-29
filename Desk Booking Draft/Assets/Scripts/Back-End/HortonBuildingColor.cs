using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HortonBuildingColor : MonoBehaviour
{
    [SerializeField] MeshRenderer[] meshRenderers;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        foreach(MeshRenderer r in meshRenderers)
        {
            r.material.color = new Color32(234,196,177,1);
        }
    }
}
