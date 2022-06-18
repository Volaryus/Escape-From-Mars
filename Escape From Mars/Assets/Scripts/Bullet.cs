using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float xSpeed;
    public float ySpeed;
    public float damage = 5f;
    public float destroyTime=10f;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, destroyTime);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(xSpeed*Time.deltaTime, ySpeed*Time.deltaTime, 0);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.GetComponent<Health>().TakeDamage(damage);
        }
        Destroy(gameObject);
    }
}
