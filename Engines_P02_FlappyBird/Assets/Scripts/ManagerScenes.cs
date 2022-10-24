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

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Morido()
    {
        canvasPerder.SetActive(true);
        Time.timeScale = 0;
    }
    public void ReStart()
    {
        SceneManager.LoadScene(0);
    }
}
