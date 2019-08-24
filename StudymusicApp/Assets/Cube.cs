using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("I am in Start() method.");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("I am in update() method.");
        gameObject.transform.Translate(0.01f, 0.01f, 0.01f);
    }
}
