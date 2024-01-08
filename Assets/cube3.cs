using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cube3 : Cube
{
    public override void ChangeSize(){
        transform.localScale = new Vector3(2,1,2);
    }
}
