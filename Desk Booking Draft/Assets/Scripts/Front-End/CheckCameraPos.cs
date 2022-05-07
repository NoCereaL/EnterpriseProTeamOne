using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckCameraPos : MonoBehaviour
{
    [SerializeField] float xBoarderPos;
    [SerializeField] float zBoarderPos;
    Vector3 startPos;
    // Start is called before the first frame update
    void Start()
    {
        startPos = this.gameObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        CheckCamera();
    }

    public void CheckCamera()
    {
        Vector3 currentPos = this.gameObject.transform.position;
        if(currentPos.x >= xBoarderPos)     //Check Camera has passed positive x value
        {
            this.gameObject.transform.position = Vector3.Lerp(currentPos, new Vector3(this.gameObject.transform.position.x - 10, this.gameObject.transform.position.y, this.gameObject.transform.position.z), 0.1f);
        }
        else if(currentPos.x <= -xBoarderPos)       //Check Camera has passed negatice x value
        {
            this.gameObject.transform.position = Vector3.Lerp(currentPos, new Vector3(this.gameObject.transform.position.x + 10, this.gameObject.transform.position.y, this.gameObject.transform.position.z), 0.1f);
        }
        if (currentPos.z >= zBoarderPos)
        {
            //this.gameObject.transform.position = new Vector3(this.gameObject.transform.position.x, this.gameObject.transform.position.y, this.gameObject.transform.position.z - 50);
            this.gameObject.transform.position = Vector3.Lerp(currentPos, new Vector3(this.gameObject.transform.position.x, this.gameObject.transform.position.y, this.gameObject.transform.position.z - 10),0.1f);
        }
        else if (currentPos.z <= -zBoarderPos)
        {
            //this.gameObject.transform.position = new Vector3(this.gameObject.transform.position.x, this.gameObject.transform.position.y, this.gameObject.transform.position.z + 50);
            this.gameObject.transform.position = Vector3.Lerp(currentPos, new Vector3(this.gameObject.transform.position.x, this.gameObject.transform.position.y, this.gameObject.transform.position.z + 10), 0.1f);

        }
    }
}
