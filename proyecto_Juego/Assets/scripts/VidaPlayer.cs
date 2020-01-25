using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VidaPlayer : MonoBehaviour
{
    public int vida;
    public int dano = 1;
    public Vidas vidaa;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void OnTriggerEnter(Collider other)
    {   
       
        if (other.CompareTag ("bala"))
        {
            Vidas.corazones.QuitarVida();
            vida = Vidas.corazones.vida;
            //vidaa.vida --;
            
        }
        if (other.CompareTag ("Vida"))
        {
           Vidas.corazones.AñadirVida();
           vida = Vidas.corazones.vida;
            vidaa.vida++;

        }
        
    }
}

