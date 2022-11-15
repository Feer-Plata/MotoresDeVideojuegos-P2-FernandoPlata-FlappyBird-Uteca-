using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pescado : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.transform.CompareTag("Player"))
        {
            Destroy(gameObject);
        }

    }
}
