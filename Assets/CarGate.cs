using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarGate : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        Debug.Log("Collision");
        if(other.gameObject.tag == "Car")
        {

            Debug.Log("Car");
            Destroy(gameObject);
        }
    }
}
