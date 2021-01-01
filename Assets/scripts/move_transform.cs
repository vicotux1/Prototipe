using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move_transform : MonoBehaviour{
    [Range(1.0f,20.0f)]public float Speed;
    void Update(){
        move_Forward();
        //move_back();
    }
    void move_Forward(){
        //vector3 forward(0,0,1)
        transform.Translate(Vector3.forward* Time.deltaTime*Speed);
    }
     void move_back(){
        //vector3 right(0,0,-1)
        transform.Translate(Vector3.back* Time.deltaTime*Speed);
    }
   
   
    

}
