using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public Transform player; // cam
    public float speed;
    public float distDaño;

    void Update()
    {
        transform.LookAt(player);
        Vector3 direction = (player.position - transform.position).normalized;
        transform.position += direction * speed * Time.deltaTime;

        float distance = Vector3.Distance(transform.position, player.position);

        if (distance < distDaño)
        {   
            Debug.Log("Te ha golpeado el enemigo");
            //Quitar vidaa
            Destroy(gameObject);
        }
    }
}