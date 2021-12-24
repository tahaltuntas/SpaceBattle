using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HareketKontrol : MonoBehaviour
{
    // Start is called before the first frame update

    void Start()
    {
        // Uzay Gemisini Hareket Ettir
        GetComponent<Rigidbody2D>().AddForce(new Vector2(5, 5), ForceMode2D.Impulse);

    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Kemerlerinizi Baðlayýn!");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
