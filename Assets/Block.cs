using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    [SerializeField]
    Material R; 
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    int hp = 2;
    public void TakeDamge()
    {
        hp -= 1;

        if (hp== 1)
        {
            MeshRenderer r = GetComponent<MeshRenderer>();
            r.material = R; 
        }
            if (hp == 0)
            {
                Destroy(gameObject);
            }
        

    }
}
    
        



    
           
