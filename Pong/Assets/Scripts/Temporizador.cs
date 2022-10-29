using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Temporizador : MonoBehaviour
{
    public float temporizador = 0;

    public TextMeshProUGUI TextTemporizador;


    //public  AudioSource fuenteDeAudio;

    //Clips de audio
    //public AudioClip FinJuegoSonido;
    // Update is called once per frame
    void Update()
    {
        if (temporizador > 0)
        {
            temporizador -= Time.deltaTime;

            TextTemporizador.text = "" + temporizador.ToString("f0");
        }
        else
        {
            StartCoroutine(EsperarSonido());
           
        }
        
    }


    IEnumerator EsperarSonido()
    {
        //fuenteDeAudio.clip = FinJuegoSonido;
        //GetComponent<AudioSource>().Play();
        GetComponent<AudioSource>().enabled = true;

        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene("Inicio");
    }


}
