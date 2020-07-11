using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shotter : MonoBehaviour
{
    protected float elapsedShooter;
    protected float totalShooter;
    [SerializeField]
    protected List<GameObject> bullets;
    protected List<GameObject> poolBullets;
    [SerializeField]
    protected List<GameObject> prefabProyectile;
    [SerializeField]
    protected Vector2 velocityBullet;
    protected int iBala = 0;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        elapsedShooter += Time.deltaTime;
        if (elapsedShooter >= totalShooter)
        {
            elapsedShooter = 0;
            generateBullet();

        }
    }

    virtual protected void generateBullet()
    {
        //print("Hola desde Shooter");
    }

  
    protected void CreateBullet(Vector3 origin_position, Vector2 velocity)
    {
       
        
            GameObject go = Instantiate(prefabProyectile[iBala], origin_position, Quaternion.identity);
            go.GetComponent<Rigidbody2D>().velocity = velocity;
            go.SetActive(true);
            return;
        
        
    }
}
