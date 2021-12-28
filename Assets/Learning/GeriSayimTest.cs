using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeriSayimTest : MonoBehaviour
{

    GeriSayimSayici geriSayimSayici;
    float baslangicZamani;

    // Start is called before the first frame update
    void Start()
    {
        geriSayimSayici = gameObject.AddComponent<GeriSayimSayici>();
        geriSayimSayici.ToplamSure = 3;
        geriSayimSayici.Calistir();

        baslangicZamani = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if (geriSayimSayici.Bitti)
        {
            float gecenSure = Time.time - baslangicZamani;
            Debug.Log(gecenSure);

            baslangicZamani = Time.time;
            geriSayimSayici.Calistir();
        }
    }
}
