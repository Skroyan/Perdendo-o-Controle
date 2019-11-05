using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sons : MonoBehaviour
{
    private AudioSource musica1;
    private float timer = 1.14f;
    private bool tocar = false;

    // Start is called before the first frame update
    void Start()
    {
        musica1 = this.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(tocar)
        {
            playaudio();
            tocar = false;
        }
       
        if(timer<0)
        {
            tocar = true;
            timer = 1.14f;
        }

        timer -= Time.deltaTime;

    }

    private void playaudio()
    {
        if (!musica1.isPlaying)
        {
            musica1.Play();
        }
    }
}
