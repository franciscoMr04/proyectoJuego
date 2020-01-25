using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Vidas : MonoBehaviour
{
    public GameObject[] Corazones;
    public int vida = 3;
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

    public void AñadirVida()
    {
        if (vida >= 0)
        {
            vida++;
        }
        
        //Corazones[vida].SetActive(false);

    }

    public void QuitarVida()
    {
        if (vida <= 0)
        {
            SceneManager.LoadScene("muerte");
            return;
        }

        vida -= 1;
        Corazones[vida].SetActive(false);

    }
}
