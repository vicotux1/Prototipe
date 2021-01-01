using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class player : MonoBehaviour{
    public Vector3 Posicion_inicial;
    public Vector3 Left;
    public Vector3 Right;
    [Range(1.0f,500.0f)]public float _Speed=100.0f;
    float MovX, MovY;
    Vector3 Move=Vector3.zero;
    Rigidbody rb;
    void awake(){
        transform.position=Posicion_inicial;
    }
void OnMove(InputValue moveValue){
        Vector2 moveVector=moveValue.Get<Vector2>();
        MovX=moveVector.x;
        MovY=moveVector.y;
    }
    public void Move_Right(){
        transform.position=transform.position+Right;
    }
    public void Move_Left(){
        transform.position=transform.position+Left;
    }
    void FixedUpdate(){
        rb=GetComponent<Rigidbody>();
        rb.velocity=(new Vector3(0,0,1)*_Speed)*Time.fixedDeltaTime;
    }
    void OnTriggerEnter(Collider other){
        if (other.tag == "Enemy"){
			rb.velocity=Vector3.zero;
			transform.position=Posicion_inicial;
			}
		}
}
