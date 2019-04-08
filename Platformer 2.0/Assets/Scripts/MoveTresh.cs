
using UnityEngine;

public class MoveTresh : MonoBehaviour
{
    float treshSpeed = 2f;
    public float treshSpeed1 = 2f;

    public int localScore1 = 10;
    public int localScore2 = 20;
    public int localScore3 = 30;
    int koef = 30;

    private void Update()
    {

        if (Player.Score >= localScore1)
        {
            treshSpeed = treshSpeed1 * 0.95f;
        }
        if (Player.Score >= localScore2)
        {
            treshSpeed = treshSpeed1;
        }
        if (Player.Score >= localScore3)
        {
            treshSpeed = treshSpeed1 * 1.02f;
            treshSpeed1 = treshSpeed;
        }

        localScore1 = localScore1 + koef;
        localScore2 = localScore2 + koef;
        localScore3 = localScore3 + koef;

        if (transform.position.y < -6f)
            Destroy(gameObject);

        transform.position -= new Vector3(0, treshSpeed * Time.deltaTime, 0);
    }
}
