using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret : MonoBehaviour
{
    public GameObject projectile;
    public float shootFrequency = 2f;
    public float xSpeed = 2f;
    public float ySpeed = 2f;
    public float timer = 0f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= shootFrequency)
        {
            timer = 0f;
            GameObject thrownObject = Instantiate(projectile, transform.position, Quaternion.identity);
            thrownObject.GetComponent<Bullet>().xSpeed=xSpeed;
            thrownObject.GetComponent<Bullet>().ySpeed=ySpeed;

        }
    }
}
