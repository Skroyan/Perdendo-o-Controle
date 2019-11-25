using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShaeTrigger : MonoBehaviour
{

    public GameObject obj;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        /*private void OnTriggerStay()
        {
            float velocidade = 15f;
            GameObject.Find("Stefani").transform.Translate(+((velocidade) * Time.deltaTime), 0, 0);
        }

        private void OnTriggerExit()
        {
            texto.text = "";
        }
        bool chegou = Physics.Linecast(posicoes[0].position, posicoes[1].position, out gameObj);

        if (chegou)
        {
            if (gameObj.transform.gameObject.CompareTag("Tocus"))
            {
                float velocidade = 15f;
                GameObject.Find("Stefani").transform.Translate(+((velocidade) * Time.deltaTime), 0, 0);
            }
        }*/
    }

    private void OnTriggerStay()
    {
        print("Entrou");
        float velocidade = 2f;
        GameObject.Find("Shae").transform.Translate(0, 0, -((velocidade) * Time.deltaTime));
    }
}
