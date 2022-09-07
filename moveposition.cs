using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public float speed;
    public Rigidbody2D rig;
    Vector2 mov;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        mov.x = Input.GetAxis("Horizontal");
        mov.y = Input.GetAxis("Vertical");
    }
    private void FixedUpdate()
    {
        rig.MovePosition(rig.position + mov * speed * Time.fixedDeltaTime);

    }
}
