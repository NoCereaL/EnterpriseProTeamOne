using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuButtonScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
     if(PlayerPrefs.GetString("Username").Substring(0,3) == "ADM")
        {
            this.gameObject.SetActive(false);
        }
    }
}
