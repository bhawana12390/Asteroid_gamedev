using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class missileMoves : MonoBehaviour
{

    public float missileSpeed = 100f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * missileSpeed * Time.deltaTime);
    }
    public void OnCollisionEnter2D(Collision2D Collision){
        Debug.Log("1");
        
        Destroy(this.gameObject);
        Destroy(Collision.gameObject);
        
    }
}
