using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PONG.Util;

namespace PONG.Controller
{
    public class Ball : MonoBehaviour
    {
        public float speed = 30;
        Score score;

        void Start()
        {
            GetComponent<Rigidbody2D>().velocity = Vector2.right * speed;
            score = GetComponent<Score>();
        }

        void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.gameObject.name == "WallLeft")
            {
                score.RightScore();
                transform.position = Vector2.zero;
                GetComponent<Rigidbody2D>().velocity = Vector2.right * speed;
            }
            else if (collision.gameObject.name == "WallRight")
            {
                score.LeftScore();
                transform.position = Vector2.zero;
                GetComponent<Rigidbody2D>().velocity = Vector2.left * speed;
            }
            else if (collision.gameObject.name == "RacketLeft")
            {
                float y = hitFactor(transform.position, collision.transform.position, collision.collider.bounds.size.y);

                Vector2 dir = new Vector2(1, y).normalized;
                GetComponent<Rigidbody2D>().velocity = dir * speed;
            }

            else if (collision.gameObject.name == "RacketRight")
            {
                float y = hitFactor(transform.position, collision.transform.position, collision.collider.bounds.size.y);

                Vector2 dir = new Vector2(-1, y).normalized;
                GetComponent<Rigidbody2D>().velocity = dir * speed;
            }
        }

        float hitFactor(Vector2 ballPos, Vector2 racketPos, float racketHeight)
        {
            return (ballPos.y - racketPos.y) / racketHeight;
        }
    }
}
