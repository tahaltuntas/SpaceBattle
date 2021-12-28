using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemiKontrol : MonoBehaviour
{
    [SerializeField]
    GameObject kursunPrefab = default;
    
    [SerializeField]
    GameObject patlamaPrefab = default;

    const float hareketGucu = 6;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 position = transform.position;

        float yatayInput = Input.GetAxis("Horizontal");
        float dikeyInput = Input.GetAxis("Vertical");

        if (yatayInput != 0)
        {
            position.x += yatayInput * hareketGucu * Time.deltaTime;
        }

        if (dikeyInput != 0)
        {
            position.y += dikeyInput * hareketGucu * Time.deltaTime;
        }
        transform.position = position;

        if (Input.GetButtonDown("Jump"))  //space tuþuna bastýðýnda uzay gemimizin 1 birim üstünden ateþleme yapýyor.
        {
            Vector3 kursunPozisyon = gameObject.transform.position;
            kursunPozisyon.y += 1;
            Instantiate(kursunPrefab, kursunPozisyon, Quaternion.identity);
        }
    }

    void OnCollisionEnter2D(Collision2D col)  
    {
        if (col.gameObject.tag =="Asteroid") // gemi asteroid ile temas ettiðinde gemi patlýyor- tag ile gerçekleþtirdik
        {
            Instantiate(patlamaPrefab, gameObject.transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
