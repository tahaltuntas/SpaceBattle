using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kursun : MonoBehaviour
{
    GeriSayimSayici geriSayimSayaci;
    
    
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 10), ForceMode2D.Impulse); //kurþun deðeri oluþur oluþmaz yukarý doðru hareket edecek. - hýzý deðerleri deðiþtirerek
        geriSayimSayaci = gameObject.AddComponent<GeriSayimSayici>();
        geriSayimSayaci.ToplamSure = 3;
        geriSayimSayaci.Calistir();
    }

    // Update is called once per frame
    void Update()
    {
        if (geriSayimSayaci.Bitti) // kurþun uzayda kaybolduktan sonra backgroundda silinmesine saðlar
        {
            Destroy(gameObject);
        }
    }

     void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Asteroid") // kurþun asteroidi yok ettikten sonra kaybolsun- tag ekleyerek yaptýk
        {
            Destroy(gameObject);
        } 
    }
}
