using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UzayGemisiKontrol : MonoBehaviour
{

    const float hareketGucu = 5; 

    bool topluyor = false;  // toplama iþlemi baþladýktan sonra bir daha gemiye týklasak bile hedeften þaþmýyor
    
    GameObject hedef; 

    Rigidbody2D myrigidbody2D; // uzay gemimizin hareketlerini kontrol etmek için fizik kurallarýna ihtiyacýmýz var.

    Toplayici toplayici; 

    // Start is called before the first frame update
    void Start()
    {
        // yukaradaki deðiþkenlerin hangi componentlara ait olduðunu belirtiyoruz.

        myrigidbody2D = GetComponent<Rigidbody2D>();   //uzay gemimizi ait olduðu için
        toplayici = Camera.main.GetComponent<Toplayici>(); // toplayici bileþenimiz main kamerada
    }

    void OnMouseDown()  // uzay gemimizi týkladýðýnda çaðýrýyor
    {
        if (!topluyor) // toplama iþlemi baþlamadýysa git topla
        {
            GitVeTopla();
        }
        
    }
    void OnTriggerStay2D(Collider2D other) // uzay gemimiz yildiz colliderine temas ettiðinde bize onu bildir. ( GitveTopla metodunu yaptýktan sonra) ( help scripts references)
    {
        if (other.gameObject == hedef)
        {
            toplayici.YildizYokEt(hedef);
            myrigidbody2D.velocity = Vector2.zero; // uzay gemimize etki eden kuvveti sýfýra çekmemiz lazým.
            GitVeTopla(); // toplanacak yýldýzlar var ise tekrardan git topla
        }
    }

    void GitVeTopla()
    {
        hedef = toplayici.HedefYildiz; // öncelikle hedefi istiyoruz.
        if(hedef !=null) // hedef var ise 
        {
            Vector2 gidilecekYer = new Vector2(hedef.transform.position.x - transform.position.x, 
                hedef.transform.position.y - transform.position.y); // uzay gemisini hedefteki yýldýzý gönderiyoruz

            gidilecekYer.Normalize(); //vektörel 2 noktayý birleþtirmesi için normalini alýyoruz.
            myrigidbody2D.AddForce(gidilecekYer * hareketGucu, ForceMode2D.Impulse); // gidip toplayan metod hazýr.
        }
    }

    // Update is called once per frame
    void Update()
    {

        //Vector3 position = transform.position;

        //float yatayInput = Input.GetAxis("Horizontal");
        //float dikeyInput = Input.GetAxis("Vertical");

        //if (yatayInput !=0)
        //{
        //    position.x += yatayInput * hareketGucu * Time.deltaTime;
        //}

        //if (dikeyInput !=0)
        //{
        //    position.y += dikeyInput * hareketGucu * Time.deltaTime;
        //}
        //transform.position = position;
    }
}


