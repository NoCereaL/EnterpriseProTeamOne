using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RegistrationSQLHandler : MonoBehaviour
{
    private string registrationURL = "https://moyanask.com/EPTeam1/register.php";
    [SerializeField] Dropdown usertypeDropdown;
    [SerializeField] GameObject staffCanvas;
    [SerializeField] GameObject managerCanvas;
    [SerializeField] GameObject statusText;

    //Input Fields
    [SerializeField] InputField managerUsername;
    [SerializeField] InputField staffUsername;
    [SerializeField] InputField managerPassword;
    [SerializeField] InputField staffPassword;
    [SerializeField] InputField staffManager;

    [SerializeField] InputField staffConfirmPass;
    [SerializeField] InputField managerConfirmPass;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    //Call Methods
    public void CallRegister()
    {
        if (usertypeDropdown.captionText.text == "STAFF")
        {
            if (staffPassword.text == staffConfirmPass.text)
            {
                StartCoroutine(Register());
            }
            else
            {
                statusText.SetActive(true);
                statusText.GetComponent<Text>().text = "Please Check Password!";
                statusText.GetComponent<Text>().color = Color.red;
                StartCoroutine(DestroyStatusText());
            }
        }
        if (usertypeDropdown.captionText.text == "MANAGER")
        {
            if (managerPassword.text == managerConfirmPass.text)
            {
                StartCoroutine(Register());
            }
            else
            {
                statusText.SetActive(true);
                statusText.GetComponent<Text>().text = "Please Check Password!";
                statusText.GetComponent<Text>().color = Color.red;
                StartCoroutine(DestroyStatusText());
            }
        }        
    }

    //On Value Change Methods
    public void ChangeUsertype()
    {
        if(usertypeDropdown.captionText.text == "STAFF")
        {
            staffCanvas.SetActive(true);
            managerCanvas.SetActive(false);
        }
        else if(usertypeDropdown.captionText.text == "MANAGER")
        {
            staffCanvas.SetActive(false);
            managerCanvas.SetActive(true);
        }
    }

    IEnumerator DestroyStatusText()
    {
        yield return new WaitForSecondsRealtime(1);
        statusText.SetActive(false);
    }

    IEnumerator Register()
    {
        WWWForm form = new WWWForm();

        form.AddField("managerID", managerUsername.text);
        form.AddField("staffID", staffUsername.text);
        form.AddField("staffPassword", staffPassword.text);
        form.AddField("managerPassword", managerPassword.text);
        form.AddField("staffManager", staffManager.text);
        form.AddField("role", usertypeDropdown.captionText.text);

        WWW www = new WWW(registrationURL, form);
        yield return www;
        Debug.Log(www.text);
        if(www.text == "Approved")
        {
            statusText.SetActive(true);
            statusText.GetComponent<Text>().text = "Registered Successfull!";
            statusText.GetComponent<Text>().color = Color.green;          
        }
        else
        {
            statusText.SetActive(true);
            statusText.GetComponent<Text>().text = "Unsuccessfull! - Result: " +www.text;
            statusText.GetComponent<Text>().color = Color.red;
        }
        yield return new WaitForSecondsRealtime(2);
        statusText.SetActive(false);
    }
}
