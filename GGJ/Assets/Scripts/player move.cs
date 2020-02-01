using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermove : MonoBehaviour
{
    public float Salto = 2.5f;
    public float Velocidad = 2.5f;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float MovHorizontal = Input.GetAxisRaw("Horizontal");
    }
    
}
