using UnityEngine;
using System.Collections;
// Pour utiliser le FirstPersonController
using UnityStandardAssets.Characters.FirstPerson;

public class grappin : MonoBehaviour{

	public Camera cam;
	public RaycastHit hit;

    public LayerMask surfaces;
	public int maxDistance;
	
	public bool isMoving;
	public Vector3 location;
	
	public float speed = 10;
	public Transform hook;
	
	public FirstPersonController FPC;
	public LineRenderer LR;

	void Update(){

        // Envois du grappin
		if(Input.GetKey(KeyCode.Q)){
			Grapple();
		}
		
        // Si le personnage vole, on l'envoie vers le point d'arrivée 
		if(isMoving)
        {
			MoveToSpot();
		}
		
        // Annulation / décrochage du grappin
		if(Input.GetKey(KeyCode.Space) && isMoving)
        {
		 
            isMoving = false;
			FPC.CanMove = true;
			LR.enabled = false;
            gameObject.GetComponent< Rigidbody>().useGravity = false;
            FPC.m_GravityMultiplier = 0.5f;

 }

 IEnumerator Shoot()
 {
	 
     yield return new WaitForSeconds (1f);
     Bam ();
        }

	void Bam()
 {
	             FPC.m_GravityMultiplier = 2;

 }
 

	}
    // Lors de l'envois du grappin
	public void Grapple(){
        // On crée un raycast de "maxDistance" unitÃ©s depuis la camÃ©ra vers l'avant.
        // Si ce raycast touche quelque chose c'est que la grappin est utilisable
		if(Physics.Raycast(cam.transform.position, cam.transform.forward, out hit, maxDistance, surfaces)){
            isMoving = true;
			location = hit.point;
			FPC.CanMove = false;
            gameObject.GetComponent< Rigidbody>().useGravity = false;
            FPC.m_GravityMultiplier = 0.1f;
			LR.enabled = true;
			LR.SetPosition(1, location);
		}

    }

	// Déplacement du joueur vers le point touché par le grappin
	public void MoveToSpot(){
		transform.position = Vector3.Lerp(transform.position, location, speed * Time.deltaTime / Vector3.Distance(transform.position, location));
		LR.SetPosition(0, hook.position);
		
        // Si on est à moisn de 1 unité de la cible , fin du grappin
		if(Vector3.Distance(transform.position, location) < 1f){
            isMoving = false;
			FPC.CanMove = true;
			LR.enabled = false;
            gameObject.GetComponent< Rigidbody>().useGravity = true;
            FPC.m_GravityMultiplier = 2;
        }
	}
}