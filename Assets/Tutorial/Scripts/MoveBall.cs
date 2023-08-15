using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBall : MonoBehaviour
{
    public float speedx = 0.01f;
    // Start is called before the first frame update
    void Start()
    {
       Debug.Log("Calling start method"); 
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + new Vector3(speedx, 0.01f, 0);
    }
}
