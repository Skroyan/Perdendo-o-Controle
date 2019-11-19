using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StefTrigger : MonoBehaviour
{
    public Transform[] posicoes = new Transform[2];
    private RaycastHit gameObj;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        bool chegou = Physics.Linecast(posicoes[0].position, posicoes[1].position, out gameObj);

        if (chegou)
        {
            if (gameObj.transform.gameObject.CompareTag("Tocus"))
            {
                float velocidade = 20f;
                GameObject.Find("Stefani").transform.Translate(+((velocidade) * Time.deltaTime), 0, 0);
            }
        }
    }
}
