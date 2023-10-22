using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : Animal
{
    //Inheritance
    public override void Talk(string name)
    {
        Debug.Log(name+" "+ "Gav");
    }
}
