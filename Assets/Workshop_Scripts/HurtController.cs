using System;
using UnityEngine;

public class HurtController : MonoBehaviour
{
    [SerializeField]
    public int health = 1;

    public void Damage(int amount)
    {
        health -= amount;
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }
}
