using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageSpawn : MonoBehaviour
{
    //存所有掉落裝備Prefab的陣列
    public GameObject[] stagePrefabs;
    
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

    public  float timer= 0f;

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
            cloneobj = Instantiate (stagePrefabs [Random.Range (0,stagePrefabs.Length)], new Vector3 (Random.Range (minPosX, maxPosX), posY, -0.1f), Quaternion.identity);
            timer+=Time.deltaTime;

			if(timer>0.005f&&maxInterval-maxIntervaldown>minInterval){
                timer=0f;
               maxInterval-=maxIntervaldown;
            }
			//暫停
            yield return new WaitForSeconds (Random.Range (maxInterval, maxInterval));

        }
    }

     void Update() {
        Destroy(cloneobj,destroytime);
    }
}
