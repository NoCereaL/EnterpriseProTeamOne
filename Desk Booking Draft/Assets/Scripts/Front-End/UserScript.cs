using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class UserScript : MonoBehaviour
{
    public InputField usernameField;
    private Text username;
    // Start is called before the first frame update
    void Start()
    {
        username = this.gameObject.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        GetUsername();
    }

    public static void StoreUsername(string user_name)
    {
        PlayerPrefs.SetString("Username", user_name);
    }

    public void GetUsername()
    {
        try
        {
            username.text = PlayerPrefs.GetString("Username");
        }
        catch
        {

        }

    }
}
