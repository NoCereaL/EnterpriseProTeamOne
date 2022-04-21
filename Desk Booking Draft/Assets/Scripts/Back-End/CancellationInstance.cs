using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CancellationInstance : MonoBehaviour
{
    public static CancellationInstance _instance;

    public GameObject mainCanvas;
    //Singlton
    public static CancellationInstance Instance
    {
        get
        {
            return _instance;
        }
    }
    private void Awake()
    {
        if (_instance != null && _instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            _instance = this;
        }
    }
}
