using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballInstantiate : MonoBehaviour
{
    public GameObject ball1;
    public GameObject ball2;
    Vector3 spawn1 = new Vector3 (-21, 8, 13);
    Vector3 spawn2 = new Vector3(-23, 8, 13);

    // Start is called before the first frame update
    void Start()
    {
        ball1.transform.position = spawn1;
        ball2.transform.position = spawn2;

        for (int i=0; i<3; i++)
        {
            Instantiate(ball1);
            Instantiate(ball2);
        }
      
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
