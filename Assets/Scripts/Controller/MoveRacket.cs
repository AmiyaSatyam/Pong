using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PONG.Controller
{

    public class MoveRacket : MonoBehaviour
    {
        public float speed = 30;
        public string axis = "Vertical";

        void FixedUpdate()
        {
            float v = Input.GetAxisRaw(axis);
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, v) * speed;
        }
    }

}