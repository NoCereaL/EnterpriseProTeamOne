using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DeskNameScript : MonoBehaviour
{
    public GameObject desk;
    // Start is called before the first frame update
    void Start()
    {
        this.gameObject.GetComponent<TextMeshPro>().text = desk.name;
    }
}
