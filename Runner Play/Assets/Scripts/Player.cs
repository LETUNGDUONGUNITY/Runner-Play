using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Dreamteck.Forever;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
   public Rigidbody rb;
    public int jumpForce;
    LaneRunner runner;
    public ConstantForce rb2;
    // Start is called before the first frame update
    void Start()
    {
        runner = GetComponent<LaneRunner>();
        rb = rb.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
           
            runner.lane--;
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
           
            runner.lane++;
        }

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
          
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }
}
