using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullets : MonoBehaviour
{
    public float speedBullets;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
            transform.Translate(Vector3.forward * speedBullets * Time.deltaTime);


    }
    private void OnCollisionEnter(Collision col)
    {
        Destroy(gameObject);

    }
}
