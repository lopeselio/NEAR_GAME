using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBall : MonoBehaviour
{
    public float speed = 1.0f;
    // public Vector3 speed;
    // Start is called before the first frame update
    void Start()
    {
       Debug.Log("Calling start method"); 
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 userinput = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);
        Debug.Log(userinput);
        transform.position = transform.position + userinput * speed * Time.deltaTime;
    }
}
