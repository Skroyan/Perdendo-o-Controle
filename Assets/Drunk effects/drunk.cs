using UnityEngine;
using System.Collections;
using System;

public class drunk : MonoBehaviour 
{
	public Material[] material;
    int i = 0;
    private float tempo = 0;
    private AudioSource gole;

    void Start()
    {
        gole = GameObject.Find("Garrafa").GetComponent<AudioSource>();
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
            if ((int)Math.Round(tempo) == 6)
            {
                playgole();
            }
        }

        else if (tempo >= 11 && tempo < 16)
        {
            i = 2;
            if ((int)Math.Round(tempo) == 11)
            {
                playgole();
            }
        }

        else if (tempo >= 16 && tempo < 21)
        {
            i = 3;
            if ((int)Math.Round(tempo) == 16)
            {
                playgole();
            }
        }

        else if (tempo >= 21 && tempo < 26)
        {
            i = 4;
            if ((int)Math.Round(tempo) == 21)
            {
                playgole();
            }
        }

        else if (tempo >= 26 && tempo < 31)
        {
            i = 5;
            if ((int)Math.Round(tempo) == 26)
            {
                playgole();
            }
        }

        else if (tempo >= 31 && tempo < 36)
        {
            i = 6;
            if ((int)Math.Round(tempo) == 31)
            {
                playgole();
            }
        }

        else if (tempo >= 36 && tempo < 41)
        {
            i = 7;
            if ((int)Math.Round(tempo) == 36)
            {
                playgole();
            }
        }

        else if (tempo >= 41 && tempo < 46)
        {
            i = 8;
            if ((int)Math.Round(tempo) == 41)
            {
                playgole();
            }
        }

        else if (tempo >= 46 && tempo < 51)
        {
            i = 9;
            if ((int)Math.Round(tempo) == 46)
            {
                playgole();
            }
        }

        else if (tempo >= 51 && tempo < 56)
        {
            i = 10;
            if ((int)Math.Round(tempo) == 51)
            {
                playgole();
            }
        }

        else if (tempo >= 56 && tempo < 61)
        {
            i = 11;
            if ((int)Math.Round(tempo) == 56)
            {
                playgole();
            }
        }

        else if (tempo >= 61 && tempo < 66)
        {
            i = 12;
            if ((int)Math.Round(tempo) == 61)
            {
                playgole();
            }
        }

        else if (tempo >= 66 && tempo < 71)
        {
            i = 13;
            if ((int)Math.Round(tempo) == 66)
            {
                playgole();
            }
        }

        else if (tempo >= 71 && tempo < 76)
        {
            i = 14;
            if ((int)Math.Round(tempo) == 71)
            {
                playgole();
            }
        }

        else if (tempo >= 76 && tempo < 81)
        {
            i = 15;
            if ((int)Math.Round(tempo) == 76)
            {
                playgole();
            }
        }

        else if (tempo >= 81 && tempo < 86)
        {
            i = 16;
            if ((int)Math.Round(tempo) == 81)
            {
                playgole();
            }
        }

        else if (tempo >= 86 && tempo < 91)
        {
            i = 17;
            if ((int)Math.Round(tempo) == 86)
            {
                playgole();
            }
        }

        else if (tempo >= 91 && tempo < 96)
        {
            i = 18;
            if ((int)Math.Round(tempo) == 91)
            {
                playgole();
            }
        }

        else if (tempo >= 96 && tempo < 101)
        {
            i = 19;
            if ((int)Math.Round(tempo) == 96)
            {
                playgole();
            }
        }

        else if (tempo >= 101 && tempo < 106)
        {
            i = 20;
            if ((int)Math.Round(tempo) == 101)
            {
                playgole();
            }
        }

        else if (tempo >= 106 && tempo < 111)
        {
            i = 21;
            if ((int)Math.Round(tempo) == 106)
            {
                playgole();
            }

        }

        else if (tempo >= 111 && tempo < 116)
        {
            i = 22;
            if ((int)Math.Round(tempo) == 111)
            {
                playgole();
            }
        }

        else if (tempo >= 116 && tempo < 121)
        {
            i = 23;
            if ((int)Math.Round(tempo) == 116)
            {
                playgole();
            }
        }

        else if (tempo >= 121 && tempo < 126)
        {
            i = 24;
            if ((int)Math.Round(tempo) == 121)
            {
                playgole();
            }
        }

        else if (tempo >= 126 && tempo < 131)
        {
            i = 25;
            if ((int)Math.Round(tempo) == 126)
            {
                playgole();
            }
        }

        else if (tempo >= 131 && tempo < 136)
        {
            i = 26;
            if ((int)Math.Round(tempo) == 131)
            {
                playgole();
            }
        }

        else if (tempo >= 136 && tempo < 141)
        {
            i = 27;
            if ((int)Math.Round(tempo) == 136)
            {
                playgole();
            }
        }

        else if (tempo >= 141 && tempo < 146)
        {
            i = 28;
            if ((int)Math.Round(tempo) == 141)
            {
                playgole();
            }
        }

        else if (tempo >= 146 && tempo < 151)
        {
            i = 29;
            if ((int)Math.Round(tempo) == 146)
            {
                playgole();
            }
        }

        else if (tempo >= 151 && tempo < 156)
        {
            i = 30;
            if ((int)Math.Round(tempo) == 151)
            {
                playgole();
            }
        }
    }



    public void OnRenderImage(RenderTexture source, RenderTexture destination)
    {
        Graphics.Blit(source, destination, material[i]);
    }

    private void playgole()
    {
        if (!gole.isPlaying)
        {
            gole.Play();
        }
    }
}