using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//　当たり判定種類
enum hitboxType {

    Pushing,        //　押し合い
    Damage,         //　やられ・くらい
    Attack,         //　攻撃
    
}

//　攻撃属性
enum attackAttribute
{
    Upper,          //　上段
    Middle,         //　中段
    Low,            //　下段

}


public class HitBox : MonoBehaviour
{
    hitboxType hitboxType;
    attackAttribute attackAttribute;
  
    void OnTriggerEnter2D(Collider2D collider2D)
    {
       
    }

    void OnTriggerStay2D(Collider2D collider2D)
    {
        
    }

    void OnTriggerExit2D(Collider2D collider2D)
    {
        
    }
}
