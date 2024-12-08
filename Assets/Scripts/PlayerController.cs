using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
        Movement();
    }


    private void Movement()
    {
        Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 myPosition = rb.position;

        myPosition.y = Mathf.Lerp(myPosition.y, mousePosition.y, 10);
        myPosition.y = Mathf.Clamp(myPosition.y, -3.7f, 3.7f);
        rb.position = myPosition;
    }
}
