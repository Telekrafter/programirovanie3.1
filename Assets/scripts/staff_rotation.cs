using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class staff_rotation : MonoBehaviour
{
    private float horisontal;
    private float vertical;
    public GameObject meteor;
    public Transform point;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Attak();
        horisontal = Input.GetAxis("Mouse X");
        vertical = Input.GetAxis("Mouse Y");
        transform.Rotate(-horisontal, 0, vertical);
    }
    void Attak()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(meteor, point.position,transform.rotation);


        }


    }
}
