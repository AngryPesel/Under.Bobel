
using UnityEngine;

public class MoveTresh : MonoBehaviour
{
    public float treshSpeed = 3f;
    public float treshSpeed_10;
    public float treshSpeed_20;
    public float treshSpeed_30;
    public float treshSpeed_40;
    public float treshSpeed_60;
    public float treshSpeed_80;
    public float treshSpeed_100;

    private void Update()
    {
        if (Player.Score >= 10)
        {
            treshSpeed = treshSpeed_10;
        }
        if (Player.Score >= 20)
        {
            treshSpeed = treshSpeed_20;
        }
        if (Player.Score >= 30)
        {
            treshSpeed = treshSpeed_30;
        }
        if (Player.Score >= 40)
        {
            treshSpeed = treshSpeed_40;
        }
        if (Player.Score >= 60)
        {
            treshSpeed = treshSpeed_60;
        }
        if (Player.Score >= 80)
        {
            treshSpeed = treshSpeed_80;
        }
        if (Player.Score >= 100)
        {
            treshSpeed = treshSpeed_100;
        }

        if (transform.position.y < -6f)
            Destroy(gameObject);

        transform.position -= new Vector3(0, treshSpeed * Time.deltaTime, 0);
    }
}
