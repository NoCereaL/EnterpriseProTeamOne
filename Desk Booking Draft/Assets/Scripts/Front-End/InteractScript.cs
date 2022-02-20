using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InteractScript : MonoBehaviour
{
    void Start() { }

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
                switch (hit.transform.name)
                {
                    case "Richmond":
                        SceneManager.LoadScene("Richmond");
                        break;
                    case "Horton":
                        SceneManager.LoadScene("Horton");
                        break;
                    case "Norcroft":
                        SceneManager.LoadScene("Norcroft");
                        break;
                }
            }
        }
        //CastRay();
    }

    void CastRay()
    {
        //Test Ray Casting
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            // Casts the ray and get the first game object hit
            Physics.Raycast(ray, out hit);
            Debug.Log("This hit at " + hit.transform.name);
        }
    }
}

