using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToolsCharacterController : MonoBehaviour
{
  Rigidbody2D body;
  CharacterController2D character; 
 [SerializeField] float offsetDistance = 1f;
 [SerializeField] float sizeOfInteractableArea = 1.2f;

   void Awake(){ 
   body = GetComponent<Rigidbody2D>();
   character = GetComponent<CharacterController2D>();
   
   }

  private void Update() {
    if(Input.GetMouseButtonDown(0)){
        UseTool();
    }
  }
  
  private void UseTool(){
  Vector2 position = body.position +  character.lastMovementVector * offsetDistance ;
  Collider2D[] colliders = Physics2D.OverlapCircleAll(position,sizeOfInteractableArea); 
  
  foreach(Collider2D c in colliders){
    ToolHit hit = c.GetComponent<ToolHit>();
    if(hit != null){
        hit.Hit();
        break;
    }
  }
  }

}
