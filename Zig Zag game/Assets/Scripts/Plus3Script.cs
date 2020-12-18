using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plus3Script : MonoBehaviour

{

    public float seconds;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        seconds = seconds-Time.deltaTime;
        if (seconds < 0)
        Destroy(gameObject);
    }
}
