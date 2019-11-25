using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Notícias : MonoBehaviour
{
    Image noticia;
    int sorteio;
    public Sprite noticia1, noticia2, noticia3, noticia4, noticia5;

    // Start is called before the first frame update
    void Start()
    {
        noticia = GetComponent<Image>();

        sorteio = Random.Range(0, 5);

        if (sorteio == 0)
        {
            noticia.sprite = noticia1;
        }

        else if (sorteio == 1)
        {
            noticia.sprite = noticia2;
        }

        else if (sorteio == 2)
        {
            noticia.sprite = noticia3;
        }

        else if (sorteio == 3)
        {
            noticia.sprite = noticia4;
        }

        else if (sorteio == 4)
        {
            noticia.sprite = noticia5;
        }
    }

    void Update()
    {

    }
}