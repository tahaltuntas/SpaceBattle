using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputKontrol : MonoBehaviour
{
    [SerializeField]
    GameObject asteroidPrefab;

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

            Instantiate(asteroidPrefab, position, Quaternion.identity);
        }

        if (Input.GetMouseButton(0))
        {
            Debug.Log("Pressed left click");
        }

        if (Input.GetMouseButton(1))
        {
            Debug.Log("Pressed right click");
        }

        if (Input.GetMouseButton(2))
        {
            Debug.Log("Pressed middle click");
        }

       
    }
}
