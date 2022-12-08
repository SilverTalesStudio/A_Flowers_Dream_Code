using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Orders_Manager : MonoBehaviour
{
    #region variables

    //Variable del personaje que hace el pedido
    private string character;

    //Variable del pedido
    private int order;

    //Variable del texto
    private string text_order;
    private string text_orderSummary;

    public TMP_Text Order;
    public TMP_Text Summary;

    public string clienteDelPedido;
    public string colorDelPedido;
    public string sentimientoDelPedido;
    public string noColorDelPedido1;
    public string noColorDelPedido2;
    public string noSentimientoDelPedido1;
    public string noSentimientoDelPedido2;

    //Im�genes de los personajes
    [Header("EthanImage")]
    public GameObject EthanImage;

    [Header("AllanImage")]
    public GameObject AllanImage;

    [Header("SophieImage")]
    public GameObject SophieImage;

    [Header("PietroImage")]
    public GameObject PietroImage;

    [Header("SagrarioImage")]
    public GameObject SagrarioImage;

    #endregion

    #region Awake
    private void Awake()
    {
        //Longitud m�xima de los pedidos 288 caracteres con espacios incluidos

        string cliente = PlayerPrefs.GetString("clienteActual");

        character = cliente;
        ActivateCharacterImage(character);

        order = Random.Range(1, 11);


        if (character == "Sophie")
        {
            SophieOrder(order);
        }
        else if(character == "Ethan")
        {
            EthanOrder(order);
        }
        else if(character == "Allan")
        {
            AllanOrder(order);
        }
        else if(character == "Pietro")
        {
            PietroOrder(order);
        }
        else if(character == "Sagrario")
        {
            SagrarioOrder(order);
        }
        else
        {
            Debug.Log("Error al pasar el personaje en el pedido");
        }
        
    }
    #endregion

    #region Funciones
    private void SophieOrder(int order)
    {
        switch (order)
        {
            case 1:
                text_order = "Mi hermana me ha pedido un ramo. Ponle varios tipos de flores para que sea alegre y colorido. Y no te olvides de incluir alguna flor morada, son sus favoritas.";
                text_orderSummary = "- Ponle varios tipos de flores para que sea alegre y colorido.                                    - Y no te olvides de incluir alguna flor morada.";
                clienteDelPedido = "Sophie";
                colorDelPedido = "Morado";
                sentimientoDelPedido = "Felicidad, alegr�a, confianza";
                noColorDelPedido1 = "Azul";
                noSentimientoDelPedido1 = "Agradecimiento y gratitud";

                break;

            case 2:
                text_order = "Mi hermana quiere un ramo que le d� buena suerte a la hora de hacer amigos (aunque no creo que seas capaz de hacerlo, pero bueno). Tambi�n le gustar�a que tuviera alguna flor blanca.";
                text_orderSummary = "- Mi hermana quiere un ramo que le d� buena suerte a la hora de hacer amigos.                                    - Tambi�n le gustar�a que tuviera alguna flor blanca.";
                clienteDelPedido = "Sophie";
                colorDelPedido = "Blanco";
                sentimientoDelPedido = "Amistad";
                noColorDelPedido1 = "Rojo";
                noSentimientoDelPedido1 = "Amor eterno, amor verdadero";

                break;

            case 3:
                text_order = "Necesito un ramo para mi hermana. Quiere regal�rselo a una amiga suya as� que espero que no la decepciones. Me ha dicho que el color preferido de su amiga es el amarillo. �Te ha quedado claro?";
                text_orderSummary = "- Quiere regal�rselo a una amiga suya as� que espero que no la decepciones.                                    - Me ha dicho que el color preferido de su amiga es el amarillo.";
                clienteDelPedido = "Sophie";
                colorDelPedido = "Amarillo";
                sentimientoDelPedido = "Amistad";
                noColorDelPedido1 = "Rosa";
                noSentimientoDelPedido1 = "Amor eterno, amor verdadero";

                break;

            case 4:
                text_order = "Quiero un ramo con alguna flor rosa. Mi hermana quiere d�rselo a una amiga suya para pedirle perd�n por no haber sido sincera con ella. No tardes mucho, que tengo prisa.";
                text_orderSummary = "- Quiero un ramo con alguna flor rosa.                                    - Mi hermana quiere d�rselo a una amiga suya para pedirle perd�n por no haber sido sincera con ella.";
                clienteDelPedido = "Sophie";
                colorDelPedido = "Rosa";
                sentimientoDelPedido = "Sinceridad";
                noColorDelPedido1 = "Amarillo";
                noSentimientoDelPedido1 = "Decepci�n, desconfianza";

                break;

            case 5:
                text_order = "Mi hermana me ha pedido un ramo. Quiere que transmita felicidad porque se lo quiere regalar a una amiga por su cumplea�os (aunque no s� por qu� te tengo que dar explicaciones). Tambi�n quiere que tenga alguna flor roja. ";
                text_orderSummary = "- Quiere que transmita felicidad.                                    - Tambi�n quiere que tenga alguna flor roja.";
                clienteDelPedido = "Sophie";
                colorDelPedido = "Rojo";
                sentimientoDelPedido = "Felicidad, alegr�a, confianza";
                noColorDelPedido1 = "Blanco";
                noSentimientoDelPedido1 = "Agradecimiento y gratitud";

                break;

            case 6:
                text_order = "Quiero un ramo que sea alegre y colorido para mi hermana. Adem�s, quiero que tenga alguna flor morada (aunque no creo que tengas ninguna flor as�, pero bueno).";
                text_orderSummary = "- Quiero un ramo que sea alegre y colorido.                                    - Adem�s, quiero que tenga alguna flor morada.";
                clienteDelPedido = "Sophie";
                colorDelPedido = "Morado";
                sentimientoDelPedido = "Felicidad, alegr�a, confianza";
                noColorDelPedido1 = "Azul";
                noSentimientoDelPedido1 = "Agradecimiento y gratitud";

                break;

            case 7:
                text_order = "Necesito un ramo para agradecerle a mi hermana una cosa. �Que por qu�? Yo no tengo que darte explicaciones. Simplemente ponme el ramo. Ah, y no te olvides de incluir alguna flor azul.";
                text_orderSummary = "- Necesito un ramo para agradecerle a mi hermana una cosa.                                    - Ah, y no te olvides de incluir alguna flor azul.";
                clienteDelPedido = "Sophie";
                colorDelPedido = "Azul";
                sentimientoDelPedido = "Agradecimiento y gratitud";
                noColorDelPedido1 = "Morado";
                noSentimientoDelPedido1 = "Felicidad, alegr�a, confianza";

                break;

            case 8:
                text_order = "Mi hermana quiere un ramo para alegrar a una amiga. No te olvides de poner flores blancas para que destaque (aunque no puedo esperar mucho de ti).";
                text_orderSummary = "- Mi hermana quiere un ramo para alegrar a una amiga.                                    - No te olvides de poner flores blancas para que destaque.";
                clienteDelPedido = "Sophie";
                colorDelPedido = "Blanco";
                sentimientoDelPedido = "Felicidad, alegr�a, confianza";
                noColorDelPedido1 = "Rojo";
                noSentimientoDelPedido1 = "Agradecimiento y gratitud";

                break;

            case 9:
                text_order = "Quiero un ramo con alguna flor morada. Y date prisa, que tengo que llev�rselo a mi hermana para que pueda d�rselo a su nueva amiga.";
                text_orderSummary = "- Quiero un ramo con alguna flor morada.                                    - Tengo que llev�rselo a mi hermana para que pueda d�rselo a su nueva amiga.";
                clienteDelPedido = "Sophie";
                colorDelPedido = "Morado";
                sentimientoDelPedido = "Amistad";
                noColorDelPedido1 = "Azul";
                noSentimientoDelPedido1 = "Amor eterno, amor verdadero";

                break;

            case 10:
                text_order = "Mi hermana quiere un ramo que sea alegre y bonito. Me ha pedido que incluyas muchas flores rojas. Espero que no la decepciones.";
                text_orderSummary = "- Mi hermana quiere un ramo que sea alegre y bonito.                                    - Me ha pedido que incluyas muchas flores rojas.";
                clienteDelPedido = "Sophie";
                colorDelPedido = "Rojo";
                sentimientoDelPedido = "Felicidad, alegr�a, confianza";
                noColorDelPedido1 = "Blanco";
                noSentimientoDelPedido1 = "Agradecimiento y gratitud";

                break;
        }

        Order.text = text_order;
        Summary.text = text_orderSummary;
    }


    private void EthanOrder(int order)
    {
        switch (order)
        {
            case 1:
                text_order = "Quiero un ramo con el que poder conquistar a una persona. Es la primera cita y quiero impresionarla. Creo que su color favorito era el rojo. No, era el morado. �O era el amarillo? Bueno da igual, pon alguna flor roja.";
                text_orderSummary = "-Es la primera cita y quiero impresionarla.                       - Bueno da igual, pon alguna flor roja.";
                clienteDelPedido = "Ethan";
                colorDelPedido = "Rojo";
                sentimientoDelPedido = "Seducci�n, amor secreto";
                noColorDelPedido1 = "Blanco";
                noSentimientoDelPedido1 = "Pureza del coraz�n";

                break;

            case 2:
                text_order = "Tengo una cita y necesito un ramo. Si no recuerdo mal, uno de los colores que m�s le gustan es el morado. �Tienes alguna flor morada? Tambi�n me gustar�a que el ramo fuera espectacular para poder impresionarla.";
                text_orderSummary = "- �Tienes alguna flor morada?                               - Me gustar�a que el ramo fuera espectacular para poder impresionarla.";
                clienteDelPedido = "Ethan";
                colorDelPedido = "Morado";
                sentimientoDelPedido = "Seducci�n, amor secreto";
                noColorDelPedido1 = "Azul";
                noSentimientoDelPedido1 = "Pureza del coraz�n";
                break;

            case 3:
                text_order = "Hay una chica que no para de perseguirme, pero a m� no me gusta. �Se te ocurre algo para decirle que solo quiero ser su amigo? Si puede ser, me gustar�a que el ramo tambi�n incluyera alguna flor de color rosa, �me har�as ese favor?";
                text_orderSummary = "- �Se te ocurre algo para decirle que solo quiero ser su amigo?                            - Si puede ser, me gustar�a que el ramo tambi�n incluyera alguna flor de color rosa.";
                clienteDelPedido = "Ethan";
                colorDelPedido = "Rosa";
                sentimientoDelPedido = "Amistad";
                noColorDelPedido1 = "Amarillo";
                noSentimientoDelPedido1 = "Amor eterno, amor verdadero";


                break;

            case 4:
                text_order = "Hoy tengo una cita, pero en verdad me gustar�a cortar con la chica. �Conoces alguna flor que me sirva? Adem�s, creo recordar que el color que menos le gusta es el azul. �Seguro que si le llevo un ramo con una flor de ese color ya no querr� salir conmigo! �Puedes crear un ramo as�?";
                text_orderSummary = "- Hoy tengo una cita, pero en verdad me gustar�a cortar con la chica.                            - Adem�s, creo recordar que el color que menos le gusta es el azul.";
                clienteDelPedido = "Ethan";
                colorDelPedido = "Azul";
                sentimientoDelPedido = "Decepci�n, desconfianza";
                noColorDelPedido1 = "Morado";
                noSentimientoDelPedido1 = "Sinceridad";

                break;

            case 5:
                text_order = "Hoy tengo una cita y necesito un ramo. Tienes alguna flor que sirva para decir ��No te doli� cuando ca�ste del cielo?�. Es que me gustar�a impresionarla, pero est� cansada de escuchar mis piropos. Tambi�n querr�a que el ramo incluyera alguna flor de un color poco habitual.";
                text_orderSummary = "- Es que me gustar�a impresionarla, pero est� cansada de escuchar mis piropos.                                - Tambi�n querr�a que el ramo incluyera alguna flor de un color poco habitual.";
                clienteDelPedido = "Ethan";
                colorDelPedido = "Azul";
                sentimientoDelPedido = "Seducci�n, amor secreto";
                noColorDelPedido1 = "Morado";
                noSentimientoDelPedido1 = "Pureza del coraz�n";
                break;

            case 6:
                text_order = "Necesito un ramo urgentemente. La chica con la que estoy saliendo no cree que lo que digo sea cierto y necesito un ramo que demuestre lo contrario. �Podr�as incluir tambi�n alguna flor blanca?";
                text_orderSummary = "- La chica con la que estoy saliendo no cree que lo que digo sea cierto y necesito un ramo que demuestre lo contrario.                              - �Podr�as incluir tambi�n alguna flor blanca?";
                clienteDelPedido = "Ethan";
                colorDelPedido = "Blanco";
                sentimientoDelPedido = "Sinceridad";
                noColorDelPedido1 = "Rojo";
                noSentimientoDelPedido1 = "Decepci�n, desconfianza";
                break;

            case 7:
                text_order = "Tengo una cita y necesito un ramo. �Tienes alguna flor naranja? �No? Vaya, es una pena. �Y alguna no s�, de color amarillo? Espero que este ramo me proporcione confianza durante la cita.";
                text_orderSummary = "- �Tienes alguna flor naranja? �Y alguna no s�, de color amarillo?                                  - Espero que este ramo me proporcione confianza durante la cita.";
                clienteDelPedido = "Ethan";
                colorDelPedido = "Amarillo";
                sentimientoDelPedido = "Felicidad, alegr�a, confianza";
                noColorDelPedido1 = "Rosa";
                noSentimientoDelPedido1 = "Agradecimiento y gratitud";

                break;

            case 8:
                text_order = "Necesito un ramo para esta noche. Me gustar�a que destaque para impresionar a una chica. Si es posible, �podr�as incluir alguna flor morada? Creo que quedar�a muy bien en el ramo.";
                text_orderSummary = "- Me gustar�a que destaque para impresionar a una chica.                                    - Si es posible, �podr�as incluir alguna flor morada?";
                clienteDelPedido = "Ethan";
                colorDelPedido = "Morado";
                sentimientoDelPedido = "Seducci�n, amor secreto";
                noColorDelPedido1 = "Azul";
                noSentimientoDelPedido1 = "Pureza del coraz�n";
                break;

            case 9:
                text_order = "Vengo por un ramo. He quedado con una chica y me gustar�a agradecerle que me haya dado otra oportunidad para explicar un malentendido. �Puedes hacer que el ramo tenga alguna flor blanca? Es su color favorito.";
                text_orderSummary = "- Me gustar�a agradecerle que me haya dado otra oportunidad para explicar un malentendido.                                    - �Puedes hacer que el ramo tenga alguna flor blanca?";
                clienteDelPedido = "Ethan";
                colorDelPedido = "Blanco";
                sentimientoDelPedido = "Agradecimiento y gratitud";
                noColorDelPedido1 = "Rojo";
                noSentimientoDelPedido1 = "Felicidad, alegr�a, confianza";
                break;

            case 10:
                text_order = "Tengo una cita y necesito un ramo. Me gustar�a que tuviera alguna flor roja, pero que no quedara muy recargado. �Ah s�! Y que transmita alegr�a. No quiero que pase como la otra vez y darle un ramo equivocado.";
                text_orderSummary = "- Me gustar�a que tuviera alguna flor roja.                                    - �Ah s�!Y que transmita alegr�a.";
                clienteDelPedido = "Ethan";
                colorDelPedido = "Rojo";
                sentimientoDelPedido = "Felicidad, alegr�a, confianza";
                noColorDelPedido1 = "Blanco";
                noSentimientoDelPedido1 = "Agradecimiento y gratitud";
                break;
        }

        Order.text = text_order;
        Summary.text = text_orderSummary;
    }


    private void AllanOrder(int order)
    {
        switch (order)
        {
            case 1:
                text_order = "Necesito un ramo para ponerlo como centro de mesa. �Me podr�as ayudar? Me gustar�a que transmitiera alegr�a a toda la habitaci�n. Ah, y si puede ser que tenga alguna flor de color morada.";
                text_orderSummary = "- Me gustar�a que transmitiera alegr�a a toda la habitaci�n.                                    - Ah, y si puede ser que tenga alguna flor de color morada.";
                clienteDelPedido = "Allan";
                colorDelPedido = "Morado";
                sentimientoDelPedido = "Felicidad, alegr�a, confianza";
                noColorDelPedido1 = "Azul";
                noSentimientoDelPedido1 = "Agradecimiento y gratitud";

                break;

            case 2:
                text_order = "Me gustar�a regalarle un ramo a mi vecina. Es una se�ora mayor que me ayuda mucho siempre. Me gustar�a agradecerle todo lo que hace siempre por m�. �Podr�as incluir alguna flor blanca en el ramo? �Es su color favorito!";
                text_orderSummary = "- Me gustar�a agradecerle todo lo que hace siempre por m�.                                    - �Podr�as incluir alguna flor blanca en el ramo?";
                clienteDelPedido = "Allan";
                colorDelPedido = "Blanco";
                sentimientoDelPedido = "Agradecimiento y gratitud";
                noColorDelPedido1 = "Rojo";
                noSentimientoDelPedido1 = "Felicidad, alegr�a, confianza";

                break;

            case 3:
                text_order = "Querr�a un ramo para mi vecina. La van a operar ma�ana y me gustar�a alegrarle el d�a. �Espero que salga todo bien! �Podr�as incluir alguna flor rosa tambi�n?";
                text_orderSummary = "- La van a operar ma�ana y me gustar�a alegrarle el d�a.                                    - �Podr�as incluir alguna flor rosa tambi�n?";
                clienteDelPedido = "Allan";
                colorDelPedido = "Rosa";
                sentimientoDelPedido = "Felicidad, alegr�a, confianza";
                noColorDelPedido1 = "Amarillo";
                noSentimientoDelPedido1 = "Agradecimiento y gratitud";

                break;

            case 4:
                text_order = "�Me podr�as preparar un ramo? Tengo un nuevo compa�ero en el trabajo y me gustar�a que fu�ramos amigos. �Crees que le gustar�n las flores? �Ah, s�! Creo que me dijo que su color favorito era el amarillo. �Podr�as incluir alguna flor de ese color?";
                text_orderSummary = "- Tengo un nuevo compa�ero en el trabajo y me gustar�a que fu�ramos amigos.                                    - Creo que me dijo que su color favorito era el amarillo.";
                clienteDelPedido = "Allan";
                colorDelPedido = "Amarillo";
                sentimientoDelPedido = "Amistad";
                noColorDelPedido1 = "Morado";
                noSentimientoDelPedido1 = "Amor eterno, amor verdadero";

                break;

            case 5:
                text_order = "�Me podr�as ayudar a elegir un ramo? Me gustar�a ponerlo en la entrada de mi casa para que me trasmita felicidad cuando llegue a casa despu�s de un d�a duro. Tambi�n me gustar�a que tuviera alguna flor de color azul.";
                text_orderSummary = "- Me gustar�a ponerlo en la entrada de mi casa para que me trasmita felicidad.                                    - Tambi�n me gustar�a que tuviera alguna flor de color azul.";
                clienteDelPedido = "Allan";
                colorDelPedido = "Azul";
                sentimientoDelPedido = "Felicidad, alegr�a, confianza";
                noColorDelPedido1 = "Morado";
                noSentimientoDelPedido1 = "Agradecimiento y gratitud";

                break;

            case 6:
                text_order = "Mi vecina me ha pedido que le compre un ramo de flores para poder regal�rselo a su nieta. �Tienes alguna flor que signifique bondad o pureza? �Ah, s�! Tambi�n me ha dicho que el color preferido de su nieta es el rojo.";
                text_orderSummary = "- �Tienes alguna flor que signifique bondad o pureza?                                    - Tambi�n me ha dicho que el color preferido de su nieta es el rojo.";
                clienteDelPedido = "Allan";
                colorDelPedido = "Rojo";
                sentimientoDelPedido = "Pureza del coraz�n";
                noColorDelPedido1 = "Blanco";
                noSentimientoDelPedido1 = "Seducci�n, amor secreto";

                break;

            case 7:
                text_order = "Querr�a un ramo de flores para ponerlo como centro de mesa. Me gustar�a que fuera alegre y muy colorido, para que destaque en la estancia. �Podr�as poner alguna flor blanca tambi�n?";
                text_orderSummary = "- Me gustar�a que fuera alegre y muy colorido.                                    - �Podr�as poner alguna flor blanca tambi�n?";
                clienteDelPedido = "Allan";
                colorDelPedido = "Blanco";
                sentimientoDelPedido = "Felicidad, alegr�a, confianza";
                noColorDelPedido1 = "Rojo";
                noSentimientoDelPedido1 = "Agradecimiento y gratitud";

                break;

            case 8:
                text_order = "�Me podr�as ayudar a escoger un ramo? Me gustar�a agradecerle al gu�a del bot�nico que me explique tantas cosas de las plantas y que, aunque me ponga un poco pesado con las flores, siempre me responda con una sonrisa. �Podr�as incluir alguna flor rosa?";
                text_orderSummary = "- Me gustar�a agradecerle al gu�a del bot�nico que me explique tantas cosas de las plantas.                                    - �Podr�as incluir alguna flor rosa?";
                clienteDelPedido = "Allan";
                colorDelPedido = "Rosa";
                sentimientoDelPedido = "Agradecimiento y gratitud";
                noColorDelPedido1 = "Amarillo";
                noSentimientoDelPedido1 = "Felicidad, alegr�a, confianza";

                break;

            case 9:
                text_order = "�Me podr�as preparar un ramo para ponerlo en mi casa? Me gustar�a que me diera confianza para atreverme a hablar con mi jefe. Tambi�n querr�a que tuviera alguna flor amarilla si puede ser.";
                text_orderSummary = "- Me gustar�a que me diera confianza para atreverme a hablar con mi jefe.                                    - Tambi�n querr�a que tuviera alguna flor amarilla si puede ser.";
                clienteDelPedido = "Allan";
                colorDelPedido = "Amarillo";
                sentimientoDelPedido = "Felicidad, alegr�a, confianza";
                noColorDelPedido1 = "Rosa";
                noSentimientoDelPedido1 = "Agradecimiento y gratitud";
                break;

            case 10:
                text_order = "Quiero un ramo con alguna flor azul. Me gustar�a regal�rselo a mi vecina para agradecerle que me ense�ara a preparar un plato de cocina. �Siempre se porta muy bien conmigo!";
                text_orderSummary = "- Quiero un ramo con alguna flor azul.                                    - Me gustar�a regal�rselo a mi vecina para agradecerle que me ense�ara a preparar un plato de cocina.";
                clienteDelPedido = "Allan";
                colorDelPedido = "Azul";
                sentimientoDelPedido = "Agradecimiento y gratitud";
                noColorDelPedido1 = "Morado";
                noSentimientoDelPedido1 = "Felicidad, alegr�a, confianza";
                break;
        }

        Order.text = text_order;
        Summary.text = text_orderSummary;
    }


    private void PietroOrder(int order)
    {
        switch (order)
        {
            case 1:
                text_order = "Umm. Me gustar�a llevarme un ramo de flores para poder seguir pintando en casa. �Tienes alguna flor que pegue con la corriente impresionista? Alguna que transmita pureza, me viene bien. Ah, y que el ramo incluya algo de rosa.";
                text_orderSummary = "- Alguna que transmita pureza, me viene bien.                                    - Ah, y que el ramo incluya algo de rosa.";
                clienteDelPedido = "Pietro";
                colorDelPedido = "Rosa";
                sentimientoDelPedido = "Pureza del coraz�n";
                noColorDelPedido1 = "Amarillo";
                noSentimientoDelPedido1 = "Seducci�n, amor secreto";
                break;

            case 2:
                text_order = "Hoy quiero pintar una flor m�s abstracta. Umm� �Me puedes hacer un ramo que transmita sinceridad? Tambi�n necesitar�a que tuviera alguna flor amarilla.";
                text_orderSummary = "- �Me puedes hacer un ramo que transmita sinceridad?                                    - Tambi�n necesitar�a que tuviera alguna flor amarilla.";
                clienteDelPedido = "Pietro";
                colorDelPedido = "Amarillo";
                sentimientoDelPedido = "Sinceridad";
                noColorDelPedido1 = "Rosa";
                noSentimientoDelPedido1 = "Decepci�n, desconfianza";
                break;

            case 3:
                text_order = "Me gustar�a hacer un bodeg�n con flores al estilo postimpresionista que refleje la pureza del coraz�n. Umm. �Tienes girasoles? �No? Me conformo entonces con alguna flor azul. Me tendr� que inspirar en �La noche estrellada� en lugar de en �Los girasoles� de Van Gogh.";
                text_orderSummary = "- Me gustar�a hacer un bodeg�n con flores al estilo postimpresionista que refleje la pureza del coraz�n.                                    - Me conformo entonces con alguna flor azul.";
                clienteDelPedido = "Pietro";
                colorDelPedido = "Azul";
                sentimientoDelPedido = "Pureza del coraz�n";
                noColorDelPedido1 = "Morado";
                noSentimientoDelPedido1 = "Seducci�n, amor secreto";
                break;

            case 4:
                text_order = "Quiero un ramo para poder seguir pintando en casa. Umm. �Tienes alguna flor que inspire desconfianza? �Y alguna azul? Podr�a quedar bien pintar el ramo con un estilo expresionista, como en el cuadro �El grito�.";
                text_orderSummary = "- �Tienes alguna flor que inspire desconfianza?                                    - �Y alguna azul?";
                clienteDelPedido = "Pietro";
                colorDelPedido = "Azul";
                sentimientoDelPedido = "Decepci�n, desconfianza";
                noColorDelPedido1 = "Morado";
                noSentimientoDelPedido1 = "Sinceridad";
                break;

            case 5:
                text_order = "Hoy me apetece pintar un ramo que transmita agradecimiento. Ah, y que tenga alguna flor morada. Es muy importante. Si no es as� no podr� pintarlo con un estilo realista de manera adecuada, y eso ser�a un problema.";
                text_orderSummary = "- Hoy me apetece pintar un ramo que transmita agradecimiento.                                    - Ah, y que tenga alguna flor morada.";
                clienteDelPedido = "Pietro";
                colorDelPedido = "Morado";
                sentimientoDelPedido = "Agradecimiento y gratitud";
                noColorDelPedido1 = "Azul";
                noSentimientoDelPedido1 = "Felicidad, alegr�a, confianza";
                break;

            case 6:
                text_order = "Hoy me llevo un ramo para poder seguir pintando en casa. �Tienes alguna flor negra? �No? Vaya� Pues ponme alguna flor blanca en su lugar. Ah, s�. Y que el ramo transmita felicidad. Me gustar�a hacer un cuadro de �leo sobre lienzo en blanco y negro.";
                text_orderSummary = "- Pues ponme alguna flor blanca en su lugar.                                    - Ah, s�.Y que el ramo transmita felicidad.";
                clienteDelPedido = "Pietro";
                colorDelPedido = "Blanco";
                sentimientoDelPedido = "Felicidad, alegr�a, confianza";
                noColorDelPedido1 = "Rojo";
                noSentimientoDelPedido1 = "Agradecimiento y gratitud";
                break;

            case 7:
                text_order = "Me gustar�a llevarme un ramo para seguir pintando en casa. �Puedes incluir alguna flor amarilla? Ah s�, casi se me olvida. �Tienes alguna flor de Belladona? �No? Entonces, �puedes hacer que el ramo transmita seducci�n en su lugar?";
                text_orderSummary = "- �Puedes incluir alguna flor amarilla?                                    - Entonces, �puedes hacer que el ramo transmita seducci�n en su lugar?";
                clienteDelPedido = "Pietro";
                colorDelPedido = "Amarillo";
                sentimientoDelPedido = "Seducci�n, amor secreto";
                noColorDelPedido1 = "Rosa";
                noSentimientoDelPedido1 = "Pureza del coraz�n";
                break;

            case 8:
                text_order = "Hoy me gustar�a llevarme un ramo que transmita amor eterno�. Umm. �Tienes alguna flor morada? �Podr�as incluirla en el ramo?";
                text_orderSummary = "- Hoy me gustar�a llevarme un ramo que transmita amor eterno�                                    - �Tienes alguna flor morada?";
                clienteDelPedido = "Pietro";
                colorDelPedido = "Morado";
                sentimientoDelPedido = "Amor eterno, amor verdadero";
                noColorDelPedido1 = "Azul";
                noSentimientoDelPedido1 = "Amistad";
                break;

            case 9:
                text_order = "Quiero un ramo para poder seguir pintando despu�s. �Tienes alguna flor que transmita desconfianza? Ah, s�. Tambi�n me gustar�a que incluyeras alguna flor roja.";
                text_orderSummary = "- �Tienes alguna flor que transmita desconfianza?                                    - Ah, s�.Tambi�n me gustar�a que incluyeras alguna flor roja.";
                clienteDelPedido = "Pietro";
                colorDelPedido = "Rojo";
                sentimientoDelPedido = "Decepci�n, desconfianza";
                noColorDelPedido1 = "Blanco";
                noSentimientoDelPedido1 = "Sinceridad";
                break;

            case 10:
                text_order = "Hoy quiero un ramo que transmita amistad para poder pintarlo de manera abstracta. Umm. Tambi�n me gustar�a que tuviera alguna flor de alguno de los colores del amanecer. �Ya s�! �Amarilla!";
                text_orderSummary = "- Hoy quiero un ramo que transmita amistad para poder pintarlo de manera abstracta.                                    - �Ya s�! �Amarilla!";
                clienteDelPedido = "Pietro";
                colorDelPedido = "Amarillo";
                sentimientoDelPedido = "Amistad";
                noColorDelPedido1 = "Rosa";
                noSentimientoDelPedido1 = "Amor eterno, amor verdadero";
                break;
        }

        Order.text = text_order;
        Summary.text = text_orderSummary;
    }


    private void SagrarioOrder(int order)
    {
        switch (order)
        {
            case 1:
                text_order = "Me gustar�a comprar un ramo, pero no entiendo mucho de flores. �Se puede poner alguna flor que transmita felicidad? Ah, casi se me olvida, tambi�n me gustar�a que tuviera alguna flor amarilla, si es posible.";
                text_orderSummary = "- �Se puede poner alguna flor que transmita felicidad?                                    - Ah, casi se me olvida, tambi�n me gustar�a que tuviera alguna flor amarilla, si es posible.";
                clienteDelPedido = "Sagrario";
                colorDelPedido = "Amarillo";
                sentimientoDelPedido = "Felicidad, alegr�a, confianza";
                noColorDelPedido1 = "Rosa";
                noSentimientoDelPedido1 = "Agradecimiento y gratitud";
                break;

            case 2:
                text_order = "Quisiera un ramo, por favor. �Podr�as poner alguna flor blanca? Ah, s�. Y tambi�n te agradecer�a mucho que transmitiera agradecimiento.";
                text_orderSummary = "- Podr�as poner alguna flor blanca?                                    - Ah, s�.Y tambi�n te agradecer�a mucho que transmitiera agradecimiento.";
                clienteDelPedido = "Sagrario";
                colorDelPedido = "Blanco";
                sentimientoDelPedido = "Agradecimiento y gratitud";
                noColorDelPedido1 = "Rojo";
                noSentimientoDelPedido1 = "Felicidad, alegr�a, confianza";
                break;

            case 3:
                text_order = "�Me podr�as hacer un ramo bien alegre? Ah, s�. Y a ser posible, que tenga muchas flores rojas para que llame la atenci�n.";
                text_orderSummary = "- �Me podr�as hacer un ramo bien alegre?                                    - Y a ser posible, que tenga muchas flores rojas para que llame la atenci�n.";
                clienteDelPedido = "Sagrario";
                colorDelPedido = "Rojo";
                sentimientoDelPedido = "Felicidad, alegr�a, confianza";
                noColorDelPedido1 = "Blanco";
                noSentimientoDelPedido1 = "Agradecimiento y gratitud";

                break;

            case 4:
                text_order = "Me gustar�a comprar un ramo que hiciera feliz a todo aquel que lo viera. Ah, s� (que cabeza tengo). Tambi�n quisiera que tuviera alguna flor rosa, si no es mucha molestia.";
                text_orderSummary = "- Me gustar�a comprar un ramo que hiciera feliz a todo aquel que lo viera.                                    - Tambi�n quisiera que tuviera alguna flor rosa, si no es mucha molestia.";
                clienteDelPedido = "Sagrario";
                colorDelPedido = "Rosa";
                sentimientoDelPedido = "Felicidad, alegr�a, confianza";
                noColorDelPedido1 = "Amarillo";
                noSentimientoDelPedido1 = "Agradecimiento y gratitud";
                break;

            case 5:
                text_order = "Quisiera comprar un ramo que transmitiera amistad. Adem�s, me gustar�a que tuviera flores de color morado, si es posible.";
                text_orderSummary = "- Quisiera comprar un ramo que transmitiera amistad.                                    - Adem�s, me gustar�a que tuviera flores de color morado, si es posible.";
                clienteDelPedido = "Sagrario";
                colorDelPedido = "Morado";
                sentimientoDelPedido = "Amistad";
                noColorDelPedido1 = "Azul";
                noSentimientoDelPedido1 = "Amor eterno, amor verdadero";
                break;

            case 6:
                text_order = "Quisiera un ramo bonito y vistoso, por favor. �Tienes alguna flor azul? Me gustar�a ponerla en el ramo.";
                text_orderSummary = "- Quisiera un ramo bonito y vistoso, por favor.                                    - �Tienes alguna flor azul?";
                clienteDelPedido = "Sagrario";
                colorDelPedido = "Azul";
                sentimientoDelPedido = "Felicidad, alegr�a, confianza";
                noColorDelPedido1 = "Morado";
                noSentimientoDelPedido1 = "Agradecimiento y gratitud";
                break;

            case 7:
                text_order = "Me gustar�a comprar un ramo. �Podr�as hacer que transmitiera pureza? Tambi�n quisiera a�adirle alguna flor blanca, si no es mucha molestia.";
                text_orderSummary = "- �Podr�as hacer que transmitiera pureza?                                    - Tambi�n quisiera a�adirle alguna flor blanca, si no es mucha molestia.";
                clienteDelPedido = "Sagrario";
                colorDelPedido = "Blanco";
                sentimientoDelPedido = "Pureza del coraz�n";
                noColorDelPedido1 = "Rojo";
                noSentimientoDelPedido1 = "Seducci�n, amor secreto";
                break;

            case 8:
                text_order = "Quisiera un ramo que transmita amor eterno a todo aquel que lo mire. Ah, s�. �Te queda alguna flor morada? Me gustar�a incluirla en el ramo.";
                text_orderSummary = "- Quisiera un ramo que transmita amor eterno a todo aquel que lo mire.                                    - �Te queda alguna flor morada?";
                clienteDelPedido = "Sagrario";
                colorDelPedido = "Morado";
                sentimientoDelPedido = "Amor eterno, amor verdadero";
                noColorDelPedido1 = "Azul";
                noSentimientoDelPedido1 = "Amistad";

                break;

            case 9:
                text_order = "Quisiera un ramo, por favor. �Puedes hacer que transmita agradecimiento? Ah, s�. Tambi�n me gustar�a que tuviera alguna flor rosa, si es posible.";
                text_orderSummary = "- �Puedes hacer que transmita agradecimiento?                                    - Tambi�n me gustar�a que tuviera alguna flor rosa, si es posible.";
                clienteDelPedido = "Sagrario";
                colorDelPedido = "Rosa";
                sentimientoDelPedido = "Agradecimiento y gratitud";
                noColorDelPedido1 = "Amarillo";
                noSentimientoDelPedido1 = "Felicidad, alegr�a, confianza";
                break;

            case 10:
                text_order = "Me gustar�a comprar un ramo que transmitiera felicidad. Tambi�n quisiera que incluyera alguna flor morada, si no es mucha molestia.";
                text_orderSummary = "- Me gustar�a comprar un ramo que transmitiera felicidad.                                    - Tambi�n quisiera que incluyera alguna flor morada, si no es mucha molestia.";
                clienteDelPedido = "Sagrario";
                colorDelPedido = "Morado";
                sentimientoDelPedido = "Felicidad, alegr�a, confianza";
                noColorDelPedido1 = "Azul";
                noSentimientoDelPedido1 = "Agradecimiento y gratitud";
                break;
        }

        Order.text = text_order;
        Summary.text = text_orderSummary;
    }


    public void ActivateCharacterImage(string cliente)
    {
        if(cliente == "Ethan")
        {
            EthanImage.SetActive(true);
            AllanImage.SetActive(false);
            SophieImage.SetActive(false);
            PietroImage.SetActive(false);
            SagrarioImage.SetActive(false);
        }

        else if(cliente == "Allan")
        {
            EthanImage.SetActive(false);
            AllanImage.SetActive(true);
            SophieImage.SetActive(false);
            PietroImage.SetActive(false);
            SagrarioImage.SetActive(false);
        }

        else if(cliente == "Sophie")
        {
            EthanImage.SetActive(false);
            AllanImage.SetActive(false);
            SophieImage.SetActive(true);
            PietroImage.SetActive(false);
            SagrarioImage.SetActive(false);
        }

        else if(cliente == "Pietro")
        {
            EthanImage.SetActive(false);
            AllanImage.SetActive(false);
            SophieImage.SetActive(false);
            PietroImage.SetActive(true);
            SagrarioImage.SetActive(false);
        }

        else if(cliente == "Sagrario")
        {
            EthanImage.SetActive(false);
            AllanImage.SetActive(false);
            SophieImage.SetActive(false);
            PietroImage.SetActive(false);
            SagrarioImage.SetActive(true);
        }
    }

    #endregion
    



}
