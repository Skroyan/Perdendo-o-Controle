using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColisorPos : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //transform.localPosition = new Vector3(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        //if (transform.parent.position != transform.position)
        //{
        //    transform.parent.position = transform.position;
        //}
        //transform.localPosition = Vector3.zero;
    }

    void Example()
    {
        // Get the y component of the position relative to the parent
        // and print it to the Console
        //print(transform.localPosition.y);
    }
}
