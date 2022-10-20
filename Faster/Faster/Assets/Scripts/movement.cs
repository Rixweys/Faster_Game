using UnityEngine;

public class movement : MonoCache
{
    public float speed_move;
    public float jump;
    public float gravity = 1;
    float z_Move;
    float x_Move;
    CharacterController Hero;
    Vector3 move_Direction;
    
    private void Start()
    {
        
        Hero = GetComponent<CharacterController>();
        
    }

    /*private void Update()
    {
        Move();
        
    }*/

    public override void OnTick()
    {
        Move();
    }


    private void Move()
    {
        z_Move = Input.GetAxis("Horizontal");
        x_Move = Input.GetAxis("Vertical");
        if (Hero.isGrounded)
        {
            move_Direction = new Vector3(z_Move, 0f, x_Move);
            move_Direction = transform.TransformDirection(move_Direction);
            if (Input.GetKey(KeyCode.Space))
            {
                move_Direction.y += jump;
            }
        }
        else
        {
            move_Direction.y -= gravity;
        }
        Hero.Move(move_Direction * speed_move * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name.Equals("DeathZone"))
        {
            Hero.transform.position += new Vector3(2.868f, 3.192f, 1.304f);


        }
    }

}
