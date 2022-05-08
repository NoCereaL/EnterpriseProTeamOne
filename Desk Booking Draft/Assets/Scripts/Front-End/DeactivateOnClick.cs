using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeactivateOnClick : MonoBehaviour
{
    private Button button;
    // Start is called before the first frame update
    void Start()
    {
        button = this.gameObject.GetComponent<Button>();
    }

    public void CallDeactivateButton()
    {
        StartCoroutine(DeactivateButton());
    }

    IEnumerator DeactivateButton()
    {
        button.interactable = false;
        yield return new WaitForSecondsRealtime(3);
        button.interactable = true;
    }
}
