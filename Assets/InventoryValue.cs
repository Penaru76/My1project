using UnityEngine;

public class InventoryValue : MonoBehaviour
{
    private int count = 0;
    private int coinValue = 10;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            count++;
        }

        if (count == 5)
        {
            int sum = 0;
            for (int i = 1; i <= count; i++)
            {
                sum += coinValue;
            }

            Debug.Log("Coins: " + count + ", total value: " + sum);

            count = 0;
        }
    }
}