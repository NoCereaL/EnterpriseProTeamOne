using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonScript : MonoBehaviour
{
    public void BackToIndex()
    {
        SceneManager.LoadScene(1);
    }

    public void Logout()
    {
        SceneManager.LoadScene(0);
    }
}
