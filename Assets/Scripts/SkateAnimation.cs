using Unity.VisualScripting;
using UnityEngine;

public class SkateAnimation : MonoBehaviour
{
    [SerializeField] ParticleSystem skateEffect;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag == "ground")
        {
            skateEffect.Play();
        }
    }

    void OnCollisionExit2D(Collision2D other)
    {
        skateEffect.Stop();
    }
}
