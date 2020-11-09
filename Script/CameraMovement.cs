using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Transform player1;//, player2;

    private Vector3 cameraScreen_LB; //　画面左下座標
    private Vector3 cameraScreen_RT; //　画面右上座標
    private Vector2 player1_pos, player2_pos;
    private Camera camera;
    
    // Start is called before the first frame update
    void Start()
    {
        camera = GetComponent<Camera>();
        //player1 = GetComponent<GameObject>();
        player1.position = transform.position;
        cameraScreen_LB = camera.ViewportToWorldPoint(new Vector3(0,0,0));
        cameraScreen_RT = camera.ViewportToWorldPoint(new Vector3(1,1,0));

    }

    // Update is called once per frame
    void Update()
    {
        if(player1.position.x <= cameraScreen_LB.x)  {

            Debug.Log("OUT");

        }
        else if (player1.position.x >= cameraScreen_RT.x)        {

            Debug.Log("OUT");
        }
        else
        {
            Debug.Log("IN");
        }
        
    }



    void moveCamera()
    {


    }



}
