using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //Atributos
    public float velPlayer;
    private Rigidbody2D rb;
    public ManagerScenes contoladorEscenas;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) //Boton Izquierdo del mouse
        {
            rb.velocity = Vector2.up * velPlayer;
        }  
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        contoladorEscenas.Morido();
    }
}
