using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LlamarEscena : MonoBehaviour
{
    public Button INICIO, SALIR;
    // Start is called before the first frame update
    void Start()
    {
        INICIO.onClick.AddListener(() =>
        {
            SceneManager.LoadScene("Inicio");
        });

        SALIR.onClick.AddListener(() =>
        {
            Application.Quit();
        });
    }

    // Update is called once per frame
    void Update()
    {

    }
}
