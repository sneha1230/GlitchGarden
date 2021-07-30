using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        AudioManager.instance.PlayAudio("Background");
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Enemy")
        {
            FindObjectOfType<AudioManager>().PlayAudio("PlayerDeath");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
