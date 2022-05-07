using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;


public class SQLHandler : MonoBehaviour
{
    //Localhost Server URL's

    //Dedicated Server URL's
    private string loginURL = "https://moyanask.com/EPTeam1/login.php";
    private string registerURL = "https://moyanask.com/EPTeam1/register.php";
    private string conURL = "https://moyanask.com/EPTeam1/con.php";

    [SerializeField] GameObject incorrectText;
    [SerializeField] GameObject statusText;

    [SerializeField] Dropdown dateDropdown;

    public InputField usernameField;
    public InputField passwordField;

    //Booking
    [SerializeField] Dropdown startDropdown;
    [SerializeField] Dropdown endDropdown;
    [SerializeField] Text confirmText;
    public DateTime currentDate;

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
        statusText.SetActive(true);
        StartCoroutine(LoginUser());
    }

    IEnumerator RegisterUser()
    {
        WWWForm form = new WWWForm();                   //Create a form
        form.AddField("user", usernameField.text);          //Using the post method make sure 1st parameter same in php
        form.AddField("pass", passwordField.text);
        WWW www = new WWW(registerURL, form);           //We Send the web request form to the php link
        yield return www;
        if(www.text.Contains("Approved"))                      //Checks whether register.php script ran successfully
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
        StartCoroutine(WaitForResponse());
        WWWForm form = new WWWForm();
        form.AddField("user", usernameField.text);
        form.AddField("pass", passwordField.text);
        WWW www = new WWW(loginURL, form);
        yield return www;
        if (www.text.Contains("Approved"))      //Checks weather login.php script ran successfully
        {
            Debug.Log("Login Successfully");
            incorrectText.SetActive(false);
            UserScript.StoreUsername(usernameField.text);
            if (usernameField.text.Substring(0, 3) == "ADM")
            {
                SceneManager.LoadScene("AdminMenu");
            }
            else
            {
                SceneManager.LoadScene(1);          //Signs you into the system by loading the index scene
            }
            statusText.SetActive(false);
        }
        if (www.text.Contains("-1"))             //Failed login response
        {
            Debug.Log("Unsuccessfull Result: " + www.text);
            incorrectText.SetActive(true);
            yield return new WaitForSecondsRealtime(2);
            incorrectText.SetActive(false);
            UserScript.StoreUsername("");
            statusText.SetActive(false);
        }
    }

    IEnumerator WaitForResponse()
    {
        yield return new WaitForSecondsRealtime(5);
        StopCoroutine(LoginUser());
        statusText.SetActive(true);
        statusText.gameObject.GetComponent<Text>().text = "Check Connection...";
        statusText.gameObject.GetComponent<Text>().color = Color.red;
        yield return new WaitForSecondsRealtime(5);
        statusText.SetActive(false);
        statusText.gameObject.GetComponent<Text>().text = "Logging in...";
        statusText.gameObject.GetComponent<Text>().color = Color.black;
    }

}
