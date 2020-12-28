using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//middle man that stores the data to be read for saving
[System.Serializable]
public class PlayerData 
{
    public int health;
    public string name;
    public bool testbool;
    public float gold;
    public float[] position;

    public PlayerData(PlayerStats playerStats)
    {
        health = playerStats.health;
        name = playerStats.name;
        testbool = playerStats.testbool;
        gold = playerStats.gold;

        //Vector 3 saves
        position = new float[3];
        position[0] = playerStats.transform.position.x;
        position[1] = playerStats.transform.position.y;
        position[2] = playerStats.transform.position.z;
    }
}
