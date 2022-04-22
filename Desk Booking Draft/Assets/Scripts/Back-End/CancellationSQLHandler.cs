using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CancellationSQLHandler : MonoBehaviour
{
    [HideInInspector] GameObject deskText;
    [HideInInspector] GameObject staffBookedText;
    [HideInInspector] GameObject managerBookedText;
    [HideInInspector] GameObject adminBookedText;
    [HideInInspector] GameObject startTimeText;
    [HideInInspector] GameObject durationText;
    [SerializeField] GameObject mainCanvas;
    [HideInInspector] GameObject statusText;


    [SerializeField] VerticalLayoutGroup verticalLayout;
    [SerializeField] Text debugText;
    [SerializeField] GameObject bookingSelection;
    [SerializeField] Transform contentBox;

    [SerializeField] GameObject cancelCanvas;

    private string bookingSelectionURL = "https://moyanask.com/EPTeam1/getuserbookings.php";
    private string cancellationURL = "https://moyanask.com/EPTeam1/cancellation.php";

    // Start is called before the first frame update
    void Start()
    {
        deskText = GameObject.Find("DeskNameTwo");
        staffBookedText = GameObject.Find("StaffBookedText");
        managerBookedText = GameObject.Find("ManagerBookedText");
        adminBookedText = GameObject.Find("AdminBookedText");
        startTimeText = GameObject.Find("StartTimeText");
        durationText = GameObject.Find("DurationText");
        statusText = GameObject.Find("StatusText");

        CallBookingSelections();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Call Methods
    public void CallBookingSelections()
    {
        StartCoroutine(BookingSelections());
    }

    public void CallCancelBooking()
    {
        StartCoroutine(CancelBooking());
    }


    //On Click Methods
    public void BackButton()
    {
        GameObject newMainCanvas = Instantiate(mainCanvas, null);
        CancellationInstance.Instance.mainCanvas = newMainCanvas;
    }

    IEnumerator BookingSelections()
    {
        WWWForm form = new WWWForm();

        form.AddField("user", PlayerPrefs.GetString("Username"));

        WWW www = new WWW(bookingSelectionURL, form);

        yield return www;

        string bookings = www.text;
        string[] bbookingsArray = bookings.Split('\n');
        debugText.text = www.text;
        //Debug.Log(www.text);

        for (int i = 0; i <= bbookingsArray.Length - 2; i++)
        {
            debugText.text = bbookingsArray[i];
            GameObject booking = Instantiate(bookingSelection, Vector3.zero, Quaternion.Euler(Vector3.zero), contentBox);
            booking.GetComponentsInChildren<Text>()[0].text = bbookingsArray[i];

            Debug.Log(bbookingsArray[i]);
        }
    }

    IEnumerator CancelBooking()
    {
        WWWForm form = new WWWForm();

        form.AddField("bookingID", PlayerPrefs.GetString("BookingID"));

        WWW www = new WWW(cancellationURL, form);

        yield return www;
        if(www.text == "Success")
        {
            statusText.SetActive(true);
            statusText.GetComponent<Text>().text = "Booking Canceled Successfully!";
            statusText.GetComponent<Text>().color = Color.green;
            yield return new WaitForSecondsRealtime(1);
            statusText.SetActive(false);
            GameObject newMainCanvas = Instantiate(mainCanvas, null);
            CancellationInstance.Instance.mainCanvas = newMainCanvas;
        }
        if(www.text == "-1")
        {
            statusText.SetActive(true);
            statusText.GetComponent<Text>().text = "Failed To Cancel Booking!";
            statusText.GetComponent<Text>().color = Color.red;
            yield return new WaitForSecondsRealtime(4);
            statusText.SetActive(false);
        }
        else if(www.text == "-2"){
            statusText.SetActive(true);
            statusText.GetComponent<Text>().text = "Check Connection...";
            statusText.GetComponent<Text>().color = Color.red;
            yield return new WaitForSecondsRealtime(4);
            statusText.SetActive(false);
        }
    }
}
