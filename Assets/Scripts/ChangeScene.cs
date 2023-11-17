using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public float targetY = -88f;
    public float positionThreshold = 0.1f; // Adjust this threshold as needed

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Mathf.Abs(transform.position.y - targetY) < positionThreshold)
        {
            SceneManager.LoadScene("Jogo_Entrada");
        }
    }
}
