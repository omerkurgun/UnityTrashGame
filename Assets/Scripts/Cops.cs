using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cops : MonoBehaviour {
    bool temasCop = false;
    GameObject Fircas;
    void Start()
    {
        Fircas = GameObject.FindWithTag("Firca");
    }
    private void OnTriggerEnter(Collider Dokun)
    {
        if (Dokun.tag == "Firca")
        { 
            temasCop = true;
            GetComponent<Rigidbody>().isKinematic = false;
        }
    }
    private void OnTriggerExit(Collider Dokuns)
    {
        if (Dokuns.tag == "Firca")
        {
            temasCop = false;
            GetComponent<Rigidbody>().isKinematic = false;
        }
    }
    void Update()
    {
        if (GetComponent<Transform>().position.y < 0.5F)
        {
            GetComponent<Rigidbody>().isKinematic = true;
        }
        if (temasCop)
        {
            if (Input.GetButton("Fire1"))
            {
                GetComponent<Transform>().position = new Vector3(Fircas.transform.position.x, Fircas.transform.position.y, Fircas.transform.position.z);
            }
        }
    }
}
