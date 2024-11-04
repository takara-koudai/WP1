using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletScript : MonoBehaviour
{

    public Rigidbody rb;

    public void OnCollisionEnter(Collision collision)
    {
        //土管に当たると弾が消える
        if(collision.gameObject.tag == "Dokan")
        {
            Destroy(gameObject);
        }

        //弾と土管が当たると敵が消える
        if (collision.gameObject.tag == "enemy")
        {
            Destroy(collision.gameObject);
            Destroy(this.gameObject);

            //敵を倒すとスコアが増える
            GameManagerScript.score += 1;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        float moveSpeed = 5.0f;

        rb.velocity = new Vector3(moveSpeed, 0, 0);

        Destroy(gameObject, 3);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
