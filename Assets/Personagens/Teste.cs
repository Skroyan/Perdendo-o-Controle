using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teste : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float velocidade = 10f;
        GameObject.Find("Stefani").transform.Translate(+((velocidade) * Time.deltaTime), 0, 0);
    }
}