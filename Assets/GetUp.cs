using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetUp : MonoBehaviour


{


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 position = transform.position;

        if (Input.GetMouseButtonDown(0))

        {

            position.y += 0.2f;
            transform.position = position;
            //max. -195y
          
        }

        if (position.y > -195)
        {
            position.y -= 0.2f;
            transform.position = position;
        }

      
}
}