using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Vector3 Res;
    public Vector3 CurrentSpeed = new ();

    public float jumpSpeed = 0;
    public float moveSpeed = 0;
    public float rotationSpeed = 0;

    private float moveRotation;
    private float moveStraight;
    private float jump;
    // Start is called before the first frame update
    void Start()
    {
    }
    // Update is called once per frame
    void Update()
    {
        DirectionalMove();
    }

    //ControllObjects Directional Movements 
    void DirectionalMove()
    {
        //Input
        moveRotation = Input.GetAxisRaw("Horizontal");
        moveStraight = Input.GetAxisRaw("Vertical");
        if (Input.GetKeyDown(KeyCode.Space)) jump = jumpSpeed * 50 * Time.deltaTime;
        else jump = 0;

        //Rotates Object
        transform.rotation *= Quaternion.Euler(new Vector3( 0, moveRotation * rotationSpeed * 50 * Time.deltaTime, 0 ));

        //Moves Object
        Vector3 playerPostionMove = new( 0, jump, moveStraight * moveSpeed * Time.deltaTime );
        CurrentSpeed = playerPostionMove;
        if(CurrentSpeed.magnitude > 0) CurrentSpeed -= Res;
        transform.Translate(CurrentSpeed);
    } 
}