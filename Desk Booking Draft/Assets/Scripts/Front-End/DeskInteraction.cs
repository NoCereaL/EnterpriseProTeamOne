using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeskInteraction : MonoBehaviour
{

    [SerializeField] GameObject dateObject;
    [SerializeField] GameObject startTimeObject;
    [SerializeField] GameObject endTimeObject;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame    
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                Debug.Log(hit.transform.name + " Selected");
                //Select stage    
                if (hit.transform.name == transform.name)
                {
                    SceneManager.LoadScene("Booking");
                    PlayerPrefs.SetString("DeskName", hit.transform.name);
                    Debug.Log("Desk Name Set To: " + hit.transform.name);
                }
            }
        }
    }
}

