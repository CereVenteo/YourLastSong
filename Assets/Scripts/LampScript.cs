using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LampScript : MonoBehaviour
{
    public PlayerThings player;
    public GameObject mylight;
    bool b_light;
    bool a_la_mierda;

    public GameObject[] walls;
    public GameObject photo;
    public GameObject photo2;
    public GameObject radio;
    public GameObject radio2;
    public Material wall2;
    public Material wall3;
    public GameObject elmuerto;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(ChangeLight());
    }

    // Update is called once per frame
    void Update()
    {
        if (player.photo && player.radio)
        {
            
            if (!player.lamp)
            {
                mylight.SetActive(b_light);
                GetComponent<ObjectScript>().is_used = false;
            }
            else if (!a_la_mierda)
            {
                a_la_mierda = true;
                StopCoroutine(ChangeLight());
                mylight.SetActive(false);
                Invoke("MeCagoDuranteDosSegundos", 1);
            }
            
        }
        if(player.photo2 && player.radio2)
        {
            if(a_la_mierda && player.lamp)
            {
                StartCoroutine(ChangeLight());
                a_la_mierda = false;
                player.photo = false;
                player.radio = false;
                player.lamp = false;
            }
            else if(!a_la_mierda && !player.lamp)
            {
                mylight.SetActive(b_light);
                GetComponent<ObjectScript>().is_used = false;
            }
            else if(!a_la_mierda && player.lamp)
            {
                a_la_mierda = true;
                player.lamp = false;
                StopCoroutine(ChangeLight());
                mylight.SetActive(false);
                Invoke("MeCagoDuranteDosSegundos", 1);
            }
        }
        
    }

    IEnumerator ChangeLight()
    {
        while(true)
        {
            b_light = !b_light;
            yield return new WaitForSeconds(Random.Range(0.05f, 0.3f));
        }
    }

    void MeCagoDuranteDosSegundos()
    {
        MiPutaFuncionQueMola();
        mylight.SetActive(true);
    }


    void MiPutaFuncionQueMola()
    {
        if (player.photo && player.radio && player.lamp)
        {
            //Aqui cambio al segundo ciclo.
            for (int i = 0; i < walls.Length; i++)
            {
                walls[i].GetComponent<MeshRenderer>().material = wall2;
            }

            photo.SetActive(false);
            radio.SetActive(false);
            photo2.SetActive(true);
            radio2.SetActive(true);
        }

        if (player.photo2 && player.radio2)
        {
            //Aquí cambio al tercer ciclo
            for (int i = 0; i < walls.Length; i++)
            {
                walls[i].GetComponent<MeshRenderer>().material = wall3;
            }

            elmuerto.SetActive(true);
        }
        
    }
}
