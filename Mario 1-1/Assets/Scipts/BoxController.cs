using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxController : MonoBehaviour {

    private Animator anim;




    //Wall check
    private bool wallHit;
    public Transform wallHitBox;
    public float wallHitHeight;
    public float wallHitWidth;
    public LayerMask isGround;
    public GameObject pickup;
    private int i;

    // Use this for initialization
    void Start()
    {
        anim = GetComponent<Animator>();
    }
    void FixedUpdate()
    {
        wallHit = Physics2D.OverlapBox(wallHitBox.position, new Vector2(wallHitWidth, wallHitHeight), 0, isGround);
            if (wallHit == true)
            {
                Instantiate(pickup);

        }
    }
  
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawCube(wallHitBox.position, new Vector3(wallHitWidth, wallHitHeight, 1));
    }
    // Update is called once per frame
    void Update()
    {

    }

}

 