using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DamageTracker : MonoBehaviour
{
    public PlayerHandler player_script;
    public GameObject player;
    public int numberOfHearts;

    public Image[] hearts;
    public Sprite SmallCrystal;
    public Sprite BigCrystal;
    public Sprite Invis;
    void Update()
    {
	player_script = player.GetComponent<PlayerHandler>();
	int health = player_script.HP;
        for(int i = 0; i < hearts.Length; i++)
        {
             if(i < health && i % 2 == 1)
             {
                 hearts[i].sprite = SmallCrystal;
             }
             else if (i < health && i % 2 == 0)
             {
                 hearts[i].sprite = BigCrystal;
             }
             else
             {
                 hearts[i].sprite = Invis;
             }
            if (i < numberOfHearts)
            {
                hearts[i].enabled = true;
            }
            else
            {
                hearts[i].enabled = false;
            }
        }
    }
}
