using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tembak : MonoBehaviour
{
    public GameObject prefabsPeluru;
    public Transform tempatTembak;
    public float kecepatanpeluru;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
           GameObject peluru =  Instantiate(prefabsPeluru, tempatTembak.position, tempatTembak.rotation);
            Rigidbody2D rbPeluru = peluru.GetComponent<Rigidbody2D>();
            rbPeluru.AddForce(tempatTembak.right * kecepatanpeluru, ForceMode2D.Impulse);
        }
    } 
}
