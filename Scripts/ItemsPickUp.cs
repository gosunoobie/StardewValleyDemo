using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemsPickUp : MonoBehaviour
{
[SerializeField] float pickUpDistance = 1.5f;
[SerializeField] float itemSpeed = 5f;
[SerializeField] float ttl = 10f;
Transform player;

private void Awake() {
    player = GameManager.instance.Player.transform;
}


private void Update() {

ttl -= Time.deltaTime;
if(ttl <= 0){
    Destroy(gameObject);
}

float distance = Vector3.Distance(transform.position,player.position);    
if(distance > pickUpDistance)
return;
transform.position = Vector3.MoveTowards(transform.position,player.position,itemSpeed * Time.deltaTime);


if(distance < 0.1f)
{
    Destroy(gameObject);
}

}



}
