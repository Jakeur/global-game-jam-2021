using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class HealthManager : MonoBehaviour
{
	public int maxHealth = 5;
	public int currentHealth;

	public HealthBar healthBar;

    public static HealthManager Instance { get; private set; }

    // Event to register
    public UnityEvent looseHeadBack;
    public UnityEvent looseRightArm;
    public UnityEvent looseLeftArm;
    public UnityEvent looseRightLeg;
    public UnityEvent looseLeftLeg;
    public UnityEvent playerDead;

    private void CreateInstance()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            Instance = this;
        }
    }

    // Start is called before the first frame update
    void Awake()
    {
        CreateInstance();

        ResetHealth();
    }

    // Update is called once per frame
    void Update()
    {
		if (Input.GetKeyDown(KeyCode.H))
		{
			TakeDamage();
		}
    }

	void TakeDamage()
	{
		currentHealth -= 1;

		healthBar.SetHealth(currentHealth);

        MemberUpdate();
    }

    void ResetHealth()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }


    void MemberUpdate()
    {
        if (currentHealth == 4 && looseHeadBack != null)
            looseHeadBack.Invoke();
        else if (currentHealth == 3 && looseRightArm != null)
            looseRightArm.Invoke();
        else if (currentHealth == 2 && looseLeftArm != null)
            looseLeftArm.Invoke();
        else if (currentHealth == 1 && looseRightLeg != null)
            looseRightLeg.Invoke();
        else if (currentHealth == 0 && looseLeftLeg != null)
        {
            looseLeftLeg.Invoke();
            playerDead.Invoke();
            ResetHealth();
        }
    }
}
