using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using static UnityEngine.GraphicsBuffer;

public class AnimalSpawn : MonoBehaviour
{
    
    public GameObject animalPrefab = default;
    public GameObject other1 = default;
    public GameObject other2 = default;
    public GameObject other3 = default;
    public GameObject other4 = default;
    public GameObject other5 = default;
    public GameObject other6 = default;

    private float surviveTime = default;
    private float surviveTimeMax = default;





    public float spawnerRateMin = 0.0f;
    public float spawnerRateMax = 1.0f;


    private int randomNumber = default;

    private float spawnerRate = default;
    private float timeAfterSpawner = default;

    // Start is called before the first frame update
    void Start()
    {
        
        timeAfterSpawner = 0f;
        spawnerRate = Random.Range(spawnerRateMin, spawnerRateMax);
        randomNumber = Random.Range(1, 8);
        surviveTime = 0f;
        surviveTimeMax = 10f;

    }

    // Update is called once per frame
    void Update()
    {
        surviveTime += Time.deltaTime;

        if (surviveTime >= surviveTimeMax)
        {
            surviveTime = 0f;
            GameObject animal = Instantiate(other6, transform.position, transform.rotation);
        }

        
        timeAfterSpawner += Time.deltaTime;

        if (timeAfterSpawner >= spawnerRate)
        {
            randomNumber = Random.Range(1, 7);
            timeAfterSpawner = 0f;

            if(randomNumber == 1)
            {
            GameObject animal = Instantiate(animalPrefab, transform.position, transform.rotation);

            }
            else if(randomNumber == 2)
            {
                GameObject animal = Instantiate(other1, transform.position, transform.rotation);

            }
            else if (randomNumber == 3)
            {
                GameObject animal = Instantiate(other2, transform.position, transform.rotation);

            }

            else if (randomNumber == 4)
            {
                GameObject animal = Instantiate(other3, transform.position, transform.rotation);

            }

            else if (randomNumber == 5)
            {
                GameObject animal = Instantiate(other4, transform.position, transform.rotation);

            }
            else if (randomNumber == 5)
            {
                GameObject animal = Instantiate(other5, transform.position, transform.rotation);

            }



            //bullet.transform.LookAt(target);

            spawnerRate = Random.Range(spawnerRateMin, spawnerRateMax);
        }
    }
}
