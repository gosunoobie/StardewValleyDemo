using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeCuttable : ToolHit
{

[SerializeField] GameObject pickUpDrop;
[SerializeField] float dropCount = 5f;
[SerializeField] float spread = 0.75f;

public override void Hit(){
while(dropCount > 0){

dropCount -=1;
Vector3 Position = transform.position;
Position.x += spread * UnityEngine.Random.value - spread/2;
Position.y += spread * UnityEngine.Random.value - spread/2;
GameObject go = Instantiate(pickUpDrop);
go.transform.position = Position;



}
Destroy(gameObject);
}
}
