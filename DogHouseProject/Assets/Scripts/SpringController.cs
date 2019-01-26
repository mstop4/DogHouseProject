using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpringController : MonoBehaviour
{
    public float speed = -1.0f;
    public Transform anchor;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float distanceToAnchor = Vector3.Distance(anchor.position, transform.position);
        if (Input.GetKey("space")){
            if (distanceToAnchor > 0.5)
            {
                transform.position = transform.position + transform.up * speed;
            }
        }
    }
}
