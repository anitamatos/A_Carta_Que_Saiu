using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ACartaQueSaiuFoi : MonoBehaviour
{
    string[] figuras;
    string[] pintas;

    // Start is called before the first frame update
    void Start()
    {
        figuras = new[] { "Ás", "Rei", "Dama", "Valete", "10", "9", "8", "7", "6", "5", "4", "3", "2" };
        pintas = new[] { "Copas", "Espadas", "Ouros", "Paus" };
        Debug.Log("Olá, queres uma carta do meu baralho? Carrega no espaço");
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            int figura = Random.Range(0, 12);
            int pinta = Random.Range(0, 3);

            Debug.Log("Saiu a carta " + figuras[figura] + " " + pintas[pinta]);
        }
    }
}
