using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour 
{
    public CharacterController character;
    public Character speed = new Character();

    private void Start()
    {
        character = GetComponent<CharacterController>();
    }

    private void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        Vector3 move = transform.right * x + transform.forward *y;
        character.Move(move * speed.MoveSpeed * Time.deltaTime);
    }
}

[Serializable]
public class Character
{
    public float MoveSpeed;
    /*{
        get => MoveSpeed;
        set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            MoveSpeed = value;
        }
   }*/
} 



