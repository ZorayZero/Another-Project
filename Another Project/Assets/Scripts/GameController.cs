using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    Vector3 startPos;
    Rigidbody rb;
     

    private void Awake()
    {
        rb = GetComponent<Rigidbody>(); 
    }

    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("Obstacle"))
        {
            Die();
        }
    }
    
    void Die()
    {
       StartCoroutine(Respawn(0.5f));
    }

   IEnumerator Respawn(float duration)
   {
        rb.useGravity = false;
        rb.velocity = new Vector3(0,0,0);
        transform.localScale = new Vector3(0, 0, 0);
        yield return new WaitForSeconds(duration);
        transform.position = startPos;
        transform.localScale = new Vector3(1, 1, 1);
        rb.useGravity = true;
      
        
   }

    // Update is called once per frame
    void Update()
    {
        
    }
}
