using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemymoves : MonoBehaviour
{
    
    public float value = 15f;
    public float velocity = 15f;
    float val1,val2;
    // Start is called before the first frame update
    void Start()
    {
        pipemove();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position= transform.position + new Vector3(val1,val2,0)* velocity * Time.deltaTime;
    }
    void pipemove(){
        val1 = Random.Range(-1f,1f);
        val2 = Random.Range(-1f,0f);

    }
}
