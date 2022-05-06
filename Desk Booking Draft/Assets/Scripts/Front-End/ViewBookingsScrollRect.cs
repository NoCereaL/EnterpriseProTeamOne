using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ViewBookingsScrollRect : MonoBehaviour
{
    [HideInInspector] ScrollRect scrollRect;
    [SerializeField] RectTransform scrollContent;
    [SerializeField] VerticalLayoutGroup layoutGroup;
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
        if (scrollContent.anchoredPosition.y >= layoutGroup.minHeight)
        {
            scrollContent.anchoredPosition = new Vector3(0, (layoutGroup.minHeight - 300f) , scrollContent.position.z);
        }
        else if (scrollRect.verticalScrollbar.value == 0)
        {
            scrollRect.movementType = ScrollRect.MovementType.Unrestricted;
        }
    }
}
