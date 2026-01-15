using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CopFircasi : MonoBehaviour
{
    public int OyunSuresi = 100;
    public Text SureText;
    public Text TxtKontrol;
    private bool temasFircamiz = false;
    private void OnTriggerEnter(Collider Dokun)
    {
        if (Dokun.tag == "Cop")
        {
            temasFircamiz = true;
        }
    }
    private void OnTriggerExit(Collider Dokuns)
    {
        if (Dokuns.tag == "Cop")
        {
            temasFircamiz = false;
        }
    }
    void Start()
    {
        temasFircamiz = false;
        SureText.text = ((float)OyunSuresi).ToString();
    }
    void Update()
    {
        SureText.text = (float.Parse(SureText.text) - Time.deltaTime).ToString();
        if ((float.Parse(SureText.text) - Time.deltaTime) <= 0)
        {
            SceneManager.LoadScene(2);
        }
    }
}
