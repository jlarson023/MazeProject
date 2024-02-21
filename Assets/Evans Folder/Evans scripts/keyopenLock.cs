using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keyopenLock : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Lock"))
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }
}
