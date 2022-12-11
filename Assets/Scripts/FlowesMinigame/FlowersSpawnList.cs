using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class FlowersSpawnList : MonoBehaviour
{
    public GameObject FlowerPrefab;
    public GameObject FlowerBase;
    public GameObject list;
    
    public List<string> _flowers= new List<string>();

    readonly int amount = 20;
    float xPos;
    float yPos;
    float zPos;
    public int FlowersAmount = 0;
    string spriteName;

    struct FlowerType
    {
        public string Name;
        public string Color;
        public string Feeling;
        public string Favorite;
        public string Hate;
        public float TotalColor;
        public float TotalFeeling;

        public FlowerType(string name, string color, string feeling, string favorite, string hate, float totalColor, float totalFeeling)
        {
            Name = name;
            Color = color;
            Feeling = feeling;
            Favorite = favorite;
            Hate = hate;
            TotalColor = totalColor;
            TotalFeeling = totalFeeling;

        }
    }

    private static readonly FlowerType[] FlowerTypes = new FlowerType[20]
    {
        new FlowerType("Dalia Malva", "Morado", "Agradecimiento y gratitud", "Sophie", "", 4, 2),
        new FlowerType("Campánula", "Morado", "Agradecimiento y gratitud","", "", 4, 2),
        new FlowerType("Ciclamen", "Rosa", "Decepción, desconfianza", "", "Sagrario", 4, 3),
        new FlowerType("Jazmín blanco", "Blanco", "Amistad", "", "", 6, 2),
        new FlowerType("Rosa amarilla", "Amarillo", "Amistad", "", "Sophie", 2, 2),
        new FlowerType("Adelfa", "Rosa", "Seducción, amor secreto", "", "", 4, 2),
        new FlowerType("Clavel", "Rojo", "Seducción, amor secreto", "", "Allan", 3, 2),
        new FlowerType("Flor de lis", "Rojo", "Amor eterno, amor verdadero", "", "Ethan", 3, 2),
        new FlowerType("Mirto", "Blanco", "Amor eterno, amor verdadero", "Sagrario", "", 6, 2),
        new FlowerType("Clemátide", "Morado", "Sinceridad", "", "", 4, 3),
        new FlowerType("Orquídea", "Blanco", "Decepción, desconfianza", "", "", 6, 3),
        new FlowerType("Rosa roja", "Rojo", "Pureza del corazón", "", "Pietro", 3, 3),
        new FlowerType("Iris azul", "Azul", "Decepción, desconfianza", "", "", 1, 3),
        new FlowerType("Jade", "Rosa", "Sinceridad", "", "", 4, 3),
        new FlowerType("Neguilla", "Rosa", "Pureza del corazón", "", "", 4, 3),
        new FlowerType("Lirio", "Blanco", "Pureza del corazón", "Allan", "", 6, 3),
        new FlowerType("Centaurea", "Morado", "Felicidad, alegría, confianza", "Pietro", "", 4, 3),
        new FlowerType("Coreopsis", "Amarillo", "Felicidad, alegría, confianza", "", "", 2, 3),
        new FlowerType("Lirio del Valle", "Blanco", "Felicidad, alegría, confianza", "", "", 6, 3),
        new FlowerType("Gardenia", "Blanco", "Sinceridad", "Ethan", "", 6, 3)
    };


    void Awake()
    {

        xPos = FlowerBase.transform.position.x;
        yPos = FlowerBase.transform.position.y;
        zPos = FlowerBase.transform.position.z;
        for (int i = 0; i < amount; i++)
        {
            FlowerPrefab.name = FlowerTypes[i].Name;
            FlowerPrefab.GetComponent<DragAndDrop>().fname = FlowerTypes[i].Name;
            FlowerPrefab.GetComponent<DragAndDrop>().fcolor = FlowerTypes[i].Color;
            FlowerPrefab.GetComponent<DragAndDrop>().ffeeling = FlowerTypes[i].Feeling;
            FlowerPrefab.GetComponent<DragAndDrop>().fav = FlowerTypes[i].Favorite;
            FlowerPrefab.GetComponent<DragAndDrop>().hate = FlowerTypes[i].Hate;
            FlowerPrefab.GetComponent<DragAndDrop>().fTotalColor = FlowerTypes[i].TotalColor;
            FlowerPrefab.GetComponent<DragAndDrop>().fTotalFeeling = FlowerTypes[i].TotalFeeling;

            spriteName = (i + 1).ToString();
            FlowerPrefab.GetComponent<Image>().sprite = Resources.Load<Sprite>("Flowers/" + spriteName);
            FlowerPrefab.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Flowers/" + spriteName);
            FlowerPrefab.GetComponent<Image>().preserveAspect = true;
            Instantiate(FlowerPrefab, new Vector3(xPos, yPos, zPos), FlowerPrefab.transform.localRotation);
            _flowers.Add(FlowerPrefab.name);

            yPos -= 4.4F;

        }
    }
}