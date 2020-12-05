using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PONG.Util
{
    public class Score : MonoBehaviour
    {
        public int leftScore = 0;
        public int rightScore = 0;
        public void LeftScore()
        {
            leftScore++;
            GetComponent<ScoreManager>().LeftOne(leftScore);
        }

        public void RightScore()
        {
            rightScore++;
            GetComponent<ScoreManager>().RightOne(rightScore);
        }
    }
}
