using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LootCrateInteractable : Interactable
{
[SerializeField] GameObject chestOpen;
[SerializeField] GameObject chestClosed;
bool isOpen = false; 

public override void Interact(Character character){
if(isOpen == false){
    isOpen = true;
    chestOpen.SetActive(true);
    chestClosed.SetActive(false);
  
}
}
}
