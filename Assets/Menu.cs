using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void iniciar()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void instrucoes()
    {
        SceneManager.LoadScene("Instruções");
    }

    public void creditos()
    {
        SceneManager.LoadScene("Créditos");
    }

    public void voltarMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
