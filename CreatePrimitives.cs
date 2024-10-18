using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CreatePrimitives : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        createPrimitive(0, 0, 0);
        createPrimitive(-0.5f, 1, 0);
        createPrimitive(0.5f, 1, 0);
        createPrimitive(0.5f, 2, 0);
        createPrimitive(-0.5f, 2, 0);
        createPrimitive(0, 3, 0);
    }

    // This function will create primitive based on coordinates
    void createPrimitive(float x, float y, float z)
    {
        GameObject.CreatePrimitive(PrimitiveType.Cube).transform.position = new Vector3(x, y, z);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
