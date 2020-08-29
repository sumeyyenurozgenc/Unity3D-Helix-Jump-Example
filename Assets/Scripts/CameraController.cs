using UnityEngine;

public class CameraController : MonoBehaviour
{
    public BallController targetBall;
    public float offset;
    private float targetPos = 0;
    public float smooth = 5;

    private void FixedUpdate()
    {
        if (targetBall == null)
            return;
        float dist = transform.position.y - targetBall.transform.position.y;

        if (dist > offset)
        {
            targetPos = targetBall.transform.position.y + 0.5f;
        }

        Vector3 pos = transform.position;
        pos.y = Mathf.Lerp(pos.y, targetPos, smooth * Time.fixedDeltaTime);
        transform.position = pos;
    }
}
