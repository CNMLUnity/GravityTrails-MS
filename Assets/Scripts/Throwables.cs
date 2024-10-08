using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Throwables : MonoBehaviour
{
    public int throwableCounter;
    public Vector3 offset;
    public GameObject objectThrown;
    public Text collectableCounter;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "GetKilled" || collision.gameObject.tag == "Collectable")
        {
            throwableCounter += 1;
            collectableCounter.text = throwableCounter.ToString();
            Destroy(collision.gameObject);
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1") && throwableCounter > 0)
        {
            offset =  transform.localScale.x * new Vector3(2, 0, 0);
            Vector3 throwablePosition = transform.position + offset; 
            Instantiate(objectThrown, throwablePosition, transform.rotation);
            throwableCounter -= 1;
            collectableCounter.text = throwableCounter.ToString();
        }
    }
}
