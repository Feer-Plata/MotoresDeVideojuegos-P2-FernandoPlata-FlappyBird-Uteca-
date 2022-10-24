using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TuberiasMov : MonoBehaviour
{
    //Atributos
    public float velTub;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * velTub * Time.deltaTime;
    }
}
