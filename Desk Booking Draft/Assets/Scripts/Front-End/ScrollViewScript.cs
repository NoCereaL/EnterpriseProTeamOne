using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScrollViewScript : MonoBehaviour
{
    [HideInInspector] ScrollRect scrollRect;
    [SerializeField] RectTransform scrollContent;
    public float pos;
    public GameObject minPos;
    public float testPos;
    [SerializeField] GameObject endOject;
    private Vector3 startPos;
    // Start is called before the first frame update
    void Start()
    {
        scrollRect = this.gameObject.GetComponent<ScrollRect>();
    }

    // Update is called once per frame
    void Update()
    {
        RestrictScrolling();
    }

    public void RestrictScrolling()
    {
        pos = scrollRect.verticalScrollbar.value;
        testPos = minPos.GetComponent<RectTransform>().anchoredPosition.y;
        if (scrollRect.verticalScrollbar.value == 1)
        {
            scrollRect.movementType = ScrollRect.MovementType.Elastic;
        }
        if (scrollContent.anchoredPosition.y >= 1000)
        {
            scrollContent.anchoredPosition = new Vector3(0, -endOject.GetComponent<RectTransform>().localPosition.y, scrollContent.position.z);
        }
        else if (scrollRect.verticalScrollbar.value == 0)
        {
            scrollRect.movementType = ScrollRect.MovementType.Unrestricted;
        }
    }
}
