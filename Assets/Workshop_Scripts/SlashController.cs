using System;
using UnityEngine;

public class SlashController : MonoBehaviour
{
    public int direction = 1;
    [SerializeField]
    public float speed = 1;

    private float aliveTime = 4;
    void Update()
    {
        aliveTime -= Time.deltaTime;
        if (aliveTime <= 0)
        {
            Destroy(gameObject);
        }
        gameObject.transform.eulerAngles = new Vector3(0, 0, direction == 1 ? 270 : 90);
        gameObject.transform.position = new Vector3(gameObject.transform.position.x+speed*direction, gameObject.transform.position.y, gameObject.transform.position.z);
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Damageable"))
        {
            other.gameObject.GetComponent<HurtController>().Damage(1);
            Destroy(gameObject);
        }   
    }
}
