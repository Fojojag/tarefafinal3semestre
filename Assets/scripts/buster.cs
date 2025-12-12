using System.Collections;
using UnityEngine;

public class buster : MonoBehaviour
{
    public Rigidbody2D rb;
    public float force = 10f;
    [SerializeField] private GameObject projectile;

    [SerializeField] private Transform firepoint;
    [SerializeField] private GameObject ChargeShot;

    [SerializeField] private float chargeSpeed;
    [SerializeField] private float chargeTime;
    private bool shotDown = false;
    public float KBCounter;
    public float KBTotalTime;
    collisiondetector CollisionDetector;
    playercontroller playerMain;
    private bool isCharging;
    // Update is called once per frame
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        CollisionDetector = GetComponent<collisiondetector>();
        playerMain = GetComponent<playercontroller>();
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.X) && chargeTime < 2)
        {
            isCharging = true;
            if (isCharging == true)
            {
                chargeTime += Time.deltaTime * chargeSpeed;
            }
        }
        if (Input.GetKeyDown(KeyCode.X))
        {

                Instantiate(projectile, firepoint.position, firepoint.rotation);

        }
        else if (Input.GetKeyUp(KeyCode.X) && chargeTime >= 2)
        {
            releaseCharge();
        }
    }

    private void releaseCharge()
    {
  
        {
            Instantiate(ChargeShot, firepoint.position, firepoint.rotation);
            
        }
        isCharging = false;
        chargeTime = 0;
    }


}
