using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform player;
    public float offsetY = 0f;
    public float offsetZ = 0f;
    // Start is called before the first frame update
    void Start()
    {
            }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(player.transform.position.x, offsetY, offsetZ);
    }
}
