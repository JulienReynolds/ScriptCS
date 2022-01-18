
using UnityEngine;
using UnityEngine.AI;

public class MonstreIA : MonoBehaviour
{
    public NavMeshAgent agent;
      public Transform player;
public LayerMask whatIsGround, whatIsPlayer;

    public float health;

    //Patroling
    public Vector3 walkPoint;
    bool walkPointSet;
    public float walkPointRange;

    //Attacking
    public float timeBetweenAttacks;
    bool alreadyAttacked;
    public GameObject projectile0;
    public GameObject projectile1;
    public GameObject projectile2;
    public GameObject projectile3;
    public GameObject projectile4;
    public GameObject projectile5; 
    public GameObject projectile6;
    
    public GameObject projectile7;
public Transform p0;
public Transform p1;
public Transform p2;
public Transform p3;
public Transform p4;
public Transform p5;
public Transform p6;

public Transform p7;

    //States
    public float sightRange, attackRange;
    public bool playerInSightRange, playerInAttackRange;

   // private void Awake()
   // {
///player = GameObject.Find("EnemyAI_CALIBR2").transform;
     //   agent = GetComponent<NavMeshAgent>();
    //}


  
   // private void ChasePlayer()
   // {
       // agent.SetDestination(player.position);
    //}

     void Start()
    {
        //Make sure enemy doesn't move
        //if (Input.GetKey(KeyCode.Y)) {

        
        //agent.SetDestination(transform.position);

        //transform.LookAt(player);
        
 //if (!alreadyAttacked)
       // {
            ///Attack code here
            Rigidbody rb = Instantiate(projectile0, p0.position, Quaternion.identity).GetComponent<Rigidbody>();
            rb.AddForce(transform.forward * 100f, ForceMode.Impulse);
            rb.AddForce(transform.up * 10f, ForceMode.Impulse);
            Rigidbody rb1 = Instantiate(projectile1, p1.position, Quaternion.identity).GetComponent<Rigidbody>();
            rb.AddForce(transform.forward * 32f, ForceMode.Impulse);
            rb.AddForce(transform.up * 8f, ForceMode.Impulse);
            Rigidbody rb2 = Instantiate(projectile2, p2.position, Quaternion.identity).GetComponent<Rigidbody>();
            rb.AddForce(transform.forward * 32f, ForceMode.Impulse);
            rb.AddForce(transform.up * 8f, ForceMode.Impulse);
            Rigidbody rb3 = Instantiate(projectile3, p3.position, Quaternion.identity).GetComponent<Rigidbody>();
            rb.AddForce(transform.forward * 32f, ForceMode.Impulse);
            rb.AddForce(transform.up * 8f, ForceMode.Impulse);
            Rigidbody rb4 = Instantiate(projectile4, p4.position, Quaternion.identity).GetComponent<Rigidbody>();
            rb.AddForce(transform.forward * 32f, ForceMode.Impulse);
            rb.AddForce(transform.up * 8f, ForceMode.Impulse);
            Rigidbody rb5 = Instantiate(projectile5, p5.position, Quaternion.identity).GetComponent<Rigidbody>();
            rb.AddForce(transform.forward * 32f, ForceMode.Impulse);
            rb.AddForce(transform.up * 8f, ForceMode.Impulse);
            Rigidbody rb6 = Instantiate(projectile6, p6.position, Quaternion.identity).GetComponent<Rigidbody>();
            rb.AddForce(transform.forward * 32f, ForceMode.Impulse);
            rb.AddForce(transform.up * 8f, ForceMode.Impulse);
            Rigidbody rb7 = Instantiate(projectile7, p7.position, Quaternion.identity).GetComponent<Rigidbody>();
            rb.AddForce(transform.forward * 32f, ForceMode.Impulse);
            rb.AddForce(transform.up * 8f, ForceMode.Impulse);
            ///End of attack code

          // alreadyAttacked = true;
           // Invoke(nameof(ResetAttack), timeBetweenAttacks);
       // }
    //}
        //}
    }
}
    //private void ResetAttack()
    //{
       // alreadyAttacked = false;
    //}

    //public void TakeDamage(int damage)
    //{
      //  health -= damage;

       // if (health <= 0) Invoke(nameof(DestroyEnemy), 0.5f);
   // }


