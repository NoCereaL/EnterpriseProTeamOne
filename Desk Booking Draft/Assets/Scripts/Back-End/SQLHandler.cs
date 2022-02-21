using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;
using System.Text;
using System.Collections.Specialized;
using System.Net;
using System.IO;
using System;

public class SQLHandler : MonoBehaviour
{
    public string loginURL = "http://localhost/unity_test/login.php";
    public string usernameURL = "http://localhost/unity_test/username.php";
    public string sendURL = "http://localhost/unity_test/send.php";
    public Text statusText;
    public Text usernameText;

    public InputField usernameField;
    public InputField passwordField;
    // Start is called before the first frame update
    void Start()
    {
        //StartCoroutine(GetUsername());
    }

    IEnumerator GetUsername()
    {
        usernameText.text = "Loading Scores";
        WWW hs_get = new WWW(usernameURL);
        yield return hs_get;
        if (hs_get.error != null)
        {
            print("There was an error getting the high score: " + hs_get.error);
        }
        else
        {
            usernameText.text = hs_get.text; // this is a GUIText that will display the scores in game.
        }
    }

    public void CallRegisterUser()
    {
        StartCoroutine(RegisterUser());
    }

    IEnumerator RegisterUser()
    {
        WWWForm form = new WWWForm();
        form.AddField("user", usernameField.text);
        form.AddField("pass", passwordField.text);
        WWW www = new WWW("http://localhost/unity_test/send.php", form);
        yield return www;
        if(www.text == "Approved")
        {
            Debug.Log("User Created Successfully");
        }
        else
        {
            Debug.Log("Unsuccessfull: " + www.text);
        }
    }

}
