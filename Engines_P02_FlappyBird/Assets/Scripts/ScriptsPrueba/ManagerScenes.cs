using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ManagerScenes : MonoBehaviour
{
    //Atributos
    public GameObject canvasPerder;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
    }
    void EmpezarJuego()
    {
        SceneManager.LoadScene(1);
    }
    public void Morido()
    {
        canvasPerder.SetActive(true);
        Time.timeScale = 0;
    }
    public void ReStart()
    {
        SceneManager.LoadScene(1);
    }
    public void Finalizar()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
}
