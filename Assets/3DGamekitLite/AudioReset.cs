using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioReset : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<AudioListener>().enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
