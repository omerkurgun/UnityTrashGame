using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CopKutusu : MonoBehaviour {
    AudioSource KutuSes;
    public Text KazanilanPuan;
    private bool temasKutu = false;
    void Start()
    {
        KutuSes = GetComponent<AudioSource>();
    }
    private void OnTriggerEnter(Collider Dokun)
    {
        if (Dokun.tag == "Cop")
        {
            temasKutu = true;
            Destroy(Dokun.gameObject);
        }
    }
    private void OnTriggerExit(Collider Dokuns)
    {
        if (Dokuns.tag == "Cop")
        {
            temasKutu = false;
        }
    }
    void Update()
    {
        if(int.Parse(KazanilanPuan.text.ToString())>=20)
        {
            SceneManager.LoadScene(3);
        }
        if (temasKutu)
        {
            KazanilanPuan.text = (int.Parse(KazanilanPuan.text.ToString())+1).ToString();
            KutuSes.Play();
            temasKutu = false;
        }
    }
}
