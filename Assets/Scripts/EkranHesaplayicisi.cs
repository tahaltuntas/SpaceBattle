using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class EkranHesaplayicisi
{
    static float sol;
    static float sag;
    static float ust;
    static float alt;


    /// <summary>
    /// Ekrarnýn Sol kenarýnýn koordinatlarýný verir.
    /// </summary>
    public static float Sol
    {
        get
        {
            return sol;
        }
    }

    public static float Sag
    {
        get
        {
            return sag;
        }
    }

    public static float Ust
    {
        get
        {
            return ust;
        }
    }

    public static float Alt
    {
        get
        {
            return alt;
        }
    }

    public static void Init()
    {
        float ekranZekseni = -Camera.main.transform.position.z;
        Vector3 solAltKose = new Vector3(0, 0, ekranZekseni);
        Vector3 sagUstKose = new Vector3(Screen.width, Screen.height, ekranZekseni);

        Vector3 solAltKoseOyunDunyasi = Camera.main.ScreenToWorldPoint(solAltKose);
        Vector3 sagUstKoseOyunDunyasi = Camera.main.ScreenToWorldPoint(sagUstKose);

        sol = solAltKoseOyunDunyasi.x;
        sag = sagUstKoseOyunDunyasi.x;
        ust = sagUstKoseOyunDunyasi.y;
        alt = solAltKoseOyunDunyasi.y;

        ;
    }
}
