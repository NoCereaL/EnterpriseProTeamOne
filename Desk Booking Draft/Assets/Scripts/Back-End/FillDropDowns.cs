using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class FillDropDowns : MonoBehaviour
{
    [SerializeField] Dropdown startDropdown;
    [SerializeField] Dropdown endDropdown;
    [SerializeField] Dropdown durationDropdown;
    TimeSpan startTime;
    TimeSpan endTime;
    TimeSpan lastTime;

    // Start is called before the first frame update
    void Start()
    {
        FillStartDropdown();
        lastTime = new TimeSpan(17, 00, 00);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void FillStartDropdown()
    {
        startDropdown.ClearOptions();
        TimeSpan defaultStart = new TimeSpan(06, 30, 00);
        TimeSpan _30mins = new TimeSpan(00, 30, 00);
        List<String> list = new List<String>();
        Dropdown.OptionData dropdownObjects = new Dropdown.OptionData();
        for (int i = 0; i < 24; i++)
        {
            defaultStart = defaultStart.Add(_30mins);
            dropdownObjects.text = defaultStart.ToString();
            list.Add(dropdownObjects.text);
        }
        try { startDropdown.AddOptions(list); } catch { };
    }

    public void FillEndDropdown()
    {
        int index;
        startTime = new TimeSpan(Int32.Parse(startDropdown.captionText.text.Substring(0, 2)), Int32.Parse(startDropdown.captionText.text.Substring(3, 2)), 00);
        endDropdown.ClearOptions();
        TimeSpan defaultStart = startTime;
        TimeSpan _30mins = new TimeSpan(00, 30, 00);
        List<String> list = new List<String>();
        Dropdown.OptionData dropdownObjects = new Dropdown.OptionData();
        switch (startTime.ToString())
        {
            case "17:30:00":
                index = 3;
                break;
            case "18:00:00":
                index = 2;
                break;
            case "18:30:00":
                index = 1;
                break;
            default:
                index = 4;
                break;                               
        }
        for (int i = 0; i < index; i++)
        {
            defaultStart = defaultStart.Add(_30mins);
            dropdownObjects.text = defaultStart.ToString();
            list.Add(dropdownObjects.text);
        }
        try { endDropdown.AddOptions(list); } catch { };
    }

    public void FillDurationDropdown()
    {
        string[] durationTimes = { "00:30", "01:00", "01:30", "02:00" };
        int index;
        startTime = new TimeSpan(Int32.Parse(startDropdown.captionText.text.Substring(0, 2)), Int32.Parse(startDropdown.captionText.text.Substring(3, 2)), 00);
        List<String> list = new List<String>();
        Dropdown.OptionData dropdownObjects = new Dropdown.OptionData();
        switch (startTime.ToString())
        {
            case "17:30:00":
                index = 3;
                break;
            case "18:00:00":
                index = 2;
                break;
            case "18:30:00":
                index = 1;
                break;
            default:
                index = 4;
                break;
        }
        for (int i = 0; i < index; i++)
        {
            dropdownObjects.text = durationTimes[i];
            list.Add(dropdownObjects.text);
            Debug.Log(startTime);
        }
        durationDropdown.ClearOptions();
        durationDropdown.AddOptions(list); 
    }

}
