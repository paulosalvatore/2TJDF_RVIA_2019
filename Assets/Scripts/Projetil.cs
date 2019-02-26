using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projetil : MonoBehaviour
{
    [Range(1, 5)]
    public float velocidade = 2f;

    // Use this for initialization
    private void Start()
    {
    }

    // Update is called once per frame
    private void Update()
    {
        transform.Translate(Vector3.forward * velocidade * Time.deltaTime);
    }
}