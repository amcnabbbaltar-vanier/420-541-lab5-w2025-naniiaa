using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    private Animator animator;
    private ParticleSystem hitParticles;
    private AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        hitParticles = GetComponent<ParticleSystem>();
        audioSource = GetComponent<AudioSource>();
    }


    public void GotHit()
    {
        animator.SetTrigger("GotHit");
        hitParticles.Play();
        audioSource.Play();
        GameManager.Instance.IncrementScore();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
