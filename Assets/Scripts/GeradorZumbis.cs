using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeradorZumbis : MonoBehaviour
{
    public float delay = 2f;

    public GameObject zumbiPrefab;
    public float area = 3f;

    // Use this for initialization
    void Start()
    {
        InvokeRepeating("GerarZumbi", delay, delay);
	}

	void GerarZumbi()
    {
        GameObject zumbi = Instantiate(zumbiPrefab);

        Vector2 posicaoAleatoria = Random.insideUnitCircle * area;
        zumbi.transform.position = new Vector3(
            posicaoAleatoria.x,
            zumbi.transform.position.y,
            posicaoAleatoria.y
        );
	}
}
