using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAt : MonoBehaviour
{
    public Transform targetToLookAt;

    private void Start()
    {
        if(targetToLookAt == null)
            targetToLookAt = FindObjectOfType<CharacterController>().transform;
        
    }
    private void Update()
    {
        if(targetToLookAt != null)
            this.transform.LookAt(targetToLookAt);
    }
}
