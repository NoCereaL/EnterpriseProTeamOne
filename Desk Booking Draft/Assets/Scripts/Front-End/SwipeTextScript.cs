using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwipeTextScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        CheckPlatform();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CheckPlatform()
    {
        if(Application.platform == RuntimePlatform.Android)
        {
            this.gameObject.SetActive(false);
            this.gameObject.GetComponent<SwipeTextScript>().enabled = false;
        }
        if (Application.platform == RuntimePlatform.IPhonePlayer)
        {
            this.gameObject.SetActive(false);
            this.gameObject.GetComponent<SwipeTextScript>().enabled = false;
        }
    }
}
