using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMove : MonoBehaviour
{
    public GameObject tire_03Prefab = default;
    private float timeAfterSpawner = default;
    private float rollRate = 0.3f;

    private Rigidbody PlayerRigid = default;
    public float speed = default;

    // Start is called before the first frame update
    void Start()
    {
        PlayerRigid = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        float xInput = Input.GetAxis("Horizontal");
        float zInput = Input.GetAxis("Vertical");
        

        float xSpeed = xInput * speed;
        float zSpeed = zInput * speed;

        Vector3 newVelocity = new Vector3(xSpeed, 0f, zSpeed);
        PlayerRigid.velocity = newVelocity;

        timeAfterSpawner += Time.deltaTime;
        if (Input.GetKey(KeyCode.L))
        {

            if(timeAfterSpawner >= rollRate)
            {
            GameObject tire_03 = Instantiate(tire_03Prefab, transform.position, transform.rotation);
                timeAfterSpawner = 0;
            }
            

        }

    }
    public void Die()
    {
        gameObject.SetActive(false);


        GameManager gameManager = FindObjectOfType<GameManager>();
        gameManager.Endgame();
    }
}
