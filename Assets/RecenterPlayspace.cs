using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecenterPlayspace : MonoBehaviour
{
    public GameObject head;
    public GameObject pillow;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            transform.rotation = Quaternion.Euler(0, pillow.transform.eulerAngles.y - (head.transform.localRotation.eulerAngles.y), 0);

            transform.position = (pillow.transform.position - (transform.rotation * head.transform.localPosition));
            transform.position = new Vector3(transform.position.x, 0, transform.position.z);
            //transform.rotation = (pillow.transform.rotation *  (Quaternion.Inverse(head.transform.rotation)));
        }
    }
}
