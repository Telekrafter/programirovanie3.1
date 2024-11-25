using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class golem_move : MonoBehaviour
{
    public int speed_golem;
    public Animator myAnim;
    // Start is called before the first frame update
    void Start()
    {
        speed_golem = Random.Range(3,10);
        myAnim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward*Time.deltaTime*speed_golem);
        if (speed_golem > 5)
        {
            myAnim.Play("Giant@Run01 - Forward");
        }
        Debug.Log(speed_golem);
    }
}
