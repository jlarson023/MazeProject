using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hazrd : MonoBehaviour
{
    Animator animator;
    public float delay;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
       
        animator.SetTrigger("Explosion");

        Destroy(gameObject, delay);
        Destroy(collision.gameObject);
    }
}
