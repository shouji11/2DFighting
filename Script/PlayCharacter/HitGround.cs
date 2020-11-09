using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitGround : MonoBehaviour
{

    private string taggraund = "ground";
    public bool isGraund = false;

    private bool isGraundEnter, isGraundStay, isGraundExit;
    
    public bool IsGround()
    {
        if(isGraundEnter||isGraundStay)
        {
            isGraund = true;
        }
        else if(isGraundExit)
        {
            isGraund = false;
        }
        isGraundEnter = false;
        isGraundStay = false;
        isGraundExit = false;

        return isGraund;
    }


    void OnTriggerEnter2D(Collider2D collider2D)
    {
        if (collider2D.gameObject.tag ==taggraund)
        {
            isGraundEnter = true;

        }
    }

    void OnTriggerStay2D(Collider2D collider2D)
    {
        if (collider2D.gameObject.tag == taggraund)
        {
            isGraundStay = true;

        }
    }

    void OnTriggerExit2D(Collider2D collider2D)
    {
        if (collider2D.gameObject.tag == taggraund)
        {
            isGraundExit = true;

        }
    }
}
