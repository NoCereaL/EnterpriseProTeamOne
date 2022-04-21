using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RoomInstance : MonoBehaviour
{
    public static RoomInstance _instance;
    public GameObject room;
    public GameObject popup;

    public static RoomInstance Instance
    {
        get
        {
            return _instance;
        }
    }

    void Awake()
    {
        if(_instance != null && _instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            _instance = this;
        }
        PlayerPrefs.SetString("PreviousScene", SceneManager.GetActiveScene().name);
    }


} 
