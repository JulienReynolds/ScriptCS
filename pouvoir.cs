using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pouvoir : MonoBehaviour
{
    public Rigidbody atk1;
    public Rigidbody atk2;
    public Rigidbody atk3;
    public Rigidbody def1;
    
    public bool nospam = false;

    public float speed = 0;
    void Start()
    {
        
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            Rigidbody instantiatedProjectile = Instantiate(atk1,
            transform.position,
            transform.rotation)
            as Rigidbody;
  instantiatedProjectile.velocity = transform.TransformDirection(new Vector3(0,0,speed));


        }
         if (Input.GetKeyDown(KeyCode.W))
        {
            if (nospam == false){
            Rigidbody instantiatedProjectile = Instantiate(atk2,
            transform.position,
            transform.rotation)
            as Rigidbody;
  instantiatedProjectile.velocity = transform.TransformDirection(new Vector3(0,0,speed));
           nospam = true;

     StartCoroutine(Die());
}
}
 if (Input.GetKeyDown(KeyCode.X))
        {
       if (nospam == false){

            Rigidbody instantiatedProjectile = Instantiate(atk3,
            transform.position,
            transform.rotation)
            as Rigidbody;
            nospam = true;

     StartCoroutine(Die());
}
}
 if (Input.GetKeyDown(KeyCode.F))
        {
        if (nospam == false){

            Rigidbody instantiatedProjectile = Instantiate(def1,
            transform.position,
            transform.rotation)
            as Rigidbody;
            nospam = true;

     StartCoroutine(Die());
}
}
    }
    
    IEnumerator Die(){
        
         yield return new WaitForSeconds(3);
         nospam = false;
     }
}
