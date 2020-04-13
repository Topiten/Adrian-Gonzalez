using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tank : MoveVehicle 
{
    public int bullets;
    public GameObject prefabBullets;
    public float distanceBullets;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (bullets >= 0 && Input.GetKey (KeyCode.F))
        {
            Shoot();
        }
    }
    void Shoot()
    {
        Instantiate(prefabBullets,new Vector3(transform.position.x, transform.position.y, transform.position.z + distanceBullets), transform.rotation);
    }
}
