using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : Shotter
{
    void Start()
    {
        totalShooter = 0.2f;
        poolBullets = new List<GameObject>();
    }
    override protected void generateBullet()
    {
        if (Input.GetKey(KeyCode.A))
        {
            iBala = 0;
            Vector3 temp = transform.position;
            temp.y += 1.5f;
            CreateBullet(temp, velocityBullet);
        }
        if (Input.GetKey(KeyCode.S))
        {
            iBala = 1;
            Vector3 temp = transform.position;
            temp.y += 1.5f;
            CreateBullet(temp, velocityBullet);
        }
        if (Input.GetKey(KeyCode.D))
        {
            iBala = 2;
            Vector3 temp = transform.position;
            temp.y += 1.5f;
            CreateBullet(temp, velocityBullet);
        }
        if (Input.GetKey(KeyCode.F) && Input.GetKey(KeyCode.RightArrow))
        {
            iBala = 3;
            Vector3 temp = transform.position;
            temp.x += 1.5f;
            CreateBullet(temp, new Vector2(5f,0));
        }
        if (Input.GetKey(KeyCode.G) && Input.GetKey(KeyCode.RightArrow))
        {
            iBala = 4;
            Vector3 temp = transform.position;
            temp.x += 1.5f;
            CreateBullet(temp, new Vector2(5f, 0));
        }

        if (Input.GetKey(KeyCode.F) && Input.GetKey(KeyCode.LeftArrow))
        {
            iBala = 3;
            Vector3 temp = transform.position;
            temp.x -= 1.5f;
            CreateBullet(temp, new Vector2(-5f, 0));
        }
        if (Input.GetKey(KeyCode.G) && Input.GetKey(KeyCode.LeftArrow))
        {
            iBala = 4;
            Vector3 temp = transform.position;
            temp.x -= 1.5f;
            CreateBullet(temp, new Vector2(-5f, 0));
        }
    }
}
