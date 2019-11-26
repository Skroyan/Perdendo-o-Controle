using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Capotar : MonoBehaviour
{
    Transform rotacao;
    float contagem = 0.7f;
    bool capotou = false;

    // Start is called before the first frame update
    void Start()
    {
        rotacao = this.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (this.transform.eulerAngles.z >= 90f && this.transform.eulerAngles.z <= 300f)
        {
            capotou = true;
        }

        if (capotou == true)
        {
            contagem -= Time.deltaTime;
        }

        if (contagem <= 0f)
        {
            SceneManager.LoadScene("Notícias");
        }


    }

}
