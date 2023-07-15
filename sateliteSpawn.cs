using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sateliteSpawn : MonoBehaviour
{
    public GameObject  satelite;
    public float spawnRate = 2;
    private float timer = 0;
    public float heightOffset = 5;
 
    // Start is called before the first frame update
    void Start()
    {
        spawnSatelite();
    }
 
    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            timer = timer + Time.deltaTime;
        }
        else
        {
            spawnSatelite(); 
            timer = 0;
        }
 
    }
 
    void spawnSatelite()
    {
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;
 
       // Instantiate(surface, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0), transform.rotation);
        Instantiate(satelite, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0), transform.rotation = Quaternion.Euler(0, 0, Random.Range(0,360))).transform.localScale = new Vector3(Random.Range(0.25f,1.5f), Random.Range(0.25f,1.5f), Random.Range(0.25f,1.5f));
        
    }
}
