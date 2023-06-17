using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermove : MonoBehaviour
{
    public float speedh = 10f;
    public float speed = 100f;
    public GameObject missile;
    public Transform missileposition;
    public float destroyTime = 5f;
    Vector3 currentPos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       playerMovement();
       missilespawn();
    }

    void playerMovement()
    {
        float xpos = Input.GetAxis("Horizontal");
        float ypos = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(xpos,ypos,0)* speedh * Time.deltaTime;
        //transform.Translate(movement);
        transform.position = transform.position + movement;

        if(Input.GetKey("r")==true){
            currentPos = currentPos + new Vector3(0,0,1) * speed * Time.deltaTime;
            transform.localEulerAngles = currentPos;
        }
        if(Input.GetKey("y")==true){
            currentPos = currentPos + new Vector3(0,0,-1) * speed * Time.deltaTime;
            transform.localEulerAngles = currentPos;
        }
    }
    void missilespawn(){
        if(Input.GetKeyDown(KeyCode.Space)){
            GameObject missileee = Instantiate(missile,missileposition);
            missileee.transform.SetParent(null);
            Destroy(missileee, destroyTime);
        }
    }
}
