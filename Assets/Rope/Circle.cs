using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circle : MonoBehaviour
{
    public float offset;
    
    // Update is called once per frame
    void Update()
    {
        transform.localPosition = new Vector3(Mathf.Sin(Time.time+offset)/2f, 0, Mathf.Cos(Time.time+offset)/2f);
    }
}
