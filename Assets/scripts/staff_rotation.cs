using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class staff_rotation : MonoBehaviour
{
    private float horisontal;
    private float vertical;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horisontal = Input.GetAxis("Mouse X");
        vertical = Input.GetAxis("Mouse Y");
        transform.Rotate(-horisontal, 0, vertical);
    }
}
