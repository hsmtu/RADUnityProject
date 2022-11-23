using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plainscript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame

    internal void  processHits()
    {
        
        transform.Rotate(Vector3.right, -10);

    }
}
