using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityFlip : MonoBehaviour
{
    public Rigidbody2D avatarRigidbody;
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        {
            if (Input.GetButtonDown("Jump"))
            {
                Vector3 newDirection = transform.localScale;
                avatarRigidbody.gravityScale *= -1;
                newDirection.y *= -1;
                transform.localScale = newDirection;
            }
        }
    }
}
