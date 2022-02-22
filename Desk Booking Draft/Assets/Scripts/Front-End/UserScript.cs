using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UserScript : MonoBehaviour
{
    public InputField usernameField;
    [SerializeField] Text username;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        SetUsername();
    }

    public static void StoreUsername(string user_name)
    {
        PlayerPrefs.SetString("Username", user_name);
    }

    public void SetUsername()
    {
        username.text = PlayerPrefs.GetString("Username");
    }
}
