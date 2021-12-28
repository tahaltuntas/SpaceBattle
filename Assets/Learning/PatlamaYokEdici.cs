using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatlamaYokEdici : MonoBehaviour
{
    GeriSayimSayici geriSayimSayici;

    SiraliYokEdici siraliYokEdici;
    
    
    // Start is called before the first frame update
    void Start()
    {
        geriSayimSayici = gameObject.AddComponent<GeriSayimSayici>();
        siraliYokEdici = Camera.main.GetComponent<SiraliYokEdici>();
        geriSayimSayici.ToplamSure = 1;
        geriSayimSayici.Calistir();
    }

    // Update is called once per frame
    void Update()
    {
        if (geriSayimSayici.Bitti)
        {
            siraliYokEdici.HedefiYokEt();
            Destroy(gameObject);
        }
    }
}
