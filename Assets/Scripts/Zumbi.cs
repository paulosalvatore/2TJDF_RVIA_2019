using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Zumbi : MonoBehaviour {

    Animator anim;
    Rigidbody rb;

    public float velocidade = 0.35f;

    bool morto = false;

    GameObject jogador;

    // Use this for initialization
    void Start () {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();

        jogador = GameObject.FindGameObjectWithTag("Player");
	}

    // Update is called once per frame
    void Update () {
        if (!morto)
        {
            rb.velocity = transform.forward * velocidade;

            transform.LookAt(jogador.transform);
        }
	}

    void OnTriggerEnter(Collider other)
    {
        // Exibo a tag do collider trigger que ativou
        print("OnTriggerEnter Zumbi: " + other.tag);

        // Verifico se a tag do trigger é igual a "Projétil"
        if (!morto && other.CompareTag("Projétil"))
        {
            // Objeto other verificado. É o projétil
            // Destrói o gameObject do projétil
            Destroy(other.gameObject);

            Morrer();
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Scene currentScene = SceneManager.GetActiveScene();
            SceneManager.LoadScene(currentScene.buildIndex);
        }
    }

    private void Morrer()
    {
        // Destrói o zumbi que foi atingido
        //Destroy(gameObject);
        anim.SetTrigger("Morrer");

        morto = true;
    }
}
