using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_active: MonoBehaviour
{
    [Header("移動速度"),Range(0,10)]
    public float speed = 5;


    private Rigidbody2D rig;
    private Animator ani;

    public float LR_moving;    //水平移動值
    public float UD_moving;    //上下移動值


    private void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        ani = GetComponent<Animator>();
    }

    private void Update()
    {
        GetValue();
        Player_Move();
    }

    private void GetValue()
    {
        LR_moving = Input.GetAxis("Horizontal");
        UD_moving = Input.GetAxis("Vertical");

    }

    private void Player_Move()
    {
        rig.velocity = new Vector2(LR_moving * speed, UD_moving * speed);
/*
        if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow))
        {
            ani.SetBool("往後走", UD_moving != 0);

        }
        else if (Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow))
        {
            ani.SetBool("往前走", UD_moving != 0);

        }
        else if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow))
        {
            ani.SetBool("往測走", LR_moving != 0);

        }
        else if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
        {
            ani.SetBool("往測走", LR_moving != 0);

        }
*/
    }
}
