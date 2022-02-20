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
    // Start is called before the first frame update
    void Start()
    {
        //StartCoroutine(GetScores());
        //StartCoroutine(GetUsername());
        StartCoroutine(LoginHandler("UnityUser","UnityPass"));
    }

    IEnumerator GetScores()
    {
        statusText.text = "Loading Scores";
        WWW hs_get = new WWW(loginURL);
        yield return hs_get;

        if (hs_get.error != null)
        {
            print("There was an error getting the high score: " + hs_get.error);
        }
        else
        {
            statusText.text = hs_get.text; // this is a GUIText that will display the scores in game.
        }
    }

    IEnumerator GetUsername()
    {
        TestingPost();
        usernameText.text = "Loading Scores";
        WWW hs_get = new WWW(usernameURL);
        yield return hs_get;
        TestingPost();
        if (hs_get.error != null)
        {
            print("There was an error getting the high score: " + hs_get.error);
        }
        else
        {
            usernameText.text = hs_get.text; // this is a GUIText that will display the scores in game.
        }
    }

    IEnumerator LoginHandler(string user, string pass)
    {
        //This connects to a server side php script that will add the name and score to a MySQL DB.
        // Supply it with a string representing the players name and the players score.
        string hash = Md5Sum(user + pass + "team");

        string post_url = usernameURL + "user=" + WWW.EscapeURL(user) + "&pass=" + WWW.EscapeURL(pass) + "&hash=" + hash;

        // Post the URL to the site and create a download object to get the result.
        WWW hs_post = new WWW(post_url);
        yield return hs_post; // Wait until the download is done
        statusText.text = hs_post.text;
        Debug.Log("Success");
        Debug.Log(hs_post.text);    //Print Php result
        if (hs_post.error != null)
        {
            Debug.Log("There was an error posting the high score: " + hs_post.error);
        }
    }

    public void TestingPost()
    {
        WebClient webClient = new WebClient();

        NameValueCollection formData = new NameValueCollection();
        formData["username"] = "username";
        formData["password"] = "password";

        byte[] responseBytes = webClient.UploadValues(usernameURL, "POST", formData);
        string responsefromserver = Encoding.UTF8.GetString(responseBytes);
        Console.WriteLine(responsefromserver);
        webClient.Dispose();
    }

    public string Md5Sum(string strToEncrypt)
    {
        System.Text.UTF8Encoding ue = new System.Text.UTF8Encoding();
        byte[] bytes = ue.GetBytes(strToEncrypt);

        // encrypt bytes
        System.Security.Cryptography.MD5CryptoServiceProvider md5 = new System.Security.Cryptography.MD5CryptoServiceProvider();
        byte[] hashBytes = md5.ComputeHash(bytes);

        // Convert the encrypted bytes back to a string (base 16)
        string hashString = "";

        for (int i = 0; i < hashBytes.Length; i++)
        {
            hashString += System.Convert.ToString(hashBytes[i], 16).PadLeft(2, '0');
        }

        return hashString.PadLeft(32, '0');
    }
}
