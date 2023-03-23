using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class InventoryButton : MonoBehaviour
{
[SerializeField] Image icon;
[SerializeField] TextMeshProUGUI text;
int myIndex;


public void SetIndex(int index){
myIndex = index;
}

public void Set(ItemSlot slot){
  

    icon.sprite = slot.item.Icon;
    if(slot.item.stackable == true){
        text.gameObject.SetActive(true);
        text.text = slot.count.ToString();
    }
    else{
        text.gameObject.SetActive(false);
    }
}

public void Clean(){
    icon.sprite = null;
    icon.gameObject.SetActive(false);
}

}
