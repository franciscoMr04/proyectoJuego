using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class puntos : MonoBehaviour
{
    private float Puntos = 00.0f;

    public Text PuntosText;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Puntos += Time.deltaTime;
        PuntosText.text = ((int)Puntos).ToString();
    }


}
