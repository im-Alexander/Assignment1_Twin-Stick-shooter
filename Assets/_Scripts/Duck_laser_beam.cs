using UnityEngine;
using System.Collections;

public class Duck_laser_beam : MonoBehaviour {
    // Variables
    #region
    public float lifetime = 2.0f;
    public float speed = 5.0f;
    public int damage = 1;
    #endregion

    // Start Function
    #region
    // Use this for initialization
    void Start()
    {
        Destroy(gameObject, lifetime);
    }
    #endregion

    // Update Function
    #region
    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * Time.deltaTime * speed);
    }
    #endregion
}
