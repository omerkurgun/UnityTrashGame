using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class KazandimOlay : MonoBehaviour {
    public Button Oyna;
    public Button Cikis;
    void Start()
    {
        Oyna.GetComponent<Button>().onClick.AddListener(OyunBasla);
        Cikis.GetComponent<Button>().onClick.AddListener(OyunCikis);
    }
    void OyunBasla()
    {
        SceneManager.LoadScene(1);
    }
    void OyunCikis()
    {
        Application.Quit();
    }
}
