using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TxtScore : MonoBehaviour
{
    //Atributos

    public Text scoreTxt;
    public Text highScoreTxt;

    // Update is called once per frame
    void Update()
    {
        scoreTxt.text = "Score: " + Score.score;
        highScoreTxt.text = "HighScore: " + Score.highScore;
    }

}
public class Score : MonoBehaviour
{
    public static int score = 0;                    //Inicializa el score en cero.
    public static int highScore = 0;                //Inicializa el highScore en cero.
}
