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
    public GameObject photo3;
    public GameObject radio;
    public GameObject radio2;
    public GameObject radio3;
    public Material wall2;
    public Material wall3;
    public Material wall4;
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
            else
            {
                if (!a_la_mierda)
                {
                    a_la_mierda = true;
                    StopCoroutine(ChangeLight());
                    mylight.SetActive(false);
                    Invoke("MeCagoDuranteDosSegundos", 2);
                }
            }
        }
        
    }

    IEnumerator ChangeLight()
    {
        while(true)
        {
            b_light = !b_light;
            yield return new WaitForSeconds(0.1f);
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
            elmuerto.SetActive(true);

            if (player.photo2 && player.radio2)
            {
                //Aquí cambio al tercer ciclo
                for (int i = 0; i < walls.Length; i++)
                {
                    walls[i].GetComponent<MeshRenderer>().material = wall3;
                }

                if (player.photo3 && player.radio3)
                {
                    for (int i = 0; i < walls.Length; i++)
                    {
                        walls[i].GetComponent<MeshRenderer>().material = wall4;
                    }
                }
            }
        }
    }
}
