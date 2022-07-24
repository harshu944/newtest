﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwipeTest : MonoBehaviour
{
    public Swipe swipeControls;
    public Transform player;
    private Vector3 desiredPosition;
    

    private void Update()
    {
        if (swipeControls.SwipeLeft)
        {
            desiredPosition += Vector3.left;

        }





        if (swipeControls.SwipeRight)
        {
            desiredPosition += Vector3.right;

        }



        











        player.transform.position = Vector3.MoveTowards(player.transform.position, desiredPosition, 3f * Time.deltaTime);















    }
}
