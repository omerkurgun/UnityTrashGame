using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KopekHav : MonoBehaviour {
    public AudioSource KopekSes;
    private bool temasKopek = false;
    public Text KalanText;
    void Start()
    {
        KopekSes = GetComponent<AudioSource>();
    }
    private void OnTriggerEnter(Collider Dokun)
    {
        if (Dokun.tag == "Firca")
        {
            temasKopek = true;
        }
    }
    private void OnTriggerExit(Collider Dokuns)
    {
        if (Dokuns.tag == "Firca")
        {
            temasKopek = false;
        }
    }
    void Update () {
        if (temasKopek)
        {
            KopekSes.Play();
            if(float.Parse(KalanText.text)>0)
            {
                KalanText.text = (float.Parse(KalanText.text) - 5.0F).ToString();
            }
            GameObject Fircas = GameObject.FindWithTag("Oyuncu");
            Fircas.GetComponent<Transform>().transform.position = new Vector3(0, 0, 0);
            temasKopek = false;
        }
    }
}
