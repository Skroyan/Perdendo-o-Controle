using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sons : MonoBehaviour
{
    private AudioSource musica1;

    // Start is called before the first frame update
    void Start()
    {
        musica1 = this.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    private void playaudio()
    {
        if (!musica1.isPlaying)
        {
            musica1.Play();
        }
    }
}
