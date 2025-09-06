using UnityEngine;

public class CreateObstacles : MonoBehaviour
{

    public GameObject defaultObstaclePrefab;
    public GameObject defaultObstaclePrefab_2;
    public GameObject defaultObstaclePrefab_3;
    //public Vector3 position = new Vector3(25f, -2.35f, 0f);
    public Vector3 position = Vector3.zero;

    private void OnEnable()
    {
        InvokeRepeating(nameof(Spawn), 1f, 2.5f);
    }

    private void OnDisable()
    {
        CancelInvoke(nameof(Spawn));
    }

    private void Spawn()
    {
        //GameObject obstacle = Instantiate(defaultObstaclePrefab);
        //GameObject obstacle_2 = Instantiate(defaultObstaclePrefab_2);
        //GameObject obstacle_3 = Instantiate(defaultObstaclePrefab_3);

        GameObject obstacle;

        int randomNum = Random.Range(1, 12);

        if (randomNum >= 1 && randomNum <= 4)
        {
            obstacle = Instantiate(defaultObstaclePrefab);
            obstacle.GetComponent<ObstacleBehaviour>().enabled = true;
            obstacle.transform.position = position;
        }
        else if (randomNum >= 5 && randomNum <= 8)
        {
            obstacle = Instantiate(defaultObstaclePrefab_2);
            obstacle.GetComponent<ObstacleBehaviour>().enabled = true;
            obstacle.transform.position = position;
        }
        else if (randomNum >= 9 && randomNum <= 12)
        {
            obstacle = Instantiate(defaultObstaclePrefab_3);
            obstacle.GetComponent<ObstacleBehaviour>().enabled = true;
            obstacle.transform.position = position;
        }
    }
}
