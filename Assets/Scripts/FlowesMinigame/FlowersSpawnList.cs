using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FlowersSpawnList : MonoBehaviour
{
    public GameObject FlowerNamePrefab;
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
        public string Favorite;
        public string Hate;


        public FlowerType(string name, string color, string feeling, string favorite, string hate)
        {
            Name = name;
            Color = color;
            Feeling = feeling;
            Favorite = favorite;
            Hate = hate;
        }
    }

    private static readonly FlowerType[] FlowerTypes = new FlowerType[20]
    {
        new FlowerType("Dalia Malva", "Malva", "Agradecimiento y gratitud", "Sophie", ""),
        new FlowerType("Camp�nula", "Morado", "Agradecimiento y gratitud","", ""),
        new FlowerType("Ciclamen", "Rosa", "Decepci�n, desconfianza", "", "Sagrario"),
        new FlowerType("Jazm�n blanco", "Blanco", "Amistad", "", ""),
        new FlowerType("Rosa amarilla", "Amarillo", "Amistad", "", "Sophie"),
        new FlowerType("Adelfa", "Rosa", "Seducci�n, amor secreto", "", ""),
        new FlowerType("Clavel", "Rojo", "Seducci�n, amor secreto", "", "Allan"),
        new FlowerType("Flor de lis", "Rojo", "Amor eterno, amor verdadero", "", "Ethan"),
        new FlowerType("Mirto", "Blanco", "Amor eterno, amor verdadero", "Sagrario", ""),
        new FlowerType("Clem�tide", "Morado", "Belleza, belleza del alma", "", ""),
        new FlowerType("Orqu�dea", "Blanco", "Belleza, belleza del alma", "", ""),
        new FlowerType("Rosa roja", "Rojo", "Belleza, belleza del alma", "", "Pietro"),
        new FlowerType("Iris azul", "Azul", "Buena suerte, buenas noticias", "", ""),
        new FlowerType("Jade", "Rosa", "Buena suerte, buenas noticias", "", ""),
        new FlowerType("Neguilla", "Rosa", "Pureza del coraz�n", "", ""),
        new FlowerType("Lirio", "Blanco", "Pureza del coraz�n", "Allan", ""),
        new FlowerType("Centaurea", "Morado", "Felicidad, alegr�a, confianza", "Pietro", ""),
        new FlowerType("Coreopsis", "Amarillo", "Felicidad, alegr�a, confianza", "", ""),
        new FlowerType("Lirio del Valle", "Blanco", "Felicidad, alegr�a, confianza", "", ""),
        new FlowerType("Gardenia", "Blanco", "Sinceridad", "Ethan", "")
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
            FlowerPrefab.GetComponent<DragAndDrop>().fav = FlowerTypes[i].Favorite;
            FlowerPrefab.GetComponent<DragAndDrop>().hate = FlowerTypes[i].Hate;

            if(FlowerPrefab.GetComponent<DragAndDrop>().fcolor == "Malva")
            {
                FlowerPrefab.GetComponent<SpriteRenderer>().color = new UnityEngine.Color32(224, 176, 255, 255);
            }
            else if(FlowerPrefab.GetComponent<DragAndDrop>().fcolor == "Morado")
            {
                FlowerPrefab.GetComponent<SpriteRenderer>().color = new UnityEngine.Color32(108, 52, 131, 255);
            }
            else if (FlowerPrefab.GetComponent<DragAndDrop>().fcolor == "Rosa")
            {
                FlowerPrefab.GetComponent<SpriteRenderer>().color = new UnityEngine.Color32(255, 0, 128, 255);
            }
            else if (FlowerPrefab.GetComponent<DragAndDrop>().fcolor == "Blanco")
            {
                FlowerPrefab.GetComponent<SpriteRenderer>().color = new UnityEngine.Color32(255, 255, 255, 255);
            }
            else if (FlowerPrefab.GetComponent<DragAndDrop>().fcolor == "Amarillo")
            {
                FlowerPrefab.GetComponent<SpriteRenderer>().color = new UnityEngine.Color32(255, 255, 0, 255);
            }
            else if (FlowerPrefab.GetComponent<DragAndDrop>().fcolor == "Azul")
            {
                FlowerPrefab.GetComponent<SpriteRenderer>().color = new UnityEngine.Color32(0, 0, 255, 255);
            }
            else if (FlowerPrefab.GetComponent<DragAndDrop>().fcolor == "Rojo")
            {
                FlowerPrefab.GetComponent<SpriteRenderer>().color = new UnityEngine.Color32(255, 0, 0, 255);
            }

            FlowerNamePrefab.GetComponent<TMP_Text>().text = FlowerPrefab.GetComponent<DragAndDrop>().fname;            
            Instantiate(FlowerNamePrefab, new Vector3(10.3F, yPos - 0.7f, 0), FlowerNamePrefab.transform.localRotation);
            Instantiate(FlowerPrefab, new Vector3(10.3F, yPos, 100), FlowerPrefab.transform.localRotation);            
            _flowers.Add(FlowerPrefab.name);
        }
    }

}