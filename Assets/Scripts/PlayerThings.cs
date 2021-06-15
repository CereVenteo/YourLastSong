using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerThings : MonoBehaviour
{
    // Start is called before the first frame update

    public bool lamp = false;
    public bool photo = false;
    public bool photo2 = false;
    public bool radio = false;
    public bool radio2 = false;

    public GameObject interactable;
    public GameObject cutscenecam;
    public GameObject player;
    public GameObject photo1;


    public Animator animcam;
    public Animator animphoto1;


    void Start()
    {
        animcam = cutscenecam.GetComponent<Animator>();
        animphoto1 = photo1.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (interactable != null)
            {
                interactable.gameObject.GetComponent<ObjectScript>().is_used = true;

                if (interactable.name == "Lamp" && lamp == false)
                    lamp = true;
                else if (interactable.name == "Photo" && photo == false)
                {
                    cutscenecam.SetActive(true);
                    
                    player.SetActive(false);

                    animcam.Play("cutscenecam");
                    animphoto1.Play("photo1");

                    interactable.GetComponent<AudioSource>().Play();
                   
                    photo = true;
                }
                else if (interactable.name == "Photo2" && photo2 == false)
                {
                    interactable.GetComponent<AudioSource>().Play();
                    photo2 = true;
                }
                else if (interactable.name == "Radio" && radio == false) 
                { 
                    interactable.GetComponent<AudioSource>().Play();
                    radio = true;
                }
            else if (interactable.name == "Radio2" && radio2 == false)
                radio2 = true;
            }
        }
    }
}
