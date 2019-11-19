using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colisões : MonoBehaviour
{

    public AudioSource colisao;

    void Start()
    {
        colisao = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Tocus")
        {
            colisao.Play();
        }
    }

}
