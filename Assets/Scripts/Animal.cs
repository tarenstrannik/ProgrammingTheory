using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Scripting.APIUpdating;

public abstract class Animal : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody animalRb;

    private void Start()
    {
       
    }

    public virtual void Move(Vector3 position)
    {
        transform.Translate(position);
    }
    public virtual void Move(Vector3 speed, float time)
    {
        animalRb = GetComponent<Rigidbody>();
        StartCoroutine(MoveWithSpeed(speed, time));
    }
    IEnumerator MoveWithSpeed(Vector3 speed, float time)
    {
        animalRb.velocity = speed;
        yield return new WaitForSeconds(time);
        animalRb.velocity = Vector3.zero;
    }
    public abstract void Talk();

}
