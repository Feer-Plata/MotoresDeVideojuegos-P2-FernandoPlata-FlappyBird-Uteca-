using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SumaScore : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Le suma al score cada que entre al collider.
        ScoreTuberias.score++;
    }
}
