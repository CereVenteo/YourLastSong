using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Triggers : MonoBehaviour
{
    // Start is called before the first frame update

    public PlayerThings player;
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

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnTriggerEnter(Collider other)
    {
        if(player.photo && player.radio && player.lamp)
        {
            //Aqui cambio al segundo ciclo.
            for(int i = 0; i< walls.Length; i++)
            {
                walls[i].GetComponent<MeshRenderer>().material = wall2;
            }

            photo.SetActive(false);
            radio.SetActive(false);


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
