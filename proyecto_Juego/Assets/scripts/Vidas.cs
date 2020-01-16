using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vidas : MonoBehaviour
{
    public GameObject[] Corazones;
    public int vida = 5;
    public static Vidas corazones;

    // Start is called before the first frame update
    void Start()
    {
        corazones = this;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void QuitarVida()
    {
        //if (vida <= 0)
        //{
        //    SceneManager.LoadScene("GameOver");
        //    return;
        //}

        vida -= 1;
        Corazones[vida].SetActive(false);

    }
}
