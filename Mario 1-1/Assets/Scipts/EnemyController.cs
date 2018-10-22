using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{


    private Animator anim;

    public float speed;


    //Wall check
    private bool wallHit;
    public Transform wallHitBox;
    public float wallHitHeight;
    public float wallHitWidth;
    public LayerMask isGround;

    private bool headHit;
    public Transform headHitBox;
    public float headHitHeight;
    public float headHitWidth;
    public LayerMask isPlayer;



    // Use this for initialization
    void Start()
    {
        anim = GetComponent<Animator>();
    }
    void FixedUpdate()
    {
        transform.Translate(speed * Time.deltaTime, 0, 0);

        wallHit = Physics2D.OverlapBox(wallHitBox.position, new Vector2(wallHitWidth, wallHitHeight), 0, isGround);
        if (wallHit == true)
        {
            speed = speed * -1;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        headHit = Physics2D.OverlapBox(headHitBox.position, new Vector2(headHitWidth, headHitHeight), 0, isPlayer);
        if (headHit == true)
        {

            Debug.Log("I loved living");
            Destroy(gameObject);
        }
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawCube(wallHitBox.position, new Vector3(wallHitWidth, wallHitHeight, 1));
        Gizmos.color = Color.blue;
        Gizmos.DrawCube(headHitBox.position, new Vector3(headHitWidth, headHitHeight, 1));
    }
    // Update is called once per frame
    void Update()
    {

    }

}
