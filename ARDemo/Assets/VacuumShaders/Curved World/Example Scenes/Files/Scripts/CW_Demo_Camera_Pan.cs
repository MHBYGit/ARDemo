﻿using UnityEngine;
using System.Collections;

namespace VacuumShaders.CurvedWorld.Demo
{
    [AddComponentMenu("VacuumShaders/Curved World/Demo/Camera Pan")]
    public class CW_Demo_Camera_Pan : MonoBehaviour
    {
        //////////////////////////////////////////////////////////////////////////////
        //                                                                          // 
        //Variables                                                                 //                
        //                                                                          //               
        //////////////////////////////////////////////////////////////////////////////
        public float moveSpeed = 1;

        //////////////////////////////////////////////////////////////////////////////
        //                                                                          // 
        //Unity Functions                                                           //                
        //                                                                          //               
        //////////////////////////////////////////////////////////////////////////////
        void Start()
        {

        }

        void Update()
        {
            if (Input.GetMouseButton(0))
            {
                transform.Translate(Vector3.right * -Input.GetAxis("Mouse X") * moveSpeed);
                transform.Translate(transform.up * -Input.GetAxis("Mouse Y") * moveSpeed, Space.World);
            }
            else if (Input.touchSupported && Input.touchCount == 1 && Input.touches[0].phase == TouchPhase.Moved)
            {
                //Vector2 touchDeltaPosition = Input.GetTouch(0).deltaPosition;
                //transform.Translate(Vector3.right * touchDeltaPosition.x * moveSpeed * 0.1f);
            }
        }
    }
}