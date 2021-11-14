using System.Collections;
using System.Collections.Generic;
using UnityEngine.Rendering.PostProcessing;
using UnityEngine;

public class SlowMotion : MonoBehaviour
{
    public PostProcessVolume Volume;
    private ChromaticAberration CA; 
    private Vignette VG;
    private LensDistortion LD;
    private Grain grain;
    // Start is called before the first frame update
    void Start(){
            Volume.profile.TryGetSettings(out CA);
            CA.intensity.value = 0;
            Volume.profile.TryGetSettings(out VG);
            VG.intensity.value = 0.336f; 
            Volume.profile.TryGetSettings(out LD);
            LD.intensity.value = 0; 
            Volume.profile.TryGetSettings(out grain);
            grain.intensity.value = 0; 
    }

    // Update is called once per frame
    void Update(){

        if(Input.GetKey("space")){ 
            CA.intensity.value = Mathf.Lerp(CA.intensity.value, 1, 20f * Time.deltaTime);
            VG.intensity.value = Mathf.Lerp(VG.intensity.value, 0.42f, 20f * Time.deltaTime);
            LD.intensity.value = Mathf.Lerp(LD.intensity.value, 25, 20f * Time.deltaTime);
            grain.intensity.value = Mathf.Lerp(grain.intensity.value, 0.25f, 20f * Time.deltaTime);
        }

        if(Input.GetKeyUp("space")){
            // while(CA.intensity.value > 0){
            //     Invoke("decrease", 2);
            //     Debug.Log(CA.intensity.value);
            //     if(CA.intensity.value <= 0){
            //         CA.intensity.value = 0;
            //         break;
            //     }
            // }
            CA.intensity.value = 0;
            VG.intensity.value = 0.336f;
            LD.intensity.value = 0;
            grain.intensity.value = 0;
        }

    }

    void decrease(float amount){
        amount -= 0.1f;
        return;
    }

}