using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public Tank tk;
    public Sounds sonido;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (tk.bullets > 0 && Input.GetKeyDown(KeyCode.F))
        {
            sonido.SoundShootTank();
        }
    }
}
