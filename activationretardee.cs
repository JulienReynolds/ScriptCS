using UnityEngine;
using System.Collections;
using Random = UnityEngine.Random;
using MFPS.PlayerController;
using UnityEngine.Serialization;
public class activationretardee : MonoBehaviour{

public GameObject go;

void Start (){
go.SetActive( false );
StartCoroutine(ExampleCoroutine());
ExampleCoroutine();
}

IEnumerator ExampleCoroutine(){
        
        yield return new WaitForSeconds(2);
go.SetActive( true );

 }
}