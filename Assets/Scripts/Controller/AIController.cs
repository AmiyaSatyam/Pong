using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PONG.Controller
{
    public class AIController : MonoBehaviour
    {
        public float speed = 10;
        public float topBounds = 12.9f;
        public float bottomBounds = -12.9f;
        private Vector2 ballPos;
        [SerializeField] private GameObject pongBall = null;

        private void Update()
        {
            Move();
        }

        private void Move()
        {
            ballPos = pongBall.transform.localPosition;

            if (transform.localPosition.y > bottomBounds && transform.localPosition.y > ballPos.y)
            {
                transform.localPosition += new Vector3(0, -speed * Time.deltaTime, 0);
            }

            if (transform.localPosition.y < topBounds && transform.localPosition.y < ballPos.y)
            {
                transform.localPosition += new Vector3(0, speed * Time.deltaTime, 0);
            }
        }
    }

}