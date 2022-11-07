using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Puntaje : MonoBehaviour
{
    public static int score = 0;
}
public class TextScore : MonoBehaviour
{
    //Atributos
    public Text score;

    private void Update()
    {
        score.text = "Score: " + Puntaje.score;
    }
}