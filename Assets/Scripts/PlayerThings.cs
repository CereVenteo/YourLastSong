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
   

    void Start()
    {
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
