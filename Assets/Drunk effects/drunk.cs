using UnityEngine;
using System.Collections;

public class drunk : MonoBehaviour 
{
	public Material[] material;
    int i = 0;
    private float tempo = 0;
    private AudioSource gole;

    private void Start()
    {
        gole = this.GetComponent<AudioSource>();
    }

    void Update()
    {
        tempo += Time.deltaTime;

        if (tempo >= 0 && tempo < 6)
        {
            i = 0;
        }

        else if (tempo >= 6 && tempo < 11)
        {
            i = 1;
        }

        else if (tempo >= 11 && tempo < 16)
        {
            i = 2;
        }

        else if (tempo >= 16 && tempo < 21)
        {
            i = 3;
        }

        else if (tempo >= 21 && tempo < 26)
        {
            i = 4;
        }

        else if (tempo >= 26 && tempo < 31)
        {
            i = 5;
        }

        else if (tempo >= 31 && tempo < 36)
        {
            i = 6;
        }

        else if (tempo >= 36 && tempo < 41)
        {
            i = 7;
        }

        else if (tempo >= 41 && tempo < 46)
        {
            i = 8;
        }

        else if (tempo >= 46 && tempo < 51)
        {
            i = 9;
        }

        else if (tempo >= 51 && tempo < 56)
        {
            i = 10;
        }

        else if (tempo >= 56 && tempo < 61)
        {
            i = 11;
        }

        else if (tempo >= 61 && tempo < 66)
        {
            i = 12;
        }

        else if (tempo >= 16 && tempo < 21)
        {
            i = 13;
        }

        else if (tempo >= 21 && tempo < 26)
        {
            i = 14;
        }

        else if (tempo >= 26 && tempo < 31)
        {
            i = 15;
        }

        else if (tempo >= 31 && tempo < 36)
        {
            i = 16;
        }

        else if (tempo >= 36 && tempo < 41)
        {
            i = 17;
        }

        else if (tempo >= 41 && tempo < 46)
        {
            i = 18;
        }

        else if (tempo >= 46 && tempo < 51)
        {
            i = 19;
        }

        else if (tempo >= 51 && tempo < 56)
        {
            i = 20;
        }

        else if (tempo >= 56 && tempo < 61)
        {
            i = 21;
        }

        else if (tempo >= 61 && tempo < 66)
        {
            i = 22;
        }

        else if (tempo >= 66 && tempo < 71)
        {
            i = 23;
        }

        else if (tempo >= 71 && tempo < 76)
        {
            i = 24;
        }

        else if (tempo >= 76 && tempo < 81)
        {
            i = 25;
        }

        else if (tempo >= 81 && tempo < 86)
        {
            i = 26;
        }

        else if (tempo >= 86 && tempo < 91)
        {
            i = 27;
        }

        else if (tempo >= 91 && tempo < 96)
        {
            i = 28;
        }

        else if (tempo >= 96 && tempo < 101)
        {
            i = 29;
        }

        else if (tempo >= 101 && tempo < 106)
        {
            i = 30;
        }
    }



    public void OnRenderImage(RenderTexture source, RenderTexture destination)
    {
        Graphics.Blit(source, destination, material[i]);
    }
}