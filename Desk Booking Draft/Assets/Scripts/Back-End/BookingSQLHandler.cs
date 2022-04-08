using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class BookingSQLHandler : MonoBehaviour
{
    private string bookingURL = "https://moyanask.com/EPTeam1/booking.php";
    [SerializeField] Dropdown dateDropdown;

    //Booking
    private TimeSpan startTime;
    private TimeSpan endTime;
    [SerializeField] Dropdown startDropdown;
    [SerializeField] Dropdown endDropdown;
    [SerializeField] Text confirmText;
    public DateTime currentDate;

    string startHoursString;
    string startMinutesString;
    int startHours;
    int startMinutes;
    string endHoursString;
    string endMinutesString;
    int endHours;
    int endMinutes;
    // Start is called before the first frame update
    void Start()
    {
        dateDropdown.captionText.text = DateTime.Now.ToString();
        FillDateDropdown();
    }

    public void CallBooking()
    {
        StartCoroutine(Booking());
    }

    IEnumerator Booking()
    {
        WWWForm form = new WWWForm();                   //Create a form
        form.AddField("deskID", PlayerPrefs.GetString("DeskName"));          //Using the post method make sure 1st parameter same in php
        form.AddField("staffID", PlayerPrefs.GetString("Username"));
        form.AddField("date", PlayerPrefs.GetString("CurrentDate"));
        form.AddField("startTime", startDropdown.captionText.text);
        form.AddField("endTime", endDropdown.captionText.text);

        WWW www = new WWW(bookingURL, form);           //We Send the web request form to the php link
        yield return www;
        if (www.text.Contains("Approved"))                  //Checks whether register.php script ran successfully
        {
            Debug.Log("Booking Confirmed Successfully");
            confirmText.gameObject.SetActive(true);
            confirmText.text = "Booking Confirmed Successfully...";
            confirmText.color = Color.green;
            StartCoroutine(DestroyAnim());
        }
        else
        {
            Debug.Log("Unsuccessfull Result: " + www.text);        //print out php/sql error
            confirmText.gameObject.SetActive(true);
            confirmText.text = "Booking Unccessfully...";
            confirmText.color = Color.red;
            StartCoroutine(DestroyAnim());
        }
    }


    public void SetDate()
    {
        PlayerPrefs.SetString("CurrentDate", dateDropdown.captionText.text);
        Debug.Log(dateDropdown.captionText.text);
        startTime = new TimeSpan(startHours, startMinutes, 00);
        endTime = new TimeSpan(endHours, endMinutes, 00);

        startHoursString = startDropdown.captionText.text.Substring(0, 2);
        startMinutesString = startDropdown.captionText.text.Substring(3, 2);
        startHours = Int32.Parse(startHoursString);
        startMinutes = Int32.Parse(startMinutesString);
        endHoursString = startDropdown.captionText.text.Substring(0, 2);
        endMinutesString = endDropdown.captionText.text.Substring(3, 2);
        endHours = Int32.Parse(endHoursString);
        endMinutes = Int32.Parse(endMinutesString);

        Debug.Log(startTime);
        Debug.Log(startTime.Subtract(endTime));
        Debug.Log(PlayerPrefs.GetString("CurrentDate"));
    }

    public void FillDateDropdown()
    {
        currentDate = DateTime.Now;
        currentDate = currentDate.AddDays(1);
        dateDropdown.ClearOptions();
        //DateTime _30Days = new DateTime(0000,0,30);
        List<String> list = new List<String>();
        Dropdown.OptionData dropdownObjects = new Dropdown.OptionData();
        for (int i = 0; i < 30; i++)
        {

            dropdownObjects.text = currentDate.ToString("yyyy-MM-dd").Substring(0, 10);
            list.Add(dropdownObjects.text);
            currentDate = currentDate.AddDays(1).Date;
        }
        dateDropdown.AddOptions(list);
        Debug.Log("List Filled");
    }

    IEnumerator DestroyAnim()
    {
        yield return new WaitForSeconds(2);
        confirmText.gameObject.SetActive(false);
    }
}
