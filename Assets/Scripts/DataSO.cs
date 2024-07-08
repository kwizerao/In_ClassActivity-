using UnityEngine;

[CreateAssetMenu(fileName = "NewDataObject", menuName = "ScriptableObjects/DataSO")]
public class DataSO : ScriptableObject
{
    public string dataText;
    public Sprite dataImage;
}
