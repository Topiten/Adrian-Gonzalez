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
        if (Input.GetKeyDown(KeyCode.W))
        {
            sonido.SoundMoveTank();
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            sonido.SoundMoveTank();
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            sonido.fuenteAudio.Stop();
        }
        if (Input.GetKeyUp(KeyCode.S))
        {
            sonido.fuenteAudio.Stop();
        }

    }
    void Shoot()
    {
        Instantiate(prefabBullets, instantiateBullets.position, instantiateBullets.rotation);
    }
}
