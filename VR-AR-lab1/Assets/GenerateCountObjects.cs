using TMPro;
using UnityEngine;

public class GenerateCountObjects : MonoBehaviour
{
    [SerializeField] private Transform point;
    [SerializeField] private GameObject generatedObject;

    public void GenerateObjects()
    {
        var countObjects = int.Parse(GetComponent<TMP_InputField>().text);

        for (var i = 0; i < countObjects; i++)
            Instantiate(
                generatedObject, 
                new Vector3(
                    point.position.x + i * 100,
                    point.position.y,
                    point.position.z
                    ), 
                Quaternion.identity);
    }
}
