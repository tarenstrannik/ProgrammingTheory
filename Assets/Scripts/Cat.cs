using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class Cat : Animal
{
    

    //Inheritance
    public override void Talk()
    {
        Debug.Log("Meou");
    }

    //Polymorphism

    public override void Move(Vector3 position)
    {
        Rigidbody animalRb = GetComponent<Rigidbody>();
        animalRb.AddForce(Vector3.up * 200f);
        base.Move(position);
    }
    public override void Move(Vector3 speed, float time)
    {
        Rigidbody animalRb = GetComponent<Rigidbody>();
        animalRb.AddForce(Vector3.up * 200f);
        base.Move(speed,time);
    }

    
}
