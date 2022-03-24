using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class CollisionManager : MonoBehaviour
{
    [SerializeField] ParticleSystem crashParticle; 
    [SerializeField] float delayTime = 1f;
    [SerializeField] AudioClip audioSFX;


    private void OnTriggerEnter2D(Collider2D collision) // head 
    {
           if (collision.gameObject.tag == "Ground")
        {

            GetComponent<AudioSource>().PlayOneShot(audioSFX); 
            
            FindObjectOfType<PlayerController>().DisableControl();
          //    GetComponent<CollisionManager>().enabled = false; 
            Invoke("ReloadScene", delayTime);

           
        }
       
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag =="Ground")
        {
 crashParticle.Play();
        }
    }


    public void ReloadScene( )
    {
        SceneManager.LoadScene(0);
    }
}
