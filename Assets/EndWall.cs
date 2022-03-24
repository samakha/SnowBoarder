using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class EndWall : MonoBehaviour
{
    [SerializeField] ParticleSystem finishParticle;
    [SerializeField] float delayTime = 1.4f;
    
  private   void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            finishParticle.Play();
            GetComponent<AudioSource>().Play(); 
            Invoke("ReloadScene", delayTime);

              

        }
    }
     void ReloadScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
