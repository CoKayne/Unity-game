using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WowMark_blink : MonoBehaviour
{

    public SpriteRenderer spriteRenderer;
    public bool warningStart=true;
    public bool warningEnd;
    public Material clearMaterial;
    public Material originalMaterial;
    public float timer=0f;
    void Start(){
        originalMaterial = spriteRenderer.material;
        spriteRenderer.material = clearMaterial;
    }

    public IEnumerator BlinkGameObject(GameObject gameObject, int numBlinks, float seconds)
    {
        SpriteRenderer renderer = gameObject.GetComponent<SpriteRenderer>();
        for (int i = 0; i < numBlinks * 2; i++){

            renderer.enabled = !renderer.enabled;
            yield return new WaitForSeconds(seconds);

        }
        renderer.enabled = true;
    }


    private void Update() {

        timer+=Time.deltaTime;
        if(timer>2)warningEnd=true;
        if(warningStart){
            spriteRenderer.material = originalMaterial;
            StartCoroutine(BlinkGameObject(gameObject, 2, 10));
        }
        if(warningEnd){
            warningStart = false;
            spriteRenderer.material = clearMaterial;
        }

    }
    private void FixedUpdate() {
        
    }

}