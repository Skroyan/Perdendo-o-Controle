using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Celular : MonoBehaviour
{

    private float contagem = 5;//Random.Range(8, 12);
    private bool cel = false;
    private Vector3 mouse = Input.mousePosition;

    // Start is called before the first frame update
    void Start()
    {
        GameObject.Find("Celular").transform.localScale = new Vector3(0, 0, 0); //Deixa invisível na tela
    }

    void Update()
    {
        contagem -= Time.deltaTime;


        if (contagem <= 0.0f)
        { //Faz surgir o celular na tela
            GameObject.Find("Celular").transform.localScale = new Vector3(0.14f, 0.14f, 0);
            cel = true;

        }

        if (cel = true && (mouse.x >=450 && mouse.x <= 916) && Input.GetButtonDown("Fire1")) {//Faz desaparecer o celular da tela
            contagem = 50;
            GameObject.Find("Celular").transform.localScale = new Vector3(0, 0, 0);;//Random.Range(8, 12);
            cel = false;

        }
    }
}