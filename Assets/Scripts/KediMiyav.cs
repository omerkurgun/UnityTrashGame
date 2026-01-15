using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KediMiyav : MonoBehaviour {
    public AudioSource KediSes;
    private bool temasKedi = false;
    public Text SureEkle;
    void Start () {
        KediSes = GetComponent<AudioSource>();
    }
    private void OnTriggerEnter(Collider Dokun)
    {
        if (Dokun.tag == "Firca")
        {
            temasKedi = true;
        }
    }
    private void OnTriggerExit(Collider Dokuns)
    {
        if (Dokuns.tag=="Firca")
        {
            temasKedi = false;
        }
    }
    void Update () {
        if (temasKedi)
        {
            KediSes.Play();
            if (float.Parse(SureEkle.text) > 0 && float.Parse(SureEkle.text)<100)
            {
                SureEkle.text = (float.Parse(SureEkle.text) + 5.0F).ToString();
            }
            GameObject Fircas = GameObject.FindWithTag("Oyuncu");
            Fircas.GetComponent<Transform>().transform.position = new Vector3(0,0,0);
            temasKedi = false;
        }
    }
}
