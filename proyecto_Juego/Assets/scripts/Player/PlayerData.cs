using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerData : MonoBehaviour
{
    public int vida;
    public int vidaMax;

    public int vidas;

    // Start is called before the first frame update
    void Start()
    {
        vida = vidaMax;
    }

    // Update is called once per frame
    void Update()
    {
        if (vida <= 0)
        {
            //vidas--;

            //if (vidas <= 0)
            //{
            //    //has muerto
            //    SceneManager.LoadScene("GameOver");
            //}
            //else
            //{
            //    vida = vidaMax;
            //}
        }

    }
}
