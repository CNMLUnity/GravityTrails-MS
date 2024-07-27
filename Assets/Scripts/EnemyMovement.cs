using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;


public class EnemyMovement : MonoBehaviour
{
    public float maxXPosition;
    public float minXPosition;
    public float xDirection;
    // public int enemiesRemaining;

    
    public Rigidbody2D enemyRigidBody;
    
    // Start is called before the first frame update
    void Start()
    {
        // enemiesRemaining = 6;
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        if(transform.position.x < minXPosition)
        {
            transform.position = new Vector3(minXPosition, transform.position.y, transform.position.z);
            xDirection *= -1;
            gameObject.GetComponent<Rigidbody2D>().velocity = Vector3.zero;

        }

        if (transform.position.x > maxXPosition)
        {
            xDirection *= -1;
            transform.position = new Vector3(maxXPosition, transform.position.y, transform.position.z);
            gameObject.GetComponent<Rigidbody2D>().velocity = Vector3.zero;

        }
        gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.right * 10 * xDirection);

    }

    
}
