using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.InteropServices;

public class Celular : MonoBehaviour
{

    private float contagem = 12;
    private bool cel = false;
    RaycastHit hit;

    [DllImport("user32.dll")]

    static extern bool SetCursorPos(int X, int Y);
    int xPos = 2000, yPos = 2020;
    int sorteio;

private void Awake()
    {
        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
    }

    // Start is called before the first frame update
    void Start()
    {
        GameObject.Find("Celular").transform.localScale = new Vector3(0, 0, 0);//Deixa invisível na tela
    }

    void Update()
    {
        contagem -= Time.deltaTime;
        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (contagem <= 0.0f && contagem >= -0.05f)
        { //Faz surgir o celular na tela
            cel = true;
            GameObject.Find("Celular").transform.localScale = new Vector3(0.14f, 0.14f, 0);
            sorteio = Random.Range(0, 4);

            if (sorteio == 0)
            {
                xPos = 0;
                yPos = 0;
            }

            else if (sorteio == 1)
            {
                xPos = 0;
                yPos = 1080;
            }

            else if (sorteio == 2)
            {
                xPos = 1920;
                yPos = 1080;
            }

            else if (sorteio == 3)
            {
                xPos = 1920;
                yPos = 0;
            }

            SetCursorPos(xPos, yPos);

        }

            if (cel = true && Input.GetButtonDown("Fire1")) {//Faz desaparecer o celular da tela
            if (Physics.Raycast(ray, out hit, 100))
            {
                if (hit.transform.tag == "Celular")
                {
                    contagem = Random.Range(8f, 13f);
                    GameObject.Find("Celular").transform.localScale = new Vector3(0, 0, 0);
                    cel = false;
                }
            }

        }
    }
}