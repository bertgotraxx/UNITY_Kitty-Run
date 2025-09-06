using UnityEngine;

public class ObstacleBehaviour : MonoBehaviour
{
    float lifeTime = 0;
    void Update()
    {
        transform.position += Vector3.left * Time.deltaTime * 8.75f;
        lifeTime += Time.deltaTime;

        if (lifeTime >= 10)
        {
            Destroy(gameObject);
        }
    }
}
