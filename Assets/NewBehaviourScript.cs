using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject gb;
    public Rigidbody rb;

    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Cube")
        {
            Destroy(gb);
            Pendulum.unghi = 60;
            Pendulum.viteza = 6;
            rb.useGravity = true;
        }

    }
}
