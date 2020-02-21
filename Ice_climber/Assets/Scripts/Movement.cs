using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Rigidbody2D m_MonRigidBody;
    private Vector2 m_MaVelocity;
    public Vector2 m_ForceJump;
    private bool In_air;

    private void Start()
    {
        m_MaVelocity = new Vector2();

        In_air = false;
    }
    // Update is called once per frame
    void Update()
    {

        m_MaVelocity = m_MonRigidBody.velocity;

        if (Input.GetKey(KeyCode.A))
        {
            m_MaVelocity.x = -8f;

        }

        else if (Input.GetKey(KeyCode.D))
        {
            m_MaVelocity.x = 8f;

        }

        else
        {
            m_MaVelocity.x = 0f;

        }



        m_MonRigidBody.velocity = m_MaVelocity;

        RaycastHit2D hit2D = Physics2D.Raycast(transform.position, new Vector2(0f, -1f), 2f, LayerMask.GetMask("Plateforme"));
        Debug.DrawRay(transform.position, new Vector2(0f, -1f) * 2f, Color.magenta);



            if (hit2D.collider != null)
            {
                In_air = true;
            }

            else
            {
                In_air = false;
            }


            if (In_air && Input.GetKeyDown(KeyCode.Space))
            {
                m_MonRigidBody.AddForce(m_ForceJump, ForceMode2D.Impulse);
                In_air = false;
            }



    }




}
