using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    public float speed = 8f;
    public float damage = 10f;
    public float lifeDuration = 20f;
    private bool collided;
    private float lifeTimer;
    private void OnCollisionEnter(Collision collision)
    {
        Target target = collision.transform.GetComponent<Target>();
        if (target != null && !collided)
        {
            target.TakeDamage(damage);
            collided = true;
            Destroy(gameObject);
        }

        if (collision.gameObject.tag != "Bullet" && collision.gameObject.tag != "Player" && !collided)
        {
            collided = true;
            Destroy(gameObject);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        lifeTimer = lifeDuration;
    }
    // Update is called once per frame
    void Update()
    {
        transform.position += transform.forward * speed * Time.deltaTime;
        lifeTimer -= Time.deltaTime;
        if (lifeTimer <= 0f) { 
            Destroy(gameObject); 
        }

    }
}
