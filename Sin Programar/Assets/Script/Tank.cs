using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tank : MoveVehicle 
{
    public int bullets;
    public GameObject prefabBullets;
    public Transform instantiateBullets;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (bullets > 0 && Input.GetKeyDown (KeyCode.F))
        {
            Shoot();
            bullets = bullets - 1;
        }
    }
    void Shoot()
    {
        Instantiate(prefabBullets, instantiateBullets.position, instantiateBullets.rotation);
    }
}
