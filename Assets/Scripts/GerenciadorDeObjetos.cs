using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GerenciadorDeObjetos : MonoBehaviour
{

    [SerializeField]
    private GameObject _inimigoPrefab;

    [SerializeField]
    private GameObject[] _powerUps;


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(RotinaGeracaoInimigo());
        StartCoroutine(RotinaGeracaoPowerUp());
    }

    IEnumerator RotinaGeracaoInimigo()
    {
        while (1 == 1)
        {
            Instantiate(_inimigoPrefab, new Vector3(Random.Range(-7.7f, 7.7f), 39.5f, 0), Quaternion.identity);
            yield return new WaitForSeconds(2);
        }
    }
        IEnumerator RotinaGeracaoPowerUp()
    {
        while (1 == 1)
        {
            int powerUpsAletatorio = Random.Range(0, 3);
            Instantiate(_powerUps[powerUpsAletatorio], new Vector3(Random.Range(-7.7f, 7.7f), 6.0f, 0), Quaternion.identity);
            yield return new WaitForSeconds(6);
        }
        /*
        E porque estamos usando valores de 0 a 3 se o índice do array vai de 0 a
        2? Eu explico. Quando se trabalha com valores inteiros no Random.Range,
        ele sempre irá retornará um valor inteiro aleatório entre o mínimo e o
        máximo exclusivo, o que significa que se colocássemos como range os
        valores (0, 2) a variável powerUpsAleatorio só receberia os valores 0 e 1.  
        Por essa razão inserimos o valor mínimo 0 e o máximo 3, dessa forma,
        iremos obter ou valor 0 ou 1 ou 2, e esses valores se encaixam perfeitamente
        nos valores do índice do array.
          */
    }
}