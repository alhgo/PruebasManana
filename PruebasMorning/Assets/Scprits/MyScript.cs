using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyScript : MonoBehaviour
{

    Vector3 miVector = new Vector3();

    // Start is called before the first frame update
    void Start()
    {

        miVector.x = 10f;
        miVector.y = 10f;
        miVector.z = 10f;

        print(miVector);

        transform.position = miVector;


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
