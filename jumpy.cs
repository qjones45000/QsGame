using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jumpy : MonoBehaviour {

    public float jetpackForce = 75.0f;
    Rigidbody2D rigidbody2D;

     void Start()
    {
          rigidbody2D.GetComponent<Rigidbody2D>();
    }



    void FixedUpdate()
    {
        bool jetpackActive = Input.GetButton("1");

        if (jetpackActive)
        {
            rigidbody2D.AddForce(new Vector2(0, jetpackForce));
        }
    }



}
