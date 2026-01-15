using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Oyuncumuz : MonoBehaviour {
    public float Hiz = 15.0F;
    public float YerCekim = 2.31F;
    public GameObject[] RastgeleNesneler;
    public int RastgeleSayi = 50;
    public Vector3 RstSinirlama;
    CharacterController OKontrol;
    void Start()
    {
        OKontrol = GetComponent<CharacterController>();
        RastgeleGetir();
    }
    void Update()
    {
        float Yatay = Input.GetAxis("Horizontal")*Hiz;
        float Dikey = Input.GetAxis("Vertical")*Hiz;
        Vector3 Hareket = new Vector3(Yatay,0,Dikey);
        Hareket.y = YerCekim;
        Hareket = Vector3.ClampMagnitude(Hareket, Hiz);
        Hareket *= Time.deltaTime;
        Hareket = transform.TransformDirection(Hareket);
        OKontrol.Move(Hareket);

    }
    void RastgeleGetir()
    {
        for(int i =0;i<RastgeleSayi;i++)
        {
            Vector3 RastgeleNokta = new Vector3(Random.Range(-RstSinirlama.x,RstSinirlama.x),RstSinirlama.y, Random.Range(-RstSinirlama.z, RstSinirlama.z));
            Instantiate(RastgeleNesneler[Random.Range(0,RastgeleNesneler.Length)],RastgeleNokta,Quaternion.identity);
        }
    }
}
