using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotAI : MonoBehaviour
{
    public float speed;
    public float StopDistance;
    public float retreatDistance;
    public Transform player;
    public Transform spawn;
    public float startTimeShots;
    public GameObject Ammo;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "enemy")
        {
            Destroy(other.gameObject);
        }
    }

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        Physics2D.queriesStartInColliders = false;
    }


    void Update()
    {
       
        if (Vector2.Distance(transform.position, player.position) > StopDistance)
        {
            transform.position = Vector2.MoveTowards(transform.position, player.position, speed * Time.deltaTime);
        }
        else
        {
            if (Vector2.Distance(transform.position, player.position) < StopDistance && Vector2.Distance(transform.position, player.position) > retreatDistance)
            {
                transform.position = this.transform.position;
            }
            else if (Vector2.Distance(transform.position, player.position) < retreatDistance)
            {
                transform.position = Vector2.MoveTowards(transform.position, player.position, -speed * Time.deltaTime);
            }
        }
    }
}
