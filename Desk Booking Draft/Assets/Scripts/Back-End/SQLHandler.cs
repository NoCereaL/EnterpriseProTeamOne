using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SQLHandler : MonoBehaviour
{
    public string loginURL = "http://localhost/unity_test/login.php";
    public Text statusText;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(GetScores());
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
}
