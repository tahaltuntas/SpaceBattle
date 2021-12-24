using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YokEdici : MonoBehaviour
{
    [SerializeField]    
    GameObject patlamaPrefab;    

    GeriSayimSayici yokEdiciGeriSayim;

    // Start is called before the first frame update
    void Start()
    {
        yokEdiciGeriSayim = gameObject.AddComponent<GeriSayimSayici>();  
        yokEdiciGeriSayim.ToplamSure = Random.Range(1,20);
        yokEdiciGeriSayim.Calistir();
    }

    // Update is called once per frame
    void Update()
    {
        if (yokEdiciGeriSayim.Bitti)
        {
            Instantiate(patlamaPrefab, gameObject.transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
