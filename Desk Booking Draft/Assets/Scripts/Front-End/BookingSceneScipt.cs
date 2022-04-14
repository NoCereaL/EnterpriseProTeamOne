using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BookingSceneScipt : MonoBehaviour
{
    [SerializeField] Text deskName;
    [SerializeField] Text date;
    [SerializeField] Text startTime;
    [SerializeField] Text endTime;
    private Dropdown dateDropdown;
    private Dropdown startDropdown;
    private Dropdown endDropdown;
    [SerializeField] Dropdown durationDropdown;

    [SerializeField] Text userText;
    [SerializeField] Text buildingText;
    // Start is called before the first frame update
    void Start()
    {
        deskName.text = "Desk Selected: " + PlayerPrefs.GetString("DeskName");
        dateDropdown = GameObject.Find("DateDropdown").GetComponent<Dropdown>();
        startDropdown = GameObject.Find("StartTimeDropdown").GetComponent<Dropdown>();
       // endDropdown = GameObject.Find("EndTimeDropdown").GetComponent<Dropdown>();
    }

    void Update()
    {
        SetInfo();
        SetUsername();
        SetBuildingName();
    }

    public void backToRoom()
    {
        string currentRoom = PlayerPrefs.GetString("CurrentBuilding");
        SceneManager.LoadScene(currentRoom);
    }

    public void SetInfo()
    {
        date.text = "Date Selected: " + dateDropdown.captionText.text;
        startTime.text = "Start Time: " + startDropdown.captionText.text;
        //endTime.text = "End Time: " + endDropdown.captionText.text;
        endTime.text = "Duration: " + durationDropdown.captionText.text;
    }

    public void SetBuildingName()
    {
        buildingText.text = PlayerPrefs.GetString("CurrentBuilding");
    }

    public void SetUsername()
    {
       userText.text = PlayerPrefs.GetString("Username");
    }
}
