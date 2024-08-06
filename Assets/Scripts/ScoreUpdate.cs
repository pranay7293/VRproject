using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class ScoreUpdate : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI scoreText;
    [SerializeField] private TextMeshProUGUI targetText;

    private int score;
    private bool hit;
    private float timehit;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        targetText.gameObject.SetActive(false);
        TargetHit.TargetHitter += UpdateUI;        
    }

    private void UpdateUI()
    {
        score += 5;
        scoreText.text = "Score: " + score.ToString("D3");
        HitUpdate();
    }

    private void HitUpdate()
    {
        if (hit)
        {
            targetText.gameObject.SetActive(true);
            hit = false;
        }
    }
    private void Update()
    {
        if (hit == false)
        {
            targetText.gameObject.SetActive(false);
            timehit += Time.time;
            if (timehit >= 1) { hit = true; }
        }
    }
    private void OnDisable()
    {
        TargetHit.TargetHitter -= UpdateUI;
    }
}
