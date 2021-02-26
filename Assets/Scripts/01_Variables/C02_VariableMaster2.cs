using UnityEngine;

namespace Variables
{
    public class C02_VariableMaster2 : MonoBehaviour
    {
        // Every item has:
        //  - name
        //  - description
        //  - a sprite
        //  - a strength value 

        [SerializeField] private string _itemName;
        [SerializeField] private string _itemDescription;
        [SerializeField] private Sprite _itemSprite;
        [SerializeField] private float _attackStrength;
    }
}