using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OyunKontrol : MonoBehaviour
{
    [SerializeField]
    GameObject uzayGemisiPrefab;

    [SerializeField]
    List<GameObject> asteroidPrefabs = new List<GameObject>();
        
    GameObject uzayGemisi;
    List<GameObject> asteroidList = new List<GameObject>(); //ekranda kaçtane asteroid olduðumuzu daha sonrasýnda bilmemiz lazým, ürettiðimiz asteroidler bu listeye

    [SerializeField]
    int zorluk = 1;
    [SerializeField]
    int carpan = 4;

    // Start is called before the first frame update
    void Start()
    {
       uzayGemisi =  Instantiate(uzayGemisiPrefab); //uzay gemisinin oluþmasý için instantiate veriyoruz.
       uzayGemisi.transform.position = new Vector3(0, EkranHesaplayicisi.Alt + 1.5f); // uzay gemisinin baþlangýç konumunu belirliyoruz.

        AsteroidUret(5); // asteroiduret metodunu çaðýrýyoruz ve 5 tane metod kurallarýna göre üretiyor.
    }

   

    void AsteroidUret(int adet)
    {
        Vector3 position = new Vector3(); // her bir asteroidin konumu için

        for (int i = 0; i < adet; i++)
        {
            position.z = -Camera.main.transform.position.z; // kamerayý referans alarak oluþturuyoruz.
            position = Camera.main.ScreenToWorldPoint(position); // oyun dünyasýnýn koordinatlarýna çeviriyoruz.
            position.x = Random.Range(EkranHesaplayicisi.Sol, EkranHesaplayicisi.Sag); //asteroidlerin x deðeri kameranýn sað ve sol aralýklarý olucak
            position.y = EkranHesaplayicisi.Ust - 1; //asteroidlerin y deðerini ust kýsýmdan biraz daha aþþaðýda olucak.

            GameObject asteroid = Instantiate(asteroidPrefabs[Random.Range(0, 2)], position, Quaternion.identity); // asteroidler 3 tane olduðu için random, konumunu , rotasyonunda deðiþiklik olmasýn diye
            asteroidList.Add(asteroid);


        }
    }

    public void AsteroidYokOldu(GameObject asteroid)
    {
        asteroidList.Remove(asteroid);
        if (asteroidList.Count <= zorluk)
        {
            zorluk++;
            AsteroidUret(zorluk *carpan);
        }
    }
}
