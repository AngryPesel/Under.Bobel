using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public Transform player;
    public static float speed;

    float timeSpeedUP = 5f;

    private void Start()
    {
        speed = 15f;
    }

    private void Update()
    {
        if (Player.speedUP == true)
        {
            timeSpeedUP -= Time.deltaTime;
            if (timeSpeedUP <= 0)
            {

                speed = 15f;
                Player.speedUP = false;
                timeSpeedUP = 5f;
            }
        }
    }

    void OnMouseDrag()
    {
        if (!Player.lose)
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            mousePos.x = mousePos.x > 2.5f ? 2.5f : mousePos.x;
            mousePos.x = mousePos.x < -2.5f ? -2.5f : mousePos.x;

            /*mousePos.y = mousePos.y > 4.5f ? 4.5f : mousePos.y;
            mousePos.y = mousePos.y < -4.5f ? -4.5f : mousePos.y;*/

            player.position = Vector2.MoveTowards(player.position, new Vector2(mousePos.x, -4/*mousePos.y*/), speed * Time.deltaTime);
        }
    }


}
