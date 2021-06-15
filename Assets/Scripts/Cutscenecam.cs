using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cutscenecam : MonoBehaviour
{

    public GameObject player;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void ActivePlayer()
    {
        player.SetActive(true);
        gameObject.SetActive(false);

    }
}
