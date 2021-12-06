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

    public float destroytime;

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
			
			//暫停
            yield return new WaitForSeconds (Random.Range (minInterval, maxInterval));

        }
    }

     void Update() {
        Destroy(cloneobj,destroytime);
    }
}
