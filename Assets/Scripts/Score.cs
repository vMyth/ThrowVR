using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public static int score;

    public TMPro.TextMeshProUGUI textScore;

    private void Update()
    {
        textScore.text = score.ToString();
    }
}
