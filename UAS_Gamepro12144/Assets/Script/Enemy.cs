using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Rigidbody2D rb;
    public float kecepatanGerak;
    public bool berbalik;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        berbalik = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (berbalik)
        {
            rb.velocity = new Vector2(kecepatanGerak, rb.velocity.y);
            transform.rotation = Quaternion.Euler(0f, 0f, 0f);
        }
        else
        {
            rb.velocity = new Vector2(-kecepatanGerak, rb.velocity.y);
            transform.rotation = Quaternion.Euler(0f, 180f, 0f); 
        }
    }
    private void OnTriggerEnter2D (Collider2D other)
    {
        if(other.gameObject.CompareTag("Balik"))
        {
            berbalik = !berbalik; 
        }
    }
}
