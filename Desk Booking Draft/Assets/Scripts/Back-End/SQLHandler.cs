using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class SQLHandler : MonoBehaviour
{
    //Localhost Server URL's
    private string localLoginURL = "http://localhost/unity_test/login.php";
    private string localRegisterURL = "http://localhost/unity_test/register.php";

    //Dedicated Server URL's
    private string loginURL = "https://moyanask.com/EPTeam1/login.php";
    private string registerURL = "https://moyanask.com/EPTeam1/register.php";
    [SerializeField] GameObject incorrectText;
    [SerializeField] GameObject statusText;

    public InputField usernameField;
    public InputField passwordField;
    // Start is called before the first frame update
    void Start()
    {
    }

    public void CallRegisterUser()
    {
        StartCoroutine(RegisterUser());
    }

    public void CallLoginUser()
    {
        StartCoroutine(LoginUser());
    }

    IEnumerator RegisterUser()
    {
        WWWForm form = new WWWForm();                   //Create a form
        form.AddField("user", usernameField.text);          //Using the post method make sure 1st parameter same in php
        form.AddField("pass", passwordField.text);
        WWW www = new WWW(registerURL, form);           //We Send the web request form to the php link
        yield return www;
        if(www.text.Contains("Approved"))                      //Checks weather register.php script ran successfully
        {
            Debug.Log("User Created Successfully");
        }
        else
        {
            Debug.Log("Unsuccessfull Result: " + www.text);        //print out php/sql error
        }
    }

    IEnumerator LoginUser()
    {
        WWWForm form = new WWWForm();
        form.AddField("user", usernameField.text);
        form.AddField("pass", passwordField.text);
        WWW www = new WWW(loginURL, form);
        statusText.SetActive(true);
        yield return www;
        if (www.text.Contains("Approved"))      //Checks weather login.php script ran successfully
        {
            Debug.Log("Login Successfully");
            incorrectText.SetActive(false);
            UserScript.StoreUsername(usernameField.text);
            SceneManager.LoadScene(1);          //Signs you into the system by loading the index scene
        }
        else
        {
            Debug.Log("Unsuccessfull Result: " + www.text);
            incorrectText.SetActive(true);
            UserScript.StoreUsername("");
        }
        statusText.SetActive(false);
    }
}
