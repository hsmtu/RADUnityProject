using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class physicsScript : MonoBehaviour
{
    Rigidbody ourRigidbody;
    // Start is called before the first frame update
    void Start()
    {
        ourRigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            ourRigidbody.AddExplosionForce(300,
                transform.position + Vector3.down + Vector3.back, 3);


        }

    }

    private void OnCollisionEnter(Collision collision)
    {
        print("Ouch");

        plainscript planeHit = collision.gameObject.GetComponent<plainscript>();

        if (planeHit)
        {
            print("I hit a plane");
            planeHit.processHits();



        }

    }
}
