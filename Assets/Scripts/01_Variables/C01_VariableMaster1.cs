using UnityEngine;

namespace Variables
{
    public class C01_VariableMaster1 : MonoBehaviour
    {
        // Create variables for:
        // - name
        // - age
        // - speed
        // - health
        // - score
        // - haveKeysBeenCollected?
        // - ammo count

        [SerializeField] private string _name;
        [SerializeField] private int _age;
        [SerializeField] private float _speed;
        [SerializeField] private int _health;
        [SerializeField] private int _score;
        [SerializeField] private bool _collectedAllKeys;
        [SerializeField] private int _currentAmmo;
    }
}