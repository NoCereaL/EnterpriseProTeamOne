using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InfoBoxScript : MonoBehaviour
{
    [SerializeField] GameObject infoBox;
    [SerializeField] Text infoText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CastRay();
    }

    public void CastRay()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            switch (hit.transform.name)
            {
                case "Richmond":
                    infoBox.SetActive(true);
                    infoBox.transform.position = Input.mousePosition;
                    infoText.text = "Richomond";
                    break;
                case "Horton":
                    infoBox.SetActive(true);
                    infoBox.transform.position = Input.mousePosition;
                    infoText.text = "Horton";
                    break;
                case "Norcroft":
                    infoBox.SetActive(true);
                    infoBox.transform.position = Input.mousePosition;
                    infoText.text = "Norcoft";
                    break;
                default:
                    infoBox.SetActive(false);
                    break;
            }
        }
        else
        {
            infoBox.SetActive(false);
        }
    }
}
