using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class surfaceSpawn : MonoBehaviour
{
    public GameObject surface;
    public float spawnRateSurface = 4;
    private float timerSurface = 0;
    public float heightOffsetSurface = 5;
 
    public GameObject satellite;
    public float spawnRateSatellite = 12;
    private float timerSatellite = 0;
    public float heightOffsetSatellite = 0;
    public float minimumHeightOffsetSatellite = 20;
    // Start is called before the first frame update
    void Start()
    {
        spawnSurface();
        spawnSatellite();
    }
 
    // Update is called once per frame
    void Update()
    {
        if (timerSurface < spawnRateSurface)
        {
            timerSurface = timerSurface + Time.deltaTime;
        }
        else
        {
            spawnSurface(); 
            timerSurface = 0;
        }

        if (timerSatellite < spawnRateSatellite)
        {
            timerSatellite = timerSatellite + Time.deltaTime;
        }
        else
        {
            spawnSatellite(); 
            timerSatellite = 0;
        }
 
    }
 
    void spawnSurface()
    {
        float lowestPoint = transform.position.y - heightOffsetSurface;
        float highestPoint = transform.position.y + heightOffsetSurface;
 
       // Instantiate(surface, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0), transform.rotation);
        Instantiate(surface, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0), transform.rotation = new Quaternion(0f,0f,0f,0f)).transform.localScale = new Vector3(Random.Range(1f,2f), Random.Range(1f,2f), Random.Range(1f,2f));
    }

        void spawnSatellite()
    {
        float lowestPoint = transform.position.y + minimumHeightOffsetSatellite - heightOffsetSatellite;
        float highestPoint = transform.position.y + minimumHeightOffsetSatellite + heightOffsetSatellite;
 
       // Instantiate(surface, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0), transform.rotation);
        Instantiate(satellite, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0), transform.rotation = new Quaternion(0f,0f,Random.Range(0f,360f),Random.Range(0f,360f))).transform.localScale = new Vector3(Random.Range(0.8f,1f), Random.Range(0.8f,1f), Random.Range(0.8f,1f));
    }
}
