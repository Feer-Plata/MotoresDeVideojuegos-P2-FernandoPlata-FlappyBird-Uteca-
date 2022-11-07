using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Panels : MonoBehaviour
{
    [SerializeField] private GameObject menuPausa;
    //[SerializeField] private GameObject botonPausa;
    private bool juegoPausado = false;

    public void Pausa()
    {
        juegoPausado = true;
        Time.timeScale = 0f;
        menuPausa.SetActive(true);
    }
    public void Reanudar()
    {
        juegoPausado = false;
        Time.timeScale = 1f;
        //botonPausa.SetActive(true);
        menuPausa.SetActive(false);
    }
    public void Finalizar()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
    public void PauseButton()
    {
        bool isPaused = false;
        if (isPaused)
        {
            Time.timeScale = 1;
            isPaused = false;
        }
        else
        {
            Time.timeScale = 0;
            isPaused = true;
        }
    }
}
