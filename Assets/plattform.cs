using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plattform : MonoBehaviour
{
    Rigidbody myrigidbody;
    void Start()
    {
        transform.position = new Vector3(2, -7, 0);

    }
    [SerializeField]
    GameObject player;
    float speed = 10;


    Vector3 velocity;
    void Update()
    {

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += new Vector3(1, 0, 0) * Time.deltaTime * speed;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += new Vector3(-1, 0, 0) * Time.deltaTime * speed;
        }





    }
}
