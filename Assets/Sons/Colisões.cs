using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Colisões : MonoBehaviour
{

    public AudioSource colisao;
    //public AudioClip som;

    void Start()
    {
        colisao = GameObject.Find("Tocus").GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        print("colidiu");
        if (other.gameObject.tag == "Tocus")
        {
            //GameObject.Find("Tocus").GetComponent<AudioSource>().PlayOneShot(som);
            colisao.Play();
            //SceneManager.LoadScene("Fase2");
        }
    }

}
