using UnityEngine;
using UnityEngine.SceneManagement;
public class Crashdetector : MonoBehaviour
{
    [SerializeField] ParticleSystem crashEffect;
    bool hasCrashed = false;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created 
    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player" && !hasCrashed)
        {
            FindAnyObjectByType<PlayerController>().DisableControls();
            crashEffect.Play();
            Invoke("ReloadScene",1.0f);
            hasCrashed = true;
        }
    }

    
    void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}
