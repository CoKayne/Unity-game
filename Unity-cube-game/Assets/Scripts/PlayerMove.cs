using UnityEngine;

public class PlayerMove : MonoBehaviour{
    public Rigidbody rb;
    public float ForwardForce;
    public float SideForce;


    // Start is called before the first frame update
    void Start(){
        
    }

    // Update is called once per frame
    void FixedUpdate(){
    
        rb.AddForce(0, 0, ForwardForce * Time.deltaTime);
        if(Input.GetKey("d")){
            rb.AddForce(SideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if(Input.GetKey("a")){
            rb.AddForce(-SideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

    }
}