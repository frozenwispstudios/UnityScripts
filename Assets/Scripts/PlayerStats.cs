using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Inplayer scene
public class PlayerStats : MonoBehaviour
{
    public int health;
    public string name;
    public bool testbool;
    public float gold;

    public void SavePlayer()
    {
        SaveSystem.SavePlayer(this);
    }

    public void LoadPlayer()
    {
        PlayerData data = SaveSystem.LoadPlayer();

        health = data.health;
        name = data.name;
        testbool = data.testbool;
        gold = data.gold;

        Vector3 position;
        position.x = data.position[0];
        position.y = data.position[1];
        position.z = data.position[2];
    }
}
