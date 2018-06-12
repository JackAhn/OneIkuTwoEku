using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;

public class HealthController : NetworkBehaviour
{

    public const int maxHealth = 100;

    public Slider healthSliderA;
    public Slider healthSliderB;
    Slider healthSlider;

    // [SyncVar] : 네트워크를 넘나들며 수치를 자동으로 동기화 해준다.
    // hook : TakeDamage가 발동될 때마다 훅이 걸려 자동으로 실행된다.
    [SyncVar(hook = "OnChangeHealth")]

    public int currentHealth = maxHealth;

    void Start()
    {
        if (isServer)
        {
            healthSlider = healthSliderA;
            Debug.Log("A");
        } else
        {
            healthSlider = healthSliderB;
            Debug.Log("B");
        }
    }

    public void TakeDamage(int amount)
    {
        if (!isServer)
        {
            return;
        }
        currentHealth -= amount;
        if (currentHealth <= 0)
        {
            // 피 다 닳음
        }
    }

    void OnChangeHealth(int health)
    {
        healthSlider.value = health;
    }
}