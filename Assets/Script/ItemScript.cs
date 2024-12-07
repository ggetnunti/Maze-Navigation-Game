using UnityEngine;

public class ItemScript : MonoBehaviour
{
    void Update()
    {
        // rotate the object
        transform.Rotate(new Vector3(0, 45, 0)*Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        // when the item collected by player, it will destroy
        if (other.gameObject.tag == "Player")
        {
            Destroy(gameObject);
        }
    }
}
