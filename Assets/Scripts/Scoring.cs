using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scoring : MonoBehaviour
{
    public int addScore;
    private void OnCollisionEnter(Collision collision)
    {
        Score.score += addScore;
        Destroy(collision.gameObject);
    }

}
