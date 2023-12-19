using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class boll : MonoBehaviour
{
    Rigidbody myRigidBody;


    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(2, -5, 0);
        myRigidBody = GetComponent<Rigidbody>();
        myRigidBody.velocity = new Vector3(0, -1, 0);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float speed = 10;
        myRigidBody.velocity = myRigidBody.velocity.normalized * speed;

        if (transform.position.y < -8)
        {
            transform.position = new Vector3(2, -2, 0);

        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("kollision!");
        GameObject othergameobject = collision.gameObject;
        Block hitDestroy = othergameobject.GetComponent<Block>();

        if (hitDestroy != null)
        {
            hitDestroy.TakeDamge();
        }
    }
}
