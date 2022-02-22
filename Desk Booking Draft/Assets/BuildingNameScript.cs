using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BuildingNameScript : MonoBehaviour
{
    private Text buildingText;
    // Start is called before the first frame update
    void Start()
    {
        buildingText = this.gameObject.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        GetRoomName();
    }

    public void GetRoomName()
    {
        buildingText.text = SceneManager.GetActiveScene().name;
    }
}
