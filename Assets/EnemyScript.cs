using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{

    public Rigidbody rb;

    float EnemySpeed = 2f;

    //GameManagerScript gameM;

    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "Player")//衝突したら敵を消す
        {
            
            //自分が消える
            //Destroy(other.gameObject); 

            //敵が消える
            Destroy(this.gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 i = rb.velocity;

        i.x = EnemySpeed;

        rb.velocity = i;

    }
}
