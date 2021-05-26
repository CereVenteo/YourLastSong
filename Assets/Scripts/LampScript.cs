using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LampScript : MonoBehaviour
{
    public PlayerThings player;
    public GameObject mylight;
    bool b_light;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(ChangeLight());
    }

    // Update is called once per frame
    void Update()
    {

        if(!player.lamp)
        {
            mylight.SetActive(b_light);
        }
        else
        {
            mylight.SetActive(true);
            StopCoroutine(ChangeLight());
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
}
