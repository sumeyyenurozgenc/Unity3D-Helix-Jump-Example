using UnityEngine;
using UnityEngine.UI;

public class HelixController : MonoBehaviour
{
    public float moveSpeed;
    public GameObject prefabFloor;
    private int helixCount = 10;
    private GameObject childObject;
    private int rnd, min = 1, max = 3;

    private void Start()
    {
        Increase();
    }

    private void Update()
    {
        if (GameController.currentState != GameController.GameStates.GameOver)
        {
            float rotation = Input.GetAxis("Mouse X") * (-moveSpeed) * Time.deltaTime;
            transform.Rotate(0, rotation, 0);
        }
    }

    private void Increase()
    {
        for (int i = 1; i <= helixCount; i++)
        {
            childObject = Instantiate(prefabFloor, new Vector3(0, (i * -3), 0.6f), Quaternion.identity);
            childObject.transform.parent = transform; 

            if (i == helixCount)
            {
                for (int j = 0; j < childObject.transform.childCount; j++)
                {
                    childObject.transform.GetChild(j).tag = "nextLevel";
                }
                break;
            }

            rnd = Random.Range(min, max);
            for (int j = 0; j < rnd; j++)
            {
                Destroy(transform.GetChild(i - 1).GetChild(Random.Range(0, 5)).gameObject);
                if (j == rnd-1 && i > 1)
                {
                    Transform sliceNumber = childObject.transform.GetChild(Random.Range(0, 5));
                    sliceNumber.tag = "enemy";
                    sliceNumber.GetComponent<Renderer>().material.color = Color.yellow;
                    break;
                }
            }
        }
    }
}

