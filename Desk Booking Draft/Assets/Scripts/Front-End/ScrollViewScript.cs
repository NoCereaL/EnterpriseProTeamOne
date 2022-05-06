using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScrollViewScript : MonoBehaviour
{
    [HideInInspector] ScrollRect scrollRect;
    [SerializeField] RectTransform scrollContent;
    [SerializeField] GameObject endOject;
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
