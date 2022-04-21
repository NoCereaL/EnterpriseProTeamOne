using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeskInteraction : MonoBehaviour
{

    [SerializeField] GameObject dateObject;
    [SerializeField] GameObject startTimeObject;
    [SerializeField] GameObject endTimeObject;
    RaycastHit hit;

    string bookingLimitationURL = "https://moyanask.com/EPTeam1/bookingLimitation.php";
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame    
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            
            if (Physics.Raycast(ray, out hit))
            {
                Debug.Log(hit.transform.name + " Selected");
                //Select stage    
                if (hit.transform.name == transform.name)
                {
                    if (PlayerPrefs.GetString("Username").Substring(0, 3) == "MAN")   //Checks if user logged in is Manager
                    {
                        SceneManager.LoadScene("Manager");
                    }
                    else if (PlayerPrefs.GetString("Username").Substring(0, 3) == "ADM")   //Checks if user logged in is Manager
                    {
                        SceneManager.LoadScene("AdminBooking");
                    }
                    else
                    { 
                        StartCoroutine(CheckPreviousBooking());
                    }
                    PlayerPrefs.SetString("DeskName", hit.transform.name);
                    Debug.Log("Desk Name Set To: " + hit.transform.name);
                }
            }
        }
    }

    IEnumerator CheckPreviousBooking()
    {

        WWWForm form = new WWWForm();

        form.AddField("user", PlayerPrefs.GetString("Username"));

        WWW www = new WWW(bookingLimitationURL, form);

        yield return www ;

        if(www.text == "Approved")
        {
            if (hit.transform.gameObject.tag == "Desk")
            {
                SceneManager.LoadScene("Booking");
            }
        }
        else if(www.text == "Denied")
        {
            if (hit.transform.gameObject.tag == "Desk")
            {
                GameObject popup = RoomInstance.Instance.popup;
                GameObject room = RoomInstance.Instance.room;

                popup.SetActive(true);
                room.SetActive(false);
            }
        }
    }
}

