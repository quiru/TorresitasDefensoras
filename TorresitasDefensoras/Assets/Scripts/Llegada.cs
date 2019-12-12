using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Llegada : MonoBehaviour
{
    int contEnemis = 0;
    public Image sangre;
    public Text textContador;
    float cont = 250;
    public static bool juego;
    public GameObject mensLose;
    public GameObject mensWin;
    public GameObject pause;
    bool pausaActiva;
    AudioSource Rep;
    public AudioClip music;
    bool activaSound;

    void Start()
    {
        juego = true;
        mensLose.SetActive(false);
        mensWin.SetActive(false);
        pause.SetActive(false);
        Rep = gameObject.GetComponent<AudioSource>();
        Rep.clip = music;
        Rep.Play();
        Time.timeScale = 1;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<DestinoNavMesh>())
        {
            contEnemis += 1;
            sangre.fillAmount -= 0.2f;
            Destroy(collision.gameObject);
        }
    }


    void Update()
    {
        if (contEnemis >= 5)
        {
            mensLose.SetActive(true);
            juego = false;
            pause.SetActive(true);
            pause.transform.GetChild(4).gameObject.SetActive(false);
            Time.timeScale = 0;
        }
        else if (cont <= 0)
        {
            mensWin.SetActive(true);
            juego = false;
            pause.SetActive(true);
            pause.transform.GetChild(4).gameObject.SetActive(false);
            Time.timeScale = 0;
        }

        cont -= Time.deltaTime;
        textContador.text = Mathf.FloorToInt(cont).ToString();

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            pausaActiva = !pausaActiva;
            pause.SetActive(pausaActiva);
            Time.timeScale = (pausaActiva) ? 0 : 1;
        }
    }

    public void Salir()
    {
        SceneManager.LoadScene(0);
    }

    public void Volver()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(1);
    }

    public void Music()
    {
        activaSound = !activaSound;
        if (activaSound)
        {
            Rep.Pause();
        }
        else
        {
            Rep.Play();
        }
    }
}
