using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class palmuertoScript : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioClip vooy;
    public AudioClip chillido;
    float speed = 0;
    void Start()
    {
        Invoke("empiezoacaminar", 2);
    }

    // Update is called once per frame
    void Update()
    {

        gameObject.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z + speed * Time.deltaTime);
    }

    void empiezoacaminar()
    {
        GetComponent<Animator>().SetBool("isinradius", true);
        GetComponent<AudioSource>().PlayOneShot(vooy);
        speed = 3;
        Invoke("empiezoacorrer", 1);
        
    }

    void empiezoacorrer()
    {
        GetComponent<Animator>().SetBool("acorrer", true);
        GetComponent<AudioSource>().PlayOneShot(chillido);
        speed = 8;
    }
}
