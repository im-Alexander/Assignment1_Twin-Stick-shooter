using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class Duck_Behavior : MonoBehaviour
{

    //variables
    #region
    // Movement modifier applied to directional movement.
    public float playerSpeed = 4.0f;
    // What the current speed of our player is
    private float currentSpeed;
    // The last movement that we've made
    private Vector3 lastMovement;

    // The laser we will be shooting
    public Transform laser;
    // How far from the center of the ship should the laser be
    public float laserDistance = .2f;
    // How much time (in seconds) we should wait before
    // we can fire again
    public float timeBetweenFires = .3f;
    // If value is less than or equal 0, we can fire
    private float timeTilNextFire = 0.0f;
    // The buttons that we can use to shoot lasers
    public List<KeyCode> shootButton;
    #endregion

    //start function
    #region
    // Use this for initialization
    void Start()
    {
        //for debug
        Debug.Log("Started...");

        //for movement
        this.currentSpeed = 0.0f;
        this.lastMovement = new Vector3();
    }
    #endregion

    //update function
    #region
    // Update is called once per frame
    void Update()
    {
        // Rotate player to face mouse
        Rotation();

        // Move the player's body
        Movement();

        // a foreach loop will go through each item inside of
        // shootButton and do whatever we placed in {}s using the
        // element variable to hold the item
        foreach (KeyCode element in shootButton)
        {
            if (Input.GetKey(element) && timeTilNextFire < 0)
            {
                timeTilNextFire = timeBetweenFires;
                DuckLaser();
                break;
            }
        }
        timeTilNextFire -= Time.deltaTime;
    }
    #endregion

    //other functions
    #region
    void Rotation()
    {
        Vector3 worldPos = Input.mousePosition;
        worldPos = Camera.main.ScreenToWorldPoint(worldPos);

        float dx = this.transform.position.x - worldPos.x;
        float dy = this.transform.position.y - worldPos.y;
        float angle = Mathf.Atan2(dy, dx) * Mathf.Rad2Deg;

        Quaternion rot = Quaternion.Euler(new Vector3(0, 0, angle + 90));

        this.transform.rotation = rot;
    }

    void Movement()
    {
        Vector3 movement = new Vector3();

        movement.x += Input.GetAxis("Horizontal");
        movement.y += Input.GetAxis("Vertical");

        movement.Normalize();

        if (movement.magnitude > 0)
        {
            currentSpeed = playerSpeed;
            this.transform.Translate(movement * Time.deltaTime * playerSpeed, Space.World);
            lastMovement = movement;
        }
        else
        {
            this.transform.Translate(lastMovement * Time.deltaTime * currentSpeed, Space.World);
            currentSpeed *= .9f;
        }
    }
    void DuckLaser()
    {
        Vector3 laserPos = this.transform.position;

        float rotationAngle = transform.localEulerAngles.z - 90;

        laserPos.x += (Mathf.Cos((rotationAngle) * Mathf.Deg2Rad) * -laserDistance);

        laserPos.y += (Mathf.Sin((rotationAngle) * Mathf.Deg2Rad) * -laserDistance);

        Instantiate(laser, laserPos, this.transform.rotation);
    }
    #endregion
}
