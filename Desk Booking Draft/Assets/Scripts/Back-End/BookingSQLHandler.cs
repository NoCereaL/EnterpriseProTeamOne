using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
using System.Linq;
using UnityEngine.SceneManagement;

public class BookingSQLHandler : MonoBehaviour
{
    private string bookingURL = "https://moyanask.com/EPTeam1/booking.php";
    private string bookingAltURL = "https://moyanask.com/EPTeam1/booking_alt.php";
    private string managerURL = "https://moyanask.com/EPTeam1/managerBooking.php";
    private string fillUsersURL = "https://moyanask.com/EPTeam1/fillUsers.php";

    [SerializeField] Dropdown dateDropdown;

    //Booking
    private TimeSpan startTime;
    private TimeSpan endTime;
    [SerializeField] Dropdown startDropdown;
    //[SerializeField] Dropdown endDropdown;
    [SerializeField] Dropdown durationDropdown;
    [SerializeField] Dropdown userDropdown;
    [SerializeField] Text confirmText;
    public DateTime currentDate;
    public Text debugText;
    public Text debugText2;

    [HideInInspector] public WWW wwwBooking;

    string startHoursString;
    string startMinutesString;
    int startHours;
    int startMinutes;
    string endHoursString;
    string endMinutesString;
    int endHours;
    int endMinutes;

    public List<string> listOfUsers;
    public string[] staffArray;
    // Start is called before the first frame update
    void Start()
    {
        dateDropdown.captionText.text = DateTime.Now.ToString();
        if(PlayerPrefs.GetString("Username").Substring(0,3) == "STA") { FillDateDropdown(); }
        StartCoroutine(FillAvaTimes());
        if (PlayerPrefs.GetString("Username").Substring(0, 3) != "STA") { StartCoroutine(UserSelected()); }
    }

    //Call Methods
    public void CallBooking()
    {
        StartCoroutine(Booking());
    }

    public void CallFillAvaTimes()
    {
        StartCoroutine(FillAvaTimes());
    }

    public void CallUserSelected()
    {
        StartCoroutine(UserSelected());
    }

    public void CallManagerBooking()
    {
        StartCoroutine(ManagerBooking());
    }

    public void CallAdminBooking()
    {
        StartCoroutine(AdminBooking());
    }

