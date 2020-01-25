using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static int score = 0;
    public string ScoreString = "puntos";

    public bool heGanado;
    public bool hePerdido;
    public int vidas;

    public Text TextScore;
    public static GameManager gameManager;
    public GameObject player;

    void Awake()
    {
        gameManager = this;
    }


    // Use this for initialization
    void Start()
    {

        vidas = 3;
        heGanado = false;
        player = GameObject.Find("Player");

        DontDestroyOnLoad(this);
    }

    // Update is called once per frame
    void Update()
    {
        if (TextScore != null)
        {
            TextScore.text = ScoreString + score.ToString();
        }

        

        if (vidas <= 0)
        {
            hePerdido = true;

        }



    }
}

