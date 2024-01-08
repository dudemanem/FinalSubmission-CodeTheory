using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{

    protected float speed = 20.0f;

    public Rigidbody rb {get; private set;}

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        ChangeSize();
    }

    public virtual void Move(){
        Vector3 tempVect = new Vector3(1, 0, 3);
        tempVect = tempVect.normalized * speed * Time.deltaTime;
        rb.MovePosition(transform.position + tempVect);
    }

    public virtual void ChangeSize(){
        transform.localScale = new Vector3(1, 2, 1);
    }
}
