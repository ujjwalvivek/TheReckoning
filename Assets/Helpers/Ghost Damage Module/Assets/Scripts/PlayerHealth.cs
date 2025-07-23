using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{

	public float maxHealth = 100f;
	public float currentHealth;

	[SerializeField] AudioSource audioSource;
	[SerializeField] AudioListener audioListener;

	public HealthBar healthBar;

	// Start is called before the first frame update
	void Start()
	{
		currentHealth = maxHealth;
		healthBar.SetMaxHealth(maxHealth);
	}

	// Update is called once per frame
	void Update()
	{
		float distance = Vector3.Distance(audioListener.transform.position, audioSource.transform.position);

		if (distance < 10f)
		{
            //TakeDamage(5);
            damageOverTime(0.1f, 4f);
        }
        else if (currentHealth < maxHealth)
        {
            healOverTime(0.5f, 4f);
        }

        //if (currentHealth > maxHealth)
        //{
        //    currentHealth = maxHealth;
        //}

        if(currentHealth == 0)
        {
            Destroy(this.gameObject);
        }
    }

    //private void OnTriggerEnter(Collider other)
    //{
    //    damageOverTime(50, 4);
    //}

    //private void OnTriggerExit(Collider other)
    //{
    //    healOverTime(50, 4);
    //}

    //void TakeDamage(int damage)
    //{
    //    currentHealth -= damage;

    //    healthBar.SetHealth(currentHealth);
    //}

    //Damage over time Coroutine
    IEnumerator DamageOverTimeCoroutine(float damageAmount, float duration)
    {
        yield return new WaitForSeconds(1f);
        float amountDamaged = 0f;
        float damagePerLoop = damageAmount / duration;
        while (amountDamaged < damageAmount && currentHealth >= 0 && damagePerLoop < currentHealth)
        {
            currentHealth -= damagePerLoop;
            amountDamaged += damagePerLoop;
            healthBar.SetHealth(currentHealth);
        }

        if(damagePerLoop > currentHealth)
        {
            currentHealth = 0;
        }
    }

    //Heal over time Coroutine
    IEnumerator HealOverTimeCoroutine(float healAmount, float duration)
    {
        yield return new WaitForSeconds(1f);
        float amountHealed = 0f;
        float healPerLoop = healAmount / duration;
        while (amountHealed < healAmount && currentHealth <= maxHealth /*&& amountHealed <= currentHealth*/)
        {
            currentHealth += healPerLoop;
            amountHealed += healPerLoop;
            healthBar.SetHealth(currentHealth);
        }

        if(currentHealth > maxHealth)
        {
            currentHealth = maxHealth;
        }
    }

    //Calling the HealOverTimeCoroutine
    public void healOverTime(float healAmount, float duration)
    {
        StartCoroutine(HealOverTimeCoroutine(healAmount, duration));
    }

    //Calling the DamageOverTimeCoroutine
    public void damageOverTime(float damageAmount, float duration)
    {
        StartCoroutine(DamageOverTimeCoroutine(damageAmount, duration));
    }
}