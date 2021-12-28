using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Rigidbody2D rb2d = GetComponent<Rigidbody2D>(); // asteroide kuvvet ekliyoruz

        float yon = Random.Range(0f, 1.0f); // asteroidin iniþ yönünü random ayarlýyoruz.
        if (yon < 0.5)
        {
            rb2d.AddForce(new Vector2(Random.Range(-2.5f, -1.0f), Random.Range(-2.5f, -1.0f)), ForceMode2D.Impulse); //asteroidlerin iniþ koordinatý ve hýzlarýný belirliyoruz.

        }
        else
        {
           rb2d.AddForce(new Vector2(2, -2), ForceMode2D.Impulse);
        }
       

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
