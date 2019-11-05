using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Celular : MonoBehaviour
{

    float timeCounter = 0;

    //private Camera mainCamera;
    //private Transform posCamera;


    float velocidade;
    float largura;
    float altura;
  //  float profundidade = GameObject.Find("CameraController").GetComponent<Vector3>();

    // Start is called before the first frame update
    void Start()
    {
        //mainCamera = Camera.main;
       // posCamera = mainCamera.GetComponent<Transform>();
        
        velocidade = 2;
        largura = 5;
        altura = 2;
    }

    // Update is called once per frame
    void Update()
    {
        timeCounter += Time.deltaTime * velocidade;

        float x = Mathf.Cos(timeCounter);
        float y = Mathf.Sin(timeCounter);
    //    float z = posCamera.position.z-5;


       // transform.position = new Vector2(x, y);
    }
}