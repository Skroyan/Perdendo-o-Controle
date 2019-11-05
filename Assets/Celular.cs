using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Celular : MonoBehaviour
{

    float timeCounter = 0;

    private Camera mainCamera;
    private Transform posCamera;


    float velocidade;
    float largura;
    float altura;
  //  float profundidade = GameObject.Find("CameraController").GetComponent<Vector3>();

    // Start is called before the first frame update
    void Start()
    {
        mainCamera = Camera.main;
        posCamera = mainCamera.GetComponent<Transform>();
        
        velocidade = 5;
        largura = 4;
        altura = 7;
    }

    // Update is called once per frame
    void Update()
    {
        timeCounter += Time.deltaTime * velocidade;

        float x = Mathf.Cos(timeCounter) * largura;
        float y = Mathf.Sin(timeCounter) * altura;
        float z = posCamera.position.z+50;

        transform.position = new Vector3(x, y, z);
    }
}