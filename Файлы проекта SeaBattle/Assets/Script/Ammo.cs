using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Ammo : MonoBehaviour
{
    public GameObject explosion2;
    public GameObject explosion;
    public float speed;
    public float destroyTime;

    void Start()
    {
        Invoke("DestroyAmmo", destroyTime);
    }

    void FixedUpdate()
    {
        transform.Translate(Vector2.right * speed * Time.fixedDeltaTime);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Wall")
            DestroyAmmo();
        if (other.tag == "Enemy")
        {
            Instantiate(explosion2, transform.position, transform.rotation);
            DestroyAmmo();
        }
    }

    void DestroyAmmo() 
    {
        Instantiate(explosion, transform.position, transform.rotation);
        Destroy(gameObject);
    }
}
