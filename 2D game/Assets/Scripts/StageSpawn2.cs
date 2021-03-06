using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageSpawn2 : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] stagePrefabs;
    public int chances;
    
	//掉落的Y軸
    public float posY;
	
	//掉落的X軸範圍[minPosX~maxPosX]
    public float minPosX;
    public float maxPosX;
    
	//兩次掉落裝備之間的時間間隔[minInterval~maxInterval]
    public float minInterval;
    public float maxInterval;

    public float maxIntervaldown;

    public float destroytime;

    public  float timer = 0f;
    public  float timer2 = 0f;

    public  float timedown = 0f;

    public   float timelimit= 0f;

    public GameObject cloneobj;
    
    void Start()
    {
		//開始Coroutine
        StartCoroutine (SpawnCoroutine ());
    }
    
    IEnumerator SpawnCoroutine()
    {
        while (true) {
			//生產裝備
            int rand = Random.Range(0, 100);
            if(rand < chances){

                cloneobj = Instantiate (stagePrefabs [Random.Range (0, stagePrefabs.Length)], new Vector3 (Random.Range (minPosX, maxPosX), posY, -0.1f), Quaternion.identity);
                timer += Time.deltaTime;

                if(timer > 0.005f && maxInterval - maxIntervaldown > minInterval){
                    timer = 0f;
                maxInterval -= maxIntervaldown;
                }
                //暫停
                yield return new WaitForSeconds (Random.Range (maxInterval, maxInterval));
            }
        }
    }

     void Update() {
        Destroy(cloneobj,destroytime);
    }

      void FixedUpdate() { 
            timer2 += Time.deltaTime;
            if(timer2 > 1&& maxInterval >= timelimit && minInterval >= timelimit){
                timer2= 0f;
                maxInterval -= timedown;
                minInterval -= timedown;
            }; 
    }

}
