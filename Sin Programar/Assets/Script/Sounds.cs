using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sounds : MonoBehaviour
{
    public AudioClip moveTank;
    public AudioClip shootTank;
    public AudioClip bocina;
    public AudioSource fuenteAudio;


    // Start is called before the first frame update
    void Start()
    {
        fuenteAudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
      

    }
    public void SoundMoveTank()
    {
        fuenteAudio.clip = moveTank;
        fuenteAudio.Play();
    }
    public void SoundShootTank()
    {
        fuenteAudio.clip = shootTank;
        fuenteAudio.Play();
    }
    public void SoundBocina()
    {
        fuenteAudio.clip = bocina;
        fuenteAudio.Play();
    }
}
