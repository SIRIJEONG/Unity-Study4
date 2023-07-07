using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal : MonoBehaviour
{
    public float speed = default;
    private Rigidbody rigid = default;
    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody>();
        rigid.velocity = transform.forward * speed; //forward = z

        Destroy(gameObject, 7.0f);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == ("Player"))
        {
            CarMove carMove = other.GetComponent<CarMove>();
            if (carMove != null)
            {
                carMove.Die();
            }
        }

    }


}
