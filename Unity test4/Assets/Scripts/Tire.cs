using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tire : MonoBehaviour
{

    public GameObject boom = default;

    public float speed = default;
    private Rigidbody rigid = default;
    // Start is called before the first frame update
    void Start()
    {
        

        rigid = GetComponent<Rigidbody>();
        rigid.velocity = transform.forward * -speed; //forward = z

        Destroy(gameObject, 4.0f);
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == ("animal"))
        {
            Destroy(gameObject);
            Destroy(other.gameObject);
            Instantiate(boom,transform.position,transform.rotation);

        }
    }
}

