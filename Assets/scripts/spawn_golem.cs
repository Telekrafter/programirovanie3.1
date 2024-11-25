using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn_golem : MonoBehaviour
{
   public GameObject[] golems;
    private int index;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn", 0, 4);
        



    }
    void Spawn()
    {
        index = Random.Range(0,golems.Length);
        Vector3 position = new Vector3(Random.Range(-23, 0), 10, Random.Range(160, 175));
        Quaternion rotation = Quaternion.Euler(0, Random.Range(150,190), 0);
        Instantiate(golems[index], position, rotation);
    }
}
