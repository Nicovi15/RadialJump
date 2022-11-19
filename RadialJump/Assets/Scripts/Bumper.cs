using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bumper : TileEffect
{
    public float bumpForce = 50f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.GetComponent<Rigidbody>().AddForce(transform.up * bumpForce, ForceMode.Impulse);
            //collision.gameObject.AddComponent<Bumper>();
        }
    }
}