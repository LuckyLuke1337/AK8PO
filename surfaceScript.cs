using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class surfaceScript : MonoBehaviour
{
    public float sateliteMoveSpeed = 5;
    public float deadZone = -50;
 
    // Start is called before the first frame update 
    void Start()
    {
        
    }
 
    // Update is called once per frame
    void Update()
    {   

        transform.position = transform.position + (Vector3.left * sateliteMoveSpeed) * Time.deltaTime;

        if (transform.position.x < deadZone && gameObject != null)
            {
                Destroy(gameObject);
            }
   
    }
}
