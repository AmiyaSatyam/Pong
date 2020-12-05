using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace PONG.Util
{
    public class ScoreManager : MonoBehaviour
    {
        Text leftText;
        Text rightText;

        public void LeftOne(int leftScore)
        {
            leftText = GameObject.Find("LeftScore").GetComponent<Text>();
            leftText.text = leftScore.ToString();
        }

        public void RightOne(int rightScore)
        {
            rightText = GameObject.Find("RightScore").GetComponent<Text>();
            rightText.text = rightScore.ToString();
        }
    }
}
