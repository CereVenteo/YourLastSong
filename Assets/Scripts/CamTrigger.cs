using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CamTrigger : MonoBehaviour
{

    public PlayerThings player;
    public Text text;
    // Start is called before the first frame update


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Interactable" && !other.gameObject.GetComponent<ObjectScript>().is_used)
        {
            text.gameObject.SetActive(true);
            player.interactable = other.gameObject;
        }
            
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Interactable")
        {
            text.gameObject.SetActive(false);
            player.interactable = null;
        }
    }
}
