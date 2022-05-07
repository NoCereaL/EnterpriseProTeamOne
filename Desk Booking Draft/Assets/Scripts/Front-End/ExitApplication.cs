using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitApplication : MonoBehaviour
{

    public void Start()
    {
        if(Application.platform == RuntimePlatform.Android)
        {
            this.gameObject.SetActive(false);
        }
        if(Application.platform == RuntimePlatform.IPhonePlayer)
        {
            this.gameObject.SetActive(false);
        }
    }

    public void QuitApplication()
    {
        Application.Quit();
    }
}
