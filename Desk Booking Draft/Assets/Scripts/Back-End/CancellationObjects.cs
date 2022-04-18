using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CancellationObjects : MonoBehaviour
{
    [HideInInspector] GameObject deskTextTwo;
    [HideInInspector] GameObject deskNameText;
    [HideInInspector] GameObject staffBookedText;
    [HideInInspector] GameObject managerBookedText;
    [HideInInspector] GameObject adminBookedText;
    [HideInInspector] GameObject startTimeText;
    [HideInInspector] GameObject durationText;
    [HideInInspector] GameObject dateText;

    [HideInInspector] GameObject mainCanvas;
    [HideInInspector] GameObject cancelCanvas;

    // Start is called before the first frame update
    void Start()
    {
        deskTextTwo = GameObject.Find("DeskNameTwo");
        deskNameText = GameObject.Find("DeskName");
        staffBookedText = GameObject.Find("StaffBookedText");
        managerBookedText = GameObject.Find("ManagerBookedText");
        adminBookedText = GameObject.Find("AdminBookedText");
        startTimeText = GameObject.Find("StartTimeText");
        durationText = GameObject.Find("DurationText");
        dateText = GameObject.Find("DateText");

        mainCanvas = GameObject.Find("MainCanvas");
        cancelCanvas = GameObject.Find("CancelCanvas");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void BackButton()
    {
        mainCanvas.SetActive(true);
    }

    public void SetSelection()
    {
        mainCanvas.SetActive(false);

        string[] selectionArray = this.gameObject.GetComponent<Text>().text.Split('|');
        staffBookedText.GetComponent<Text>().text = this.gameObject.GetComponent<Text>().text;
        for (int i = 0; i <= selectionArray.Length - 1; i++)
        {
            Debug.Log(selectionArray[i]);
        }

        deskTextTwo.GetComponent<Text>().text = selectionArray[0];
        deskNameText.GetComponent<Text>().text = selectionArray[0];
        staffBookedText.GetComponent<Text>().text = "Staff Booked: " + selectionArray[2];
        managerBookedText.GetComponent<Text>().text = "Manageer Booked: " + selectionArray[1];
        adminBookedText.GetComponent<Text>().text = "Admin Booked: " + selectionArray[3];
        startTimeText.GetComponent<Text>().text = "Start Time: " + selectionArray[5];
        durationText.GetComponent<Text>().text = "Duration: " + selectionArray[6];
        dateText.GetComponent<Text>().text = "Date: " + selectionArray[4];
        PlayerPrefs.SetString("BookingID", selectionArray[7]);
    }
}
