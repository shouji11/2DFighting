using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerController : MonoBehaviour
{
    public float speed ;          //移動速度
    public float jumpPower;       //ジャンプパワー
    private bool isJump;          //ジャンプしてるか
    private bool isGraund;        //着地してるか
    //public static float LandingRigidity;  //着地後の硬直時間

    private Animator animator;      //アニメーション
    private Vector3 position;       //ポジション
    private Rigidbody2D rb2d;
    public HitGround hitGround;
    private LayerMask hit;
    private HitBox hitBox;


    
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        rb2d = GetComponent<Rigidbody2D>();
       // LandingRigidity = 0;
       
    }

    // Update is called once per frame
    void Update()
    {
        position = transform.position;

        if(!IsJump())
        {
            MovementControl();

            JumpControl();           
        }

        Attack();
    }

    /// <summary>
    /// ジャンプしたか
    /// </summary>
    /// <returns>ジャンプしてる</returns>
    bool IsJump()
    {
        isGraund = hitGround.IsGround();
        
        if (isGraund)
        {
            isJump = false;
        }
        else
        {
            isJump = true;
        }

        return isJump;
    }


    /// <summary>
    /// 攻撃制御
    /// </summary>
    void Attack()
    {
        //　A_Attack
        if(Input.GetKeyDown(KeyCode.Z))
        {
            animator.SetBool("Attack_A", true);
        }
        else
        {
            animator.SetBool("Attack_A", false);
            
        }

        //　B_Attack
        if (Input.GetKeyDown(KeyCode.X))
        {
            animator.SetBool("Attack_B", true);
        }
        else
        {
            animator.SetBool("Attack_B", false);
            
        }


        //　C_Attack
        if (Input.GetKeyDown(KeyCode.C))
        {
            animator.SetBool("Attack_C", true);
        }
        else
        {
            animator.SetBool("Attack_C", false);
        }
        
    }
    

    /// <summary>
    /// ジャンプ制御
    /// </summary>
    void JumpControl()
    {

        //　垂直ジャンプ
        if (Input.GetKeyDown(KeyCode.UpArrow) )
        {
            animator.SetBool("Jump", true);
            rb2d.velocity = Vector3.up * jumpPower;
            isGraund = false;

        }
        else
        {
            animator.SetBool("Jump", false);
            isGraund = true;
        }

        //　前方ジャンプ
        //　後方ジャンプ
        

    }


    /// <summary>
    /// 移動制御
    /// </summary>
    void MovementControl()
    {

        if(!Input.GetKey(KeyCode.DownArrow))
        {

            //　後方移動
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                animator.SetBool("Recession", true);
                transform.position -= transform.right * speed * Time.deltaTime;
            }
            else
            {
                animator.SetBool("Recession", false);

            }

            //　前方移動
            if (Input.GetKey(KeyCode.RightArrow))
            {
                animator.SetBool("Advance", true);
                transform.position += transform.right * speed * Time.deltaTime;
            }
            else
            {
                animator.SetBool("Advance", false);
            }
        }

        //　しゃがみ
        if (Input.GetKey(KeyCode.DownArrow))
        {
            animator.SetBool("Crouch", true);
            

        }
        else
        {
            animator.SetBool("Crouch", false);
        }
    }

    
    /// <summary>
    /// ダメージ制御
    /// ダメージを受けた際アニメーションなどが再生する
    /// </summary>
    void DamageControl()
    {

    }

    

}
