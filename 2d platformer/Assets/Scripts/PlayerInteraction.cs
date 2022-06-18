using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerInteraction : MonoBehaviour
{
    public float health = 1;
    
    public void TakeDamage(float damage)
    {
        health -= damage;
        if (health <= 0)
        {
            Die();
        }
        Debug.Log("dmg "+ damage);
        Debug.Log("heal " + health);
    }
    public void Die()
    {
        SceneManager.LoadScene(0);
    }
}
