using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

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

    [HideInInspector] GameObject background;
    string[] selectionArray;

    [SerializeField] Text infoText;

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

        cancelCanvas = GameObject.Find("CancelCanvas");
        mainCanvas = CancellationInstance.Instance.mainCanvas;

        background = gameObject.GetComponentInParent<Image>().gameObject;
        CheckPreviousBooking();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void BackButton()
    {
        mainCanvas.SetActive(true);
    }

    public void FillArray()
    {
        selectionArray = infoText.text.Split('|');
        staffBookedText.GetComponent<Text>().text = this.gameObject.GetComponent<Text>().text;
        for (int i = 0; i <= selectionArray.Length - 1; i++)
        {
            //Debug.Log(selectionArray[i]);
        }
    }

    public void SetSelection()
    {
        Destroy(mainCanvas);
        Destroy(CancellationInstance.Instance.mainCanvas);

        FillArray();

        deskTextTwo.GetComponent<TextMeshProUGUI>().text = selectionArray[0];
        deskNameText.GetComponent<TextMeshProUGUI>().text = selectionArray[0];
        staffBookedText.GetComponent<Text>().text = "Staff Booked: " + selectionArray[2];
        managerBookedText.GetComponent<Text>().text = "Manageer Booked: " + selectionArray[1];
        adminBookedText.GetComponent<Text>().text = "Admin Booked: " + selectionArray[3];
        startTimeText.GetComponent<Text>().text = "Start Time: " + selectionArray[5];
        durationText.GetComponent<Text>().text = "Duration: " + selectionArray[6];
        dateText.GetComponent<Text>().text = "Date: " + selectionArray[4];
        PlayerPrefs.SetString("BookingID", selectionArray[7]);
    }

    public void CheckPreviousBooking()
    {
        FillArray();
        DateTime currentDate = DateTime.Now;
        DateTime objectDate = DateTime.Parse(selectionArray[4]);
        if (objectDate <= currentDate)
        {
            background.GetComponent<Image>().color = new Color32(255, 166, 166, 255);
        }
    }
}
