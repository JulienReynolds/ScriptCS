using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tp : MonoBehaviour
{
    public Transform avant;
    public Transform derriere;
    public Transform gauche;
    public Transform droite;

    public UnityEngine.CharacterController controller;
 public GameObject joueur;
  
    void Start()
    {
        
    }

    void Update()
    {
      if(Input.GetKeyDown(KeyCode.U))

        {
        controller.enabled = false;
        joueur.transform.position = avant.transform.position;
             StartCoroutine(Died());

    }
     if(Input.GetKeyDown(KeyCode.J))

        {
        joueur.transform.position = derriere.transform.position;
             StartCoroutine(Died());

    }
     if(Input.GetKeyDown(KeyCode.K))

        {
        joueur.transform.position = droite.transform.position;
             StartCoroutine(Died());

    }
     if(Input.GetKeyDown(KeyCode.H))

        {
        joueur.transform.position = gauche.transform.position;
             StartCoroutine(Died());

    }
}
 IEnumerator Died(){
        
         yield return new WaitForSeconds(1); 
         controller.enabled = true;
     }
}
