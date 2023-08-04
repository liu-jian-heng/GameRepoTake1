using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class charactor : MonoBehaviour
{
    // Start is called before the first frame update
    public uint speed = 10;
    public Animator animator;
    public SpriteRenderer sprite;
    Vector3 move;
    private void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        move.x = Input.GetAxisRaw("Horizontal");
        move.y = Input.GetAxisRaw("Vertical");
        move.z = 0;
        animator.SetFloat("speed", move.sqrMagnitude);

        if (Input.GetKey(KeyCode.UpArrow)) transform.position += Vector3.up * speed * Time.deltaTime;
        else if (Input.GetKey(KeyCode.LeftArrow)) { transform.position += Vector3.left * speed * Time.deltaTime; sprite.flipX = true; }
        else if (Input.GetKey(KeyCode.RightArrow)) { transform.position += Vector3.right * speed * Time.deltaTime; sprite.flipX = false; }
    }
}
