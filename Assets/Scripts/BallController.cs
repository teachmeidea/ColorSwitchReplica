using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour {

    public float jumpForce = 10f;
    public Color yellow;
    public Color rose;
    public Color blue;
    public Color violete;

    public SpriteRenderer sp;

    private Rigidbody2D m2dRB;
    private string currentColor;
	void Start () {
        m2dRB = GetComponent<Rigidbody2D>();
        currentColor = "yellow";
        sp.color = yellow;

    }
	
	void Update () {
        if (Input.GetMouseButtonDown(0) && GameController.isPlaying)
        {
            //m2dRB.velocity = Vector3.up * jumpForce;
            m2dRB.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }
	}

    void  OnTriggerEnter2D(Collider2D co)
    {
       

        if (co.tag == "col_change")
        {
            Destroy(co.gameObject);
            int random = Random.Range(0, 4);

            switch (random)
            {
                
                case 1:
                    {
                        sp.color = yellow;
                        currentColor = "yellow";
                    }
                    break;
               case 2:
                    {
                        sp.color = rose;
                        currentColor = "rose";
                    }
                    break;

                case 3:
                    {
                        sp.color = violete;
                        currentColor = "violete";
                    }
                    break;
                case 4:
                    {
                        sp.color = blue;

                        currentColor = "blue";
                    }
                    break;

            }
        }
        else if (co.tag != currentColor)
        {
            GameController.instance.GameOver();
            Destroy(this.gameObject, 0.1f);
        }
        else
        {
            GameController.instance.PassCircle();
        }





    }
}
