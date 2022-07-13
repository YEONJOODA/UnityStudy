using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetController : MonoBehaviour
{
    public ParticleSystem TankExplosion;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "SHELL")
        {
            ParticleSystem fire = Instantiate(TankExplosion, transform.position, transform.rotation);
            fire.Play();

            Destroy(gameObject);
            Destroy(fire.gameObject, 2.0f);
        }
        
    }
}
