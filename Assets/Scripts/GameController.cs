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
        //Inheritance
        cat.GetComponent<Cat>().Move(Vector3.forward * 3);
        cat.GetComponent<Cat>().Talk();
;         dog.GetComponent<Dog>().Move(Vector3.right * 10f, 10);
        dog.GetComponent<Dog>().Talk();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
