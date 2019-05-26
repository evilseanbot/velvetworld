using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RopeGrow : MonoBehaviour
{
    public Obi.ObiDistanceConstraints distance;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //distance.stretchingScale += 0.01f;
        transform.localScale = new Vector3(transform.localScale.x + 0.1f, transform.localScale.y, transform.localScale.z);
    }
}
