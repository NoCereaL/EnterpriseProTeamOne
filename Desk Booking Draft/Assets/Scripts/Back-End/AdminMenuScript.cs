using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AdminMenuScript : MonoBehaviour
{
    //On Click Methods

    public void Registration()
    {
        SceneManager.LoadScene("AdminRegistration");
    }

    public void Map()
    {
        SceneManager.LoadScene("Index");
    }

    public void ViewBookings()
    {
        SceneManager.LoadScene("Cancellation");
    }
}
