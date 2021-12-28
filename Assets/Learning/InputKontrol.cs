using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputKontrol : MonoBehaviour
{
    [SerializeField]
    GameObject asteroidPrefab;

    List<GameObject> asteroidList = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
           // Debug.Log(Input.mousePosition);

            Vector3 position = Input.mousePosition;
            position.z = -Camera.main.transform.position.z;
            position = Camera.main.ScreenToWorldPoint(position);


            for(int i =0; i < 20; i++)
            {
                asteroidList.Add(Instantiate(asteroidPrefab, position, Quaternion.identity));
            }

        }

        //if (Input.GetMouseButton(0))
        //{
        //    Debug.Log("Pressed left click");
        //}


        

        if (Input.GetMouseButton(1))
        {
            Debug.Log(asteroidList.Count); // asteroidList içerisindeki eleman sayýmýzý gösteriyor.
            
            foreach (GameObject asteroid in asteroidList) // asteroidList miz içerisinde asteroid alias ý ile beraber hepsini dolaþýp yok ediyoru. Türü gameObject)
            {
                Destroy(asteroid);
            }

            asteroidList.Clear(); //her týkladýðýmýzda elemanlar oluþuyor ve bir sonraki týklamamýza önceki listteki sayý ekleniyor, gereksiz eleman fazlalýðý olmamasý için yapýyoruz.

        }


       
        //    for (int i = 0; i < asteroidList.Count; i++)
        //    {
        //        Destroy(asteroidList[i]);
        //    }
        //}

        //if (Input.GetMouseButton(2))
        //{
        //    Debug.Log("Pressed middle click");
        //}


    }
}
