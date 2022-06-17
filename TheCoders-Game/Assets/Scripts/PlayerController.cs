using UnityEngine;

public class PlayerController : MonoBehaviour
{
  
public float speed;
Rigidbody2D rigidbody;


void Start()
{
    rigidbody = GetComponent<Rigidbody2D>();

}


void Update()
{

    float horizontal = Input.GetAxis("Horizontal");
    float vertical = Input.GetAxis("Vertical");

    rigidbody.velocity = new Vector3(horizontal * speed, vertical * speed, 0);

}



}
