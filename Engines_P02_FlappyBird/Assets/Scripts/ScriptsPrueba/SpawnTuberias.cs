using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnTuberias : MonoBehaviour
{
    //Atributos
    public float maxTime = 1;
    private float initTime = 0;
    public GameObject obstaculo;
    public float altura;

    // Start is called before the first frame update
    void Start()
    {
        GameObject obsNew = Instantiate(obstaculo);
        obsNew.transform.position = transform.position + new Vector3(0, 0, 0);
        Destroy(gameObject, 10f);
    }

    // Update is called once per frame
    void Update()
    {
        if (initTime>maxTime)
        {
            GameObject obsNew = Instantiate(obstaculo);
            obsNew.transform.position = transform.position + new Vector3(0, Random.Range(-altura,altura), 0);
            Destroy(gameObject, 10f);
            initTime = 0;
        }
        else
        {
            initTime += Time.deltaTime;
        }
    }
}
