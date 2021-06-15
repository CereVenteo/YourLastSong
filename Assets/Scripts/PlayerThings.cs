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
    public GameObject finscenecam;
    public GameObject player;
    public GameObject photo1;
    public GameObject photo_2;

    public Animator fincam;
    public Animator animcam;
    public Animator animphoto1;
    public Animator animphoto2;


    void Start()
    {
        animcam = cutscenecam.GetComponent<Animator>();
        fincam = finscenecam.GetComponent<Animator>();
        animphoto1 = photo1.GetComponent<Animator>();
        animphoto2 = photo_2.GetComponent<Animator>();
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

                    cutscenecam.SetActive(true);
                    player.SetActive(false);

                    animcam.Play("cutscenecam_3");
                    animphoto2.Play("photo2");

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

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("LOOOOOOOOOL");
         if(other.gameObject.tag == "Door")
        {
            Debug.Log("OTOKO");
            finscenecam.SetActive(true);
            fincam.Play("Camfin");
        }
    }

}
