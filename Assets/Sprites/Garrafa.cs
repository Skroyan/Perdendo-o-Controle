using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Garrafa : MonoBehaviour
{
    private float tempo = 0;
    Image garrafa;
    public Sprite garrafa1, garrafa2, garrafa3, garrafa4, garrafa5, garrafa6;

    // Start is called before the first frame update
    void Start()
    {
        garrafa = GetComponent<Image>();
    }

    // Update is called once per frame


    void Update()
    {
        tempo += Time.deltaTime;

        if (tempo >= 0 && tempo < 31)
        {
            garrafa.sprite = garrafa1;
        }

        else if (tempo >= 31 && tempo < 61)
        {
            garrafa.sprite = garrafa2;
        }

        else if (tempo >= 61 && tempo < 91)
        {
            garrafa.sprite = garrafa3;
        }

        else if (tempo >= 91 && tempo < 121)
        {
            garrafa.sprite = garrafa4;
        }

        else if (tempo >= 121 && tempo < 151)
        {
            garrafa.sprite = garrafa5;
        }

        else if (tempo >= 151)
        {
            garrafa.sprite = garrafa6;
        }

    }

}
