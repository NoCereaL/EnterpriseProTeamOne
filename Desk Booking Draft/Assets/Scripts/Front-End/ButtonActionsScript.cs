using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonActionsScript : MonoBehaviour
{
    public GameObject loadingScreen;

    public void Update()
    {
        loadingScreen = GameObject.Find("LoadingScreen");
    }
    public void BackToIndex()
    {
        SceneManager.LoadScene(1);
    }

    public void LogOut()
    {
        SceneManager.LoadScene(0);
    }

    public void ViewBookingsScene()
    {
        SceneManager.LoadScene("Cancellation");
    }
}
