using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Toplayici : MonoBehaviour
{

    [SerializeField]
    GameObject yildizPrefab;

    List<GameObject> yildizlar = new List<GameObject>();

    /// <summary>
    /// Hedefteki yýldýzý söyler
    /// </summary>
    public GameObject HedefYildiz
    {
        get
        {
            if (yildizlar.Count > 0) // yýldýzlar listemizde toplanacak yýldýz var mý
            {
                return yildizlar[0];
            }
            else
            {
                return null;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            Vector3 position = Input.mousePosition;
            position.z = -Camera.main.transform.position.z; // z eksenini kameraya göre ayarlýyoruz.
            Vector3 oyunDunyasiPosizyon = Camera.main.ScreenToWorldPoint(position); // piksellere gelen deðerleri oyun dünyasýna çeviriyoruz.
            yildizlar.Add(Instantiate(yildizPrefab, oyunDunyasiPosizyon, Quaternion.identity)); // artýk yýldýz instantiate olur olmaz yildizlar list in içine eklenicek 
        }
    }

    /// <summary>
    /// Parametre olarak gönderilen yýldýzý yok eder.
    /// </summary>
    /// <param name="yokEdilecekYildiz"></param>
    public void YildizYokEt(GameObject yokEdilecekYildiz)
    {
        yildizlar.Remove(yokEdilecekYildiz); // önce listin içerisinden çýkartýyoruz.
        Destroy(yokEdilecekYildiz); // oyun ekranýndan yok ediyoruz.
    }
}
