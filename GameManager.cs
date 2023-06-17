using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject enemy;
    public float enemydestroytime = 7f;
    // Start is called before the first frame update
    public void Start()
    {
        InvokeRepeating("enemyinstantiate",1f,3f);
    }

    // Update is called once per frame
    
    void enemyinstantiate(){
        Vector3 enemyPos = new Vector3(Random.Range(-25f,25f),14f,0);
        Vector3 enemyPos1 = new Vector3(-25f,Random.Range(-14f,14f),0);
        Vector3 enemyPos2 = new Vector3(-25f,Random.Range(-14f,14f),0);
        
        GameObject enemyy = Instantiate(enemy,enemyPos,Quaternion.Euler(0,0,Random.Range(90,270)));
        GameObject enemyy1 = Instantiate(enemy,enemyPos1,Quaternion.Euler(0,0,Random.Range(90,270)));
        GameObject enemyy2 = Instantiate(enemy,enemyPos2,Quaternion.Euler(0,0,Random.Range(90,270)));
        Destroy(enemyy,enemydestroytime);
        Destroy(enemyy1,enemydestroytime);
        Destroy(enemyy2,enemydestroytime);
    }
}
