using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class Cat : Animal
{
    

    //Inheritance
    public override void Talk(string name)
    {
        Debug.Log(name+" "+"Meou");
    }

    //Polymorphism

    public override void Move(Vector3 position)
    {
        Jump();
        base.Move(position);
    }
    public override void Move(Vector3 speed, float time)
    {
        Jump();
        base.Move(speed,time);
    }
    //Abstraction

    private void Jump()
    {
        Rigidbody animalRb = GetComponent<Rigidbody>();
        animalRb.AddForce(Vector3.up * 200f);
    }
    
}
