using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterInteractable : MonoBehaviour
{
 CharacterController2D characterController;
 Rigidbody2D body;
 Character character;
 [SerializeField] float offsetDistance = 1f;
 [SerializeField] float sizeOfInteractableArea = 1.2f;
  [SerializeReference] HighlightController highlightController;
 private void Awake() {
    characterController = GetComponent<CharacterController2D>();
    body = GetComponent<Rigidbody2D>();
    character = GetComponent<Character>();
 } 

private void Update() {

Check();

    if(Input.GetMouseButtonDown(1)){
        Interact();
    }
}



private void Check()
{
  Vector2 position = body.position + characterController.lastMovementVector * offsetDistance ;
  Collider2D [] colliders = Physics2D.OverlapCircleAll(position,sizeOfInteractableArea);


foreach(Collider2D c in colliders){
Interactable hit = c.GetComponent<Interactable>();



if(hit != null){
  highlightController.Highlight(hit.gameObject);
  
  return;
}

}

highlightController.Hide();



}








public void Interact(){
  
    Vector2 position = body.position + characterController.lastMovementVector * offsetDistance;
    Collider2D [] colliders = Physics2D.OverlapCircleAll(position,sizeOfInteractableArea);

    foreach(Collider2D c in colliders){
        Interactable hit = c.GetComponent<Interactable>();
       
        if(hit != null)
      {
        
        hit.Interact(character);
        break;
      }
    }
}

}
