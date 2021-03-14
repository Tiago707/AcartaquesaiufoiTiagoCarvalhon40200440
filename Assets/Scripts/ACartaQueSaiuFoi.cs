using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ACartaQueSaiuFoi : MonoBehaviour
{
    int naipeescolhido;
    int faceescolhida;
    string naipe;
    
    // Start is called before the first frame update
    void Start()
    {

        // Obrigado pela resposta rápida aos meus emails professor!

        Debug.Log("Eu quero fazer um experimento contigo");
        Debug.Log("Pressiona a tecla espaço para sacares uma carta");
        Debug.Log("E é só isso, diverte-te");

    }   
       
        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
            faceescolhida = Random.Range(1, 14);
            naipeescolhido = Random.Range(1, 5);

            if (naipeescolhido == 1)
            {
                naipe = (" de paus");
            }

            if (naipeescolhido == 2)
            {
                naipe = (" de ouros");
            }

            if (naipeescolhido == 3)
            {
                naipe = (" de copas");
            }

            if (naipeescolhido == 4)
            {
                naipe = (" de espadas");
            }

            if (faceescolhida == 10)
            {
                Debug.Log("Sacaste ás" + naipe);
            }

            if (faceescolhida == 11)
            {
                Debug.Log("Sacaste valete" + naipe);
            }

            if (faceescolhida == 12)
            {
                Debug.Log("Sacaste rainha" + naipe);
            }

            if (faceescolhida == 13)
            {
                Debug.Log("Sacaste rei" + naipe);
            }
            
            if (faceescolhida < 10)
            {
                Debug.Log("Sacaste " + faceescolhida + naipe);
            }
                Debug.Log("Pressiona espaço para sacares outra carta");
            }
        }
}
