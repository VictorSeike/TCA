using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI_Inimigo : MonoBehaviour
{

    public float velocidade = 10f;
    private Transform jogador;


    void Start()
    {
        jogador = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        SeguirJogador();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {

        Debug.Log("O objeto " + name + " colidiu com o objeto " + other.name);

        if (other.tag == "Player")
        {
            Player player = other.GetComponent<Player>();

            if (player != null)
            {
                player.DanoAoPLayer();
            }


        }

        
    }

    private void SeguirJogador()
    {
        if (jogador != null)
        {

            Vector3 direcao = jogador.position - transform.position;
            direcao.Normalize();

            transform.Translate(direcao * velocidade * Time.deltaTime);
        }

    }
}
