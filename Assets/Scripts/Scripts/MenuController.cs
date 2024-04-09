﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class MenuController : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject menuChinh;
    public PlayerData playerData;
    public Text Level;
    public Text Score;
    void Start()
    {
        HideMenu();
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (menuChinh.activeSelf)
            {
                HideMenu();
            }
            else
            {
                ShowMenu();
                LoadPlayerData();
            }
        }
    }

    void ShowMenu()
    {
        menuChinh.SetActive(true);
        Time.timeScale = 0f; // Dừng thời gian trong trò chơi khi hiển thị menu
    }

    void HideMenu()
    {
        menuChinh.SetActive(false);
        Time.timeScale = 1f; // Khôi phục thời gian khi ẩn menu
    }

    void LoadPlayerData()
    {
        // Đọc dữ liệu người chơi từ file lưu trữ
        if (PlayerPrefs.HasKey("PlayerLevel"))
        {
            playerData.playerLevel = PlayerPrefs.GetInt("PlayerLevel");
            playerData.playerScore = PlayerPrefs.GetInt("PlayerScore");
            Level.text ="Level:" +  (playerData.playerLevel).ToString();
            Score.text = "Score:" + (playerData.playerScore).ToString();
            //Debug.Log("Player data loaded.");
          
        }
        else
        {
            //Debug.LogWarning("Player data not found. Starting with default values.");
            // Gán giá trị mặc định nếu không tìm thấy dữ liệu người chơi
            playerData.playerLevel = 0;
            playerData.playerScore = 0;
        }

    }
}
