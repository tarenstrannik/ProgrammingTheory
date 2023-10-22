using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    [SerializeField] GameObject dog;
    [SerializeField] GameObject cat;
    // Start is called before the first frame update
    void Start()
    {
        //Encapsulation
        cat.GetComponent<Cat>().AnimalName = "asdfhjklzxcvbqwer";
        dog.GetComponent<Dog>().AnimalName = "Fred";
        //Inheritance
        cat.GetComponent<Cat>().Move(Vector3.forward * 3);
        cat.GetComponent<Cat>().Talk(cat.GetComponent<Cat>().AnimalName);
;         dog.GetComponent<Dog>().Move(Vector3.right * 10f, 10);
        dog.GetComponent<Dog>().Talk(dog.GetComponent<Dog>().AnimalName);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
