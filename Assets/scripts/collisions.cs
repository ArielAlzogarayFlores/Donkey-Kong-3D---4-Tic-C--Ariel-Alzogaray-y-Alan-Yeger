using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisions : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.name == "ball1(Clone)" && col.gameObject.name == "ball2(Clone)")
        {
            transform.position = new Vector3(0, 0.5f, 12.7f);
        }
    }
}
