using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonActionsScript : MonoBehaviour
{
    public GameObject loadingScreen;
    [SerializeField] Text logoutText;

    public void Update()
    {
        UpdateLogoutButtonText();
        loadingScreen = GameObject.Find("LoadingScreen");
    }
    public void BackToIndex()
    {
        SceneManager.LoadScene(1);
    }

    public void UpdateLogoutButtonText()
    {
        if (logoutText != null)
        {
            if (PlayerPrefs.GetString("Username").Substring(0, 3) == "ADM")
            {
                logoutText.text = "Menu";
            }
            else
            {
                logoutText.text = "Logout";
            }
        }
    }

    public void LogOut()
    {
        if (PlayerPrefs.GetString("Username").Substring(0, 3) == "ADM")
        {
            SceneManager.LoadScene("AdminMenu");
        }
        else
        {
            SceneManager.LoadScene(0);
        }
    }

    public void ViewBookingsScene()
    {
        SceneManager.LoadScene("Cancellation");
    }
}
