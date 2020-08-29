using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BallController : MonoBehaviour
{
    private Rigidbody rb;
    public GameObject ball;
    public GameObject tryAgainPanel;
    public GameObject nextLevelPanel;
    public float jumpSpeed;
    public GameObject ps_bomb;    

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        ps_bomb.SetActive(false);
        tryAgainPanel.SetActive(false);
        nextLevelPanel.SetActive(false);
        GameController.currentState = GameController.GameStates.Start;
    }

    private void FixedUpdate()
    {
        rb.velocity = Vector3.ClampMagnitude(rb.velocity, 5); // the ball doesn't go out 5 in y axis.
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "floor")
        {
            rb.AddForce(0, jumpSpeed, 0, ForceMode.Impulse);
            tryAgainPanel.SetActive(false);
            GameController.currentState = GameController.GameStates.Start;
        }
        else if (collision.gameObject.tag == "enemy")
        {
            tryAgainPanel.SetActive(true);
            ps_bomb.transform.position = transform.position;
            Destroy(gameObject);
            ps_bomb.SetActive(true);
            GameController.currentState = GameController.GameStates.GameOver;
        }
        else if (collision.gameObject.tag == "nextLevel") //you can fill your idea.
        {
            nextLevelPanel.SetActive(true);
            ps_bomb.transform.position = transform.position;
            Destroy(gameObject);
            ps_bomb.SetActive(true);
            GameController.currentState = GameController.GameStates.GameOver;
        }
    }

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.tag == "trigger")
        {
            GameController.Instance.IncScore(1);
        }
    }
}
