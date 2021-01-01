using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour{
    [SerializeField][Range (1, 3)]int SerialID;
    public int Points=10;

    void OnTriggerEnter(Collider other){
		if (other.tag == "Player"){
      if (SerialID==1){
        Destroy (this.gameObject);
        Game_Manager.estancia.Puntacion(Points);
        }if (SerialID==2){
        Game_Manager.estancia.Lives();
        }if (SerialID==3){
        Game_Manager.estancia.Puntacion(Points);
        }
      }
    }  

}
