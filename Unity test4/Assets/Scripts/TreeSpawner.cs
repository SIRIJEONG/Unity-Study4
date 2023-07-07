using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeSpawner : MonoBehaviour
{
    public GameObject treePrefab = default;
    public float spawnerRateMin = 1.0f;
    public float spawnerRateMax = 3.0f;

    private float spawnerRate = default;
    private float timeAfterSpawner = default;
    // Start is called before the first frame update
    void Start()
    {
        timeAfterSpawner = 0f;
        spawnerRate = Random.Range(spawnerRateMin, spawnerRateMax);
    }

    // Update is called once per frame
    void Update()
    {
        timeAfterSpawner += Time.deltaTime;

        if (timeAfterSpawner >= spawnerRate)
        {
            timeAfterSpawner = 0f;


            GameObject Tree = Instantiate(treePrefab, transform.position, transform.rotation);
            //bullet.transform.LookAt(target);

            spawnerRate = Random.Range(spawnerRateMin, spawnerRateMax);
        }
    }
}
