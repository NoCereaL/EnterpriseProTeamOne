using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BuildingNameScript : MonoBehaviour
{
    private Text buildingName;
    // Start is called before the first frame update
    void Start()
    {
        buildingName = this.gameObject.GetComponent<Text>();
        buildingName.text = SceneManager.GetActiveScene().name;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
