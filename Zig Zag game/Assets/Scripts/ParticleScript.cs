using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleScript : MonoBehaviour
{

    //private ParticleSystem ps;

    private PlayerScript Player;

    // Start is called before the first frame update
    void Start()
    {
        //ps = GetComponent<ParticleSystem>();

        Player = FindObjectOfType <PlayerScript>();
    }   

    // Update is called once per frame
    void Update()
    {
        //if (!ps.isPlaying)
        {
            //Destroy(gameObject);
        }
    }
}
