using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GerenciadorDeUi : MonoBehaviour
{

    public Image painelDeVidas;
   
    public Sprite[] vidas;
   
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
       
    }

        public void AtualizarVidas( int vidasAtuais )
    {
        painelDeVidas.sprite = vidas[vidasAtuais];
    }
}