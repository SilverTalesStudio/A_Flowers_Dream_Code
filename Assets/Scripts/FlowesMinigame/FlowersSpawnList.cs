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

            /*
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
            */
            spriteName = (i + 1).ToString();
            FlowerPrefab.GetComponent<Image>().sprite = Resources.Load<Sprite>("Flowers/" + spriteName);
            FlowerPrefab.GetComponent<Image>().preserveAspect = true;
            Instantiate(FlowerPrefab, new Vector3(xPos, yPos, zPos), FlowerPrefab.transform.localRotation);
            _flowers.Add(FlowerPrefab.name);



            if (Application.isMobilePlatform)
            {
                yPos -= 4.8F;
            }
            else
            {
                yPos -= 4.4F;
            }

        }
    }
}