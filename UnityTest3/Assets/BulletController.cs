using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    public float speed = 10.0f;
    // private Rigidbody bulletRd;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Shoot()
    {
        GetComponent<Rigidbody>().AddForce(new Vector3(0, 0, speed));
    }

    public void OnCollisionEnter(Collision coll)
    {
        if (coll.collider.tag == "ENEMY")
        {
            // ÃÑ¾Ë ÆÄ±«
            Destroy(gameObject);
        }
    }
}
