using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyCollision : MonoBehaviour
{
    public GameObject enemy;
    public Teleport tpScript;
    public int enemyCount;
    private int currentScene;
    // Start is called before the first frame update
    void Start()
    {
        currentScene = SceneManager.GetActiveScene().buildIndex;
        if(currentScene == 0){
            tpScript = GameObject.Find("Portal").GetComponent<Teleport>(); 
            
            //enemyCount = tpScript.enemyCount;
            print("starting count: "+ tpScript.enemyCount);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        if(collision.gameObject.tag == "Player")
        {
            SceneManager.LoadScene(0);
        }
        if(collision.gameObject.tag == "GetKilled")
        {
            print("collision");
            Destroy(collision.gameObject);
            Destroy(enemy);
            if(currentScene == 0){
                tpScript.enemyCount--;
                print("killed enemy: "+ tpScript.enemyCount);
            }
        }
    }
}
