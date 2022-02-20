using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonActionsScript : MonoBehaviour
{
    [SerializeField] InputField username;
    [SerializeField] InputField password;
    [SerializeField] GameObject incorrectText;
    public void Login()
    {
        if (username.text == "Simon" && password.text == "Simon")
        {
            SceneManager.LoadScene(1);
        }
        else
        {
            incorrectText.SetActive(true);
        }
    }
}
