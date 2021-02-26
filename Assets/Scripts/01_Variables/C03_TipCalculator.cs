using UnityEngine;

namespace Variables
{
    public class C03_TipCalculator : MonoBehaviour
    {
        // Your bill is 40 bucks
        // Tip is either 20% or whatever the user enters
        // Calculate the tip and the total amount

        private const float _bill = 40.0f;
        [SerializeField] private float _tipPercentage = 20.0f;
        private float _tipAmount;
        private float _totalAmount;

        private void Start()
        {
            _tipAmount = _bill * (_tipPercentage / 100f);
            _totalAmount = _bill + _tipAmount;

            Debug.Log("Your bill: " + _bill);
            Debug.Log("Your tip: " + _tipAmount);
            Debug.Log("Your total sum: " + _totalAmount);
        }
    }
}