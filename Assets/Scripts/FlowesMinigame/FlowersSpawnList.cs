using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlowersSpawnList : MonoBehaviour
{
    public GameObject FlowerPrefab;
    public GameObject list;
    public List<string> _flowers= new List<string>();

    readonly int amount = 20;
    float yPos = 5.5F;
    public int FlowersAmount = 0;

    struct FlowerType
    {
        public string Name;
        public string Color;
        public string Feeling;


        public FlowerType(string name, string color, string feeling)
        {
            Name = name;
            Color = color;
            Feeling = feeling;

        }
    }

    private static readonly FlowerType[] FlowerTypes = new FlowerType[20]
    {
        new FlowerType("Dalia Malva", "Malva", "Agradecimiento y gratitud"),
        new FlowerType("Campánula", "Morada", "Agradecimiento y gratitud"),
        new FlowerType("Ciclamen", "rosa", "Decepción, desconfianza"),
        new FlowerType("Jazmín blanco", "Blanco", "Amistad"),
        new FlowerType("Rosa amarilla", "Amarilla", "Amistad"),
        new FlowerType("Adelfa", "rosa", "Seducción, amor secreto"),
        new FlowerType("Clavel", "Roja", "Seducción, amor secreto"),
        new FlowerType("Flor de lis", "Roja", "Amor eterno, amor verdadero"),
        new FlowerType("Mirto", "Blanca", "Amor eterno, amor verdadero"),
        new FlowerType("Clemátide", "Morada", "Belleza, belleza del alma"),
        new FlowerType("Orquídea", "Blanca", "Belleza, belleza del alma"),
        new FlowerType("Rosa roja", "Roja", "Belleza, belleza del alma"),
        new FlowerType("Iris azul", "Azul", "Buena suerte, buenas noticias"),
        new FlowerType("Jade", "Rosa", "Buena suerte, buenas noticias"),
        new FlowerType("Neguilla", "Rosa", "Pureza del corazón"),
        new FlowerType("Lirio", "Blanca", "Pureza del corazón"),
        new FlowerType("Centaurea", "Morada", "Felicidad, alegría, confianza"),
        new FlowerType("Coreopsis", "Amarilla", "Felicidad, alegría, confianza"),
        new FlowerType("Lirio del Valle", "Blanca", "Felicidad, alegría, confianza"),
        new FlowerType("Gardenia", "Blanca", "Sinceridad")
    };


    void Awake()
    {
        for (int i = 0; i < amount; i++)
        {
            yPos -= 1.5F;
            FlowerPrefab.name = FlowerTypes[i].Name;
            FlowerPrefab.GetComponent<DragAndDrop>().fname = FlowerTypes[i].Name;
            FlowerPrefab.GetComponent<DragAndDrop>().fcolor = FlowerTypes[i].Color;
            FlowerPrefab.GetComponent<DragAndDrop>().ffeeling = FlowerTypes[i].Feeling;
            Instantiate(FlowerPrefab, new Vector3(10.3F, yPos, 0), FlowerPrefab.transform.localRotation);
            _flowers.Add(FlowerPrefab.name);
        }
    }

}