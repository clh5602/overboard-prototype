using UnityEngine;

/* Andrew Black
 * 2/16
 * CoinScript determines the behavior of a coin. At present that means its idle animation.
 * Likely this should include behavior for collecting also.
 */

public class CoinScript : MonoBehaviour
{
    // rotation speed, change this value to control how fast the coin spins
    public float rotationSpeed = 72f;

    private void Start()
    {
        Vector3 currentRotation = this.transform.eulerAngles;

        currentRotation.z += 90;

        this.transform.eulerAngles = currentRotation;
    }

    // Update is called once per frame
    void Update()
    {
        this.Spin();
    }

    private void Spin()
    {
        Vector3 currentRotation = this.transform.eulerAngles;

        currentRotation.y += rotationSpeed * Time.deltaTime;

        this.transform.eulerAngles = currentRotation;
    }
}