    IEnumerator Booking()
    {
        WWWForm form = new WWWForm();                   //Create a form
        form.AddField("deskID", PlayerPrefs.GetString("DeskName"));          //Using the post method make sure 1st parameter same in php
        form.AddField("managerID", "NULL");
        form.AddField("staffID", PlayerPrefs.GetString("Username"));
        form.AddField("adminID", "NULL");
        form.AddField("date", PlayerPrefs.GetString("CurrentDate"));
        form.AddField("startTime", startDropdown.captionText.text);
        //form.AddField("endTime", endDropdown.captionText.text);
        TimeSpan startTime = new TimeSpan(Int32.Parse(startDropdown.captionText.text.Substring(0, 2)), Int32.Parse(startDropdown.captionText.text.Substring(3, 2)), 00);
        TimeSpan durationTime = new TimeSpan(Int32.Parse(durationDropdown.captionText.text.Substring(0, 2)), Int32.Parse(durationDropdown.captionText.text.Substring(3, 2)), 00);
        TimeSpan endTime = startTime.Add(durationTime);
        form.AddField("endTime", endTime.ToString());
        form.AddField("booking_duration", (durationDropdown.captionText.text+":00"));
        Debug.Log(durationDropdown.captionText.text+":00");

        WWW www = new WWW(bookingURL, form);           //We Send the web request form to the php link
        yield return www;
        if (www.text.Contains("Approved"))                  //Checks whether register.php script ran successfully
        {
            Debug.Log("Booking Confirmed Successfully");
            confirmText.gameObject.SetActive(true);
            confirmText.text = "Booking Confirmed Successfully...";
            confirmText.color = Color.green;
            StartCoroutine(DestroyAnim());
            yield return new WaitForSecondsRealtime(2);
            SceneManager.LoadScene(PlayerPrefs.GetString("PreviousScene"));
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

    IEnumerator ManagerBooking()
    {
        WWWForm form = new WWWForm();                   //Create a form
        form.AddField("deskID", PlayerPrefs.GetString("DeskName"));          //Using the post method make sure 1st parameter same in php
        form.AddField("managerID", PlayerPrefs.GetString("Username"));
        form.AddField("staffID", userDropdown.captionText.text);
        form.AddField("adminID", "NULL");
        form.AddField("date", dateDropdown.captionText.text);
        form.AddField("startTime", startDropdown.captionText.text);
        //form.AddField("endTime", endDropdown.captionText.text);
        TimeSpan startTime = new TimeSpan(Int32.Parse(startDropdown.captionText.text.Substring(0, 2)), Int32.Parse(startDropdown.captionText.text.Substring(3, 2)), 00);
        TimeSpan durationTime = new TimeSpan(Int32.Parse(durationDropdown.captionText.text.Substring(0, 2)), Int32.Parse(durationDropdown.captionText.text.Substring(3, 2)), 00);
        TimeSpan endTime = startTime.Add(durationTime);
        form.AddField("endTime", endTime.ToString());
        form.AddField("booking_duration", (durationDropdown.captionText.text + ":00"));
        Debug.Log(durationDropdown.captionText.text + ":00");

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
        CallUserSelected();
    }

    IEnumerator AdminBooking()
    {
        WWWForm form = new WWWForm();                   //Create a form
        form.AddField("deskID", PlayerPrefs.GetString("DeskName"));          //Using the post method make sure 1st parameter same in php
        form.AddField("managerID", "NULL");
        form.AddField("staffID", userDropdown.captionText.text);
        form.AddField("adminID", PlayerPrefs.GetString("Username"));
        form.AddField("date", dateDropdown.captionText.text);
        form.AddField("startTime", startDropdown.captionText.text);
        //form.AddField("endTime", endDropdown.captionText.text);
        TimeSpan startTime = new TimeSpan(Int32.Parse(startDropdown.captionText.text.Substring(0, 2)), Int32.Parse(startDropdown.captionText.text.Substring(3, 2)), 00);
        TimeSpan durationTime = new TimeSpan(Int32.Parse(durationDropdown.captionText.text.Substring(0, 2)), Int32.Parse(durationDropdown.captionText.text.Substring(3, 2)), 00);
        TimeSpan endTime = startTime.Add(durationTime);
        form.AddField("endTime", endTime.ToString());
        form.AddField("booking_duration", (durationDropdown.captionText.text + ":00"));
        Debug.Log(durationDropdown.captionText.text + ":00");

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
        CallUserSelected();
    }

    IEnumerator FillAvaTimes()
    {
        WWWForm form = new WWWForm();
        form.AddField("date", dateDropdown.captionText.text);
        form.AddField("deskID", PlayerPrefs.GetString("DeskName"));          //Using the post method make sure 1st parameter same in php
        form.AddField("booking_duration", durationDropdown.captionText.text +":00");
        form.AddField("startTime", startDropdown.captionText.text);

        wwwBooking = new WWW(bookingAltURL, form);

        yield return wwwBooking;
        debugText.text = wwwBooking.text;
        TimesInArray();
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
        //endMinutesString = endDropdown.captionText.text.Substring(3, 2);
        //endHours = Int32.Parse(endHoursString);
        //endMinutes = Int32.Parse(endMinutesString);

    }

    public void FillStartDropdown()
    {
        TimeSpan defaultStart = new TimeSpan(07, 00, 00);
        TimeSpan _30mins = new TimeSpan(00, 30, 00);
        List<String> list = new List<String>();
        Dropdown.OptionData dropdownObjects = new Dropdown.OptionData();
        for (int i = 0; i < 24; i++)
        {
            defaultStart = defaultStart.Add(_30mins);
            dropdownObjects.text = defaultStart.ToString();
            list.Add(dropdownObjects.text);
        }
        startDropdown.AddOptions(list);
    }

    public void TimesInArray()
    {
        startDropdown.ClearOptions();
        List<String> list = new List<String>();
        Dropdown.OptionData dropdownObjects = new Dropdown.OptionData();
        string availableTimes = wwwBooking.text;
        string[] availableTimesArray = availableTimes.Split('|');
        for (int i = 0; i < availableTimesArray.Length-1; i++)
        {
            list.Add(availableTimesArray[i]);
            //Debug.Log(availableTimesArray[i]);
        }
        startDropdown.AddOptions(list);
    }

    public void FillStartDropdownAlt()
    {
        TimeSpan defaultStart = new TimeSpan(07, 00, 00);
        TimeSpan _30mins = new TimeSpan(00, 30, 00);
        List<String> list = new List<String>();
        Dropdown.OptionData dropdownObjects = new Dropdown.OptionData();
        for (int i = 0; i < 24; i++)
        {
            //defaultStart = defaultStart.Add(_30mins);
            //dropdownObjects.text = defaultStart.ToString();
            //list.Add(dropdownObjects.text);

        }
        startDropdown.AddOptions(list);
    }

    public void FillDateDropdown()
    {
        currentDate = DateTime.Now;
        currentDate = currentDate.AddDays(1);
        dateDropdown.ClearOptions();
        //DateTime _30Days = new DateTime(0000,0,30);
        List<String> list = new List<String>();
        Dropdown.OptionData dropdownObjects = new Dropdown.OptionData();
        if (PlayerPrefs.GetString("Username").Substring(0, 3) != "STA")
        {
            if (userDropdown.captionText.text.Substring(0,3) == "MAN")
            {
                for (int i = 0; i < 30; i++)
                {
                    dropdownObjects.text = currentDate.ToString("yyyy-MM-dd").Substring(0, 10);
                    list.Add(dropdownObjects.text);
                    currentDate = currentDate.AddDays(1).Date;
                }
            }
            if (userDropdown.captionText.text.Substring(0, 3) == "ADM")
            {
                for (int i = 0; i < 90; i++)
                {
                    dropdownObjects.text = currentDate.ToString("yyyy-MM-dd").Substring(0, 10);
                    list.Add(dropdownObjects.text);
                    currentDate = currentDate.AddDays(1).Date;
                }
            }
            else
            {
                for (int i = 0; i < 90; i++)
                {
                    dropdownObjects.text = currentDate.ToString("yyyy-MM-dd").Substring(0, 10);
                    list.Add(dropdownObjects.text);
                    currentDate = currentDate.AddDays(1).Date;
                }
            }
        }
        else
        {
            for (int i = 0; i < 30; i++)
            {

                dropdownObjects.text = currentDate.ToString("yyyy-MM-dd").Substring(0, 10);
                list.Add(dropdownObjects.text);
                currentDate = currentDate.AddDays(1).Date;
            }
        }
        dateDropdown.AddOptions(list);
    }

    IEnumerator UserSelected()
    {
        userDropdown.ClearOptions();
        WWWForm form = new WWWForm();
        form.AddField("user", PlayerPrefs.GetString("Username"));

        WWW www = new WWW(fillUsersURL, form);

        yield return www;
        listOfUsers = new List<String>();
        Dropdown.OptionData dropdownObjects = new Dropdown.OptionData();
        string staff = www.text;
        staffArray = staff.Split('|');
        debugText.text = www.text;
        for (int i = 0; i < staffArray.Length - 1; i++)
        {
            listOfUsers.Add(staffArray[i]);
            Debug.Log(staffArray[i]);
        }
        if (PlayerPrefs.GetString("Username").Substring(0, 3) == "MAN")   //Checks if user logged in is Manager
        {
            userDropdown.AddOptions(listOfUsers);
            if (PlayerPrefs.GetString("Username").Substring(0, 3) != "STA")
            {
                if (staffArray.Length != 0)
                {
                    FillDateDropdown();
                    StartCoroutine(FillAvaTimes());
                }
            }
            //FillUserSpecifitDates();
        }
        else if (PlayerPrefs.GetString("Username").Substring(0, 3) == "ADM")   //Checks if user logged in is Manager
        {
            userDropdown.AddOptions(listOfUsers);
            if (PlayerPrefs.GetString("Username").Substring(0, 3) != "STA")
            {
                if (staffArray.Length != 0)
                {
                    FillDateDropdown();
                    StartCoroutine(FillAvaTimes());
                }
            }
            //FillUserSpecifitDates();
        }
    }

    IEnumerator DestroyAnim()
    {
        yield return new WaitForSeconds(2);
        confirmText.gameObject.SetActive(false);
    }
}
