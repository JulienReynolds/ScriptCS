
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class screamer : MonoBehaviour
{


    public GameObject jumpscareObject;
        public GameObject jumpscareObject1;
                public GameObject jumpscareObject2;
                public GameObject jumpsound1;
                public GameObject jumpsound2;

public PlayerController playerController;

    void Start () {

        jumpscareObject.SetActive(false);
       jumpscareObject1.SetActive(false);
              jumpscareObject2.SetActive(false);
              jumpsound1.SetActive(false);
              jumpsound2.SetActive(false);


	}
	
	void OnTriggerEnter (Collider player) {
        if(player.tag == "Player")
        {
            jumpscareObject.SetActive(true);
           playerController.runSpeed = 0;
                         playerController.walkSpeed = 0;
    
                  

            StartCoroutine(DestroyObject());
        }
    
        if(player.tag == "Player")
        {
                                    
                      playerController.runSpeed = 0;
                         playerController.walkSpeed = 0;
    

           StartCoroutine(DestroyObject1());

                  
            StartCoroutine(DestroyObject());
                   
	}
    }
    IEnumerator DestroyObject()
    {
        yield return new WaitForSeconds(16f);
    Destroy(jumpscareObject);
        Destroy(gameObject);
        playerController.runSpeed = 7;
        playerController.walkSpeed = 3;
    
    }
    IEnumerator DestroyObject1()
    {
        yield return new WaitForSeconds(16f);
                jumpscareObject1.SetActive(true);
                jumpsound1.SetActive(true);



    
    }

}

