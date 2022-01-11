using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class PlayerMovement : MonoBehaviour
{
    public float power = 10f;
    public Rigidbody2D rb2d;
    //private bool canJump = true;

    LineTrajectory tl;

    public Vector2 minPower;
    public Vector2 maxPower;

    Camera cam;
    Vector2 force;
    Vector3 startPoint;
    Vector3 endPoint;
    // Start is called before the first frame update
    private void Start()
    {
        cam = Camera.main;
        tl = GetComponent<LineTrajectory>();
    }
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //canJump = true;
            startPoint = cam.ScreenToWorldPoint(Input.mousePosition);
            startPoint.z = 15;

        }
        if (Input.GetMouseButton(0))
        {
            //canJump = true;
            Vector3 currentPoint = cam.ScreenToWorldPoint(Input.mousePosition);
            currentPoint.z = 15;
            tl.RenderLine(startPoint, currentPoint);

        }
        if (Input.GetMouseButtonUp(0))
        {

            //if (canJump)
            //{
                endPoint = cam.ScreenToWorldPoint(Input.mousePosition);
                endPoint.z = 15;

                force = new Vector2(Mathf.Clamp(startPoint.x - endPoint.x, minPower.x, maxPower.x), Mathf.Clamp(startPoint.y - endPoint.y, minPower.y, maxPower.y));
                rb2d.AddForce(force * power, ForceMode2D.Impulse);
                tl.EndLine();
            //}
        }
    }
    //void OnCollisionEnter2D(Collision2D collison)
    //{
    //    if (collison.transform.tag != "Player")
    //    {
    //        //if (!Input.GetMouseButtonDown(0))
    //        //{
    //            rb2d.constraints = RigidbodyConstraints2D.FreezePositionY | RigidbodyConstraints2D.FreezePositionX | RigidbodyConstraints2D.FreezeRotation;
    //            //print ("Col");
    //            canJump = true;
    //            //print ("Enter");
    //        //}
    //    }
    //}
    //void OnCollisionExit2D(Collision2D collision)
    //{
    //    if (collision.transform.tag != "Player")
    //    {
    //        rb2d.constraints = RigidbodyConstraints2D.None;
    //        canJump = false;
    //        //print ("Exit");
    //    }
    //}
    //void OnCollisionStay2D(Collision2D collision)
    //{
    //    if (collision.transform.tag != "Player")
    //    {
    //        //body.constraints = RigidbodyConstraints2D.FreezePositionY | RigidbodyConstraints2D.FreezePositionX | RigidbodyConstraints2D.FreezeRotation;
    //        canJump = true;
    //        //rigidbody2D.v = new Vector2 (0, 0);
    //        //print ("Stay");
    //    }
    //}
}
