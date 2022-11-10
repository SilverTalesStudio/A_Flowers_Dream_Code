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

    //Imágenes de los personajes
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
        //Longitud máxima de los pedidos 288 caracteres con espacios incluidos

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
                sentimientoDelPedido = "Felicidad, alegría, confianza";
                noColorDelPedido1 = "Azul";
                noSentimientoDelPedido1 = "Decepción, desconfianza";

                break;

            case 2:
                text_order = "Mi hermana quiere un ramo que le dé buena suerte (aunque no creo que seas capaz de hacerlo, pero bueno). También le gustaría que tuviera alguna flor blanca.";
                text_orderSummary = "- Mi hermana quiere un ramo que le dé buena suerte.                                    - También le gustaría que tuviera alguna flor blanca.";
                clienteDelPedido = "Sophie";
                colorDelPedido = "Blanco";
                sentimientoDelPedido = "Buena suerte, buenas noticias";
                noColorDelPedido1 = "Rojo";
                noSentimientoDelPedido1 = "Seducción, amor secreto";

                break;

            case 3:
                text_order = "Necesito un ramo para mi hermana. Quiere regalárselo a una amiga suya así que espero que no la decepciones. Me ha dicho que el color preferido de su amiga es el amarillo. ¿Te ha quedado claro?";
                text_orderSummary = "- Quiere regalárselo a una amiga suya así que espero que no la decepciones.                                    - Me ha dicho que el color preferido de su amiga es el amarillo.";
                clienteDelPedido = "Sophie";
                colorDelPedido = "Amarillo";
                sentimientoDelPedido = "Amistad";
                noColorDelPedido1 = "Malva";
                noSentimientoDelPedido1 = "Amor eterno, amor verdadero";

                break;

            case 4:
                text_order = "Quiero un ramo con alguna flor rosa. Mi hermana quiere dárselo a una amiga suya para pedirle perdón por no haber sido sincera con ella. No tardes mucho, que tengo prisa.";
                text_orderSummary = "- Quiero un ramo con alguna flor rosa.                                    - Mi hermana quiere dárselo a una amiga suya para pedirle perdón por no haber sido sincera con ella.";
                clienteDelPedido = "Sophie";
                colorDelPedido = "Rosa";
                sentimientoDelPedido = "Sinceridad";
                noColorDelPedido1 = "Rojo";
                noSentimientoDelPedido1 = "Decepción, desconfianza";

                break;

            case 5:
                text_order = "Mi hermana me ha pedido un ramo. Quiere que sea lo más bonito posible porque se lo quiere regalar a una amiga por su cumpleaños (aunque no sé por qué te tengo que dar explicaciones). También quiere que tenga alguna flor roja. ";
                text_orderSummary = "- Quiere que sea lo más bonito posible.                                    - También quiere que tenga alguna flor roja.";
                clienteDelPedido = "Sophie";
                colorDelPedido = "Rojo";
                sentimientoDelPedido = "Belleza, belleza del alma";
                noColorDelPedido1 = "Blanco";
                noColorDelPedido2 = "Rosa";
                noSentimientoDelPedido1 = "Agradecimiento y gratitud";

                break;

            case 6:
                text_order = "Quiero un ramo que sea alegre y colorido para mi hermana. Además, quiero que tenga alguna flor malva (aunque no creo que tengas ninguna flor así, pero bueno).";
                text_orderSummary = "- Quiero un ramo que sea alegre y colorido.                                    - Además, quiero que tenga alguna flor malva.";
                clienteDelPedido = "Sophie";
                colorDelPedido = "Malva";
                sentimientoDelPedido = "Felicidad, alegría, confianza";
                noColorDelPedido1 = "Amarillo";
                noSentimientoDelPedido1 = "Decepción, desconfianza";

                break;

            case 7:
                text_order = "Necesito un ramo para agradecerle a mi hermana una cosa. ¿Qué por qué? Yo no tengo que darte explicaciones. Simplemente ponme el ramo. Ah, y no te olvides de incluir alguna flor azul.";
                text_orderSummary = "- Necesito un ramo para agradecerle a mi hermana una cosa.                                    - Ah, y no te olvides de incluir alguna flor azul.";
                clienteDelPedido = "Sophie";
                colorDelPedido = "Azul";
                sentimientoDelPedido = "Agradecimiento y gratitud";
                noColorDelPedido1 = "Morado";
                noSentimientoDelPedido1 = "Belleza, belleza del alma";

                break;

            case 8:
                text_order = "Mi hermana quiere un ramo para desearle buena suerte a un amigo. No te olvides de poner flores blancas para que destaque (aunque no puedo esperar mucho de ti).";
                text_orderSummary = "- Mi hermana quiere un ramo para desearle buena suerte a un amigo.                                    - No te olvides de poner flores blancas para que destaque.";
                clienteDelPedido = "Sophie";
                colorDelPedido = "Blanco";
                sentimientoDelPedido = "Buena suerte, buenas noticias";
                noColorDelPedido1 = "Rojo";
                noSentimientoDelPedido1 = "Seducción, amor secreto";

                break;

            case 9:
                text_order = "Quiero un ramo con alguna flor morada. Y date prisa, que tengo que llevárselo a mi hermana para que pueda dárselo a su nueva amiga.";
                text_orderSummary = "- Quiero un ramo con alguna flor morada.                                    - Tengo que llevárselo a mi hermana para que pueda dárselo a su nueva amiga.";
                clienteDelPedido = "Sophie";
                colorDelPedido = "Morado";
                sentimientoDelPedido = "Amistad";
                noColorDelPedido1 = "Azul";
                noSentimientoDelPedido1 = "Amor eterno, amor verdadero";

                break;

            case 10:
                text_order = "Mi hermana quiere un ramo que sea llamativo y bonito. Me ha pedido que incluyas muchas flores rojas. Espero que no la decepciones.";
                text_orderSummary = "- Mi hermana quiere un ramo que sea llamativo y bonito.                                    - Me ha pedido que incluyas muchas flores rojas.";
                clienteDelPedido = "Sophie";
                colorDelPedido = "Rojo";
                sentimientoDelPedido = "Belleza, belleza del alma";
                noColorDelPedido1 = "Blanco";
                noColorDelPedido2 = "Rosa";
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
                text_order = "Quiero un ramo con el que poder conquistar a una chica. Es la primera cita y quiero impresionarla. Creo que su color favorito era el rojo. No, era el morado. ¿O era el amarillo? Bueno da igual, pon alguna flor roja.";
                text_orderSummary = "-Es la primera cita y quiero impresionarla.                       - Bueno da igual, pon alguna flor roja.";
                clienteDelPedido = "Ethan";
                colorDelPedido = "Rojo";
                sentimientoDelPedido = "Seducción, amor secreto";
                noColorDelPedido1 = "Blanco";
                noColorDelPedido2 = "Rosa";
                noSentimientoDelPedido1 = "Buena suerte, buenas noticias";
                noSentimientoDelPedido2 = "Pureza del corazón";

                break;

            case 2:
                text_order = "Tengo una cita y necesito un ramo. Si no recuerdo mal, uno de los colores que más le gustan es el morado. ¿Tienes alguna flor morada? También me gustaría que el ramo fuera espectacular para poder impresionarla.";
                text_orderSummary = "- ¿Tienes alguna flor morada?                               - Me gustaría que el ramo fuera espectacular para poder impresionarla.";
                clienteDelPedido = "Ethan";
                colorDelPedido = "Morado";
                sentimientoDelPedido = "Seducción, amor secreto";
                noColorDelPedido1 = "Azul";
                noSentimientoDelPedido1 = "Buena suerte, buenas noticias";
                noSentimientoDelPedido2 = "Pureza del corazón";
                break;

            case 3:
                text_order = "Hay una chica que no para de perseguirme, pero a mí no me gusta. ¿Se te ocurre algo para decirle que solo quiero ser su amigo? Si puede ser me gustaría que el ramo también incluyera alguna flor de color rosa, ¿me harías ese favor?";
                text_orderSummary = "- ¿Se te ocurre algo para decirle que solo quiero ser su amigo?                            - Si puede ser me gustaría que el ramo también incluyera alguna flor de color rosa.";
                clienteDelPedido = "Ethan";
                colorDelPedido = "Rosa";
                sentimientoDelPedido = "Amistad";
                noColorDelPedido1 = "Rojo";
                noSentimientoDelPedido1 = "Amor eterno, amor verdadero";


                break;

            case 4:
                text_order = "Hoy tengo una cita, pero en verdad me gustaría cortar con la chica. ¿Conoces alguna flor que me sirva? Además, creo recordar que el color que menos le gusta es el azul. ¡Seguro que si le llevo un ramo con una flor de ese color ya no querrá salir conmigo! ¿Puedes crear un ramo así?";
                text_orderSummary = "- Hoy tengo una cita, pero en verdad me gustaría cortar con la chica.                            - Además, creo recordar que el color que menos le gusta es el azul.";
                clienteDelPedido = "Ethan";
                colorDelPedido = "Azul";
                sentimientoDelPedido = "Decepción, desconfianza";
                noColorDelPedido1 = "Morado";
                noSentimientoDelPedido1 = "Felicidad, alegría, confianza";
                noSentimientoDelPedido2 = "Sinceridad";

                break;

            case 5:
                text_order = "Hoy tengo una cita y necesito un ramo. Tienes alguna flor que sirva para decir “¿No te dolió cuando caíste del cielo?”. Es que me gustaría sorprenderla, pero está cansada de escuchar mis piropos. También querría que el ramo incluyera alguna flor de un color poco habitual.";
                text_orderSummary = "- Tienes alguna flor que sirva para decir “¿No te dolió cuando caíste del cielo?”                                  - También querría que el ramo incluyera alguna flor de un color poco habitual.";
                clienteDelPedido = "Ethan";
                colorDelPedido = "Azul";
                sentimientoDelPedido = "Belleza, belleza del alma";
                noColorDelPedido1 = "Morado";
                noSentimientoDelPedido1 = "Agradecimiento y gratitud";
                break;

            case 6:
                text_order = "Necesito un ramo urgentemente. La chica con la que estoy saliendo no cree que lo que digo sea cierto y necesito un ramo que demuestre lo contrario. ¿Podrías incluir también alguna flor blanca?";
                text_orderSummary = "- La chica con la que estoy saliendo no cree que lo que digo sea cierto y necesito un ramo que demuestre lo contrario.                              - ¿Podrías incluir también alguna flor blanca?";
                clienteDelPedido = "Ethan";
                colorDelPedido = "Blanco";
                sentimientoDelPedido = "Sinceridad";
                noColorDelPedido1 = "Rojo";
                noSentimientoDelPedido1 = "Decepción, desconfianza";
                break;

            case 7:
                text_order = "Tengo una cita y necesito un ramo. ¿Tienes alguna flor naranja? ¿No? Vaya, es una pena. ¿Y alguna no sé, de color amarillo? Espero que este ramo me dé buena suerte durante la cita.";
                text_orderSummary = "- ¿Tienes alguna flor naranja? ¿Y alguna no sé, de color amarillo?                                  - Espero que este ramo me dé buena suerte durante la cita.";
                clienteDelPedido = "Ethan";
                colorDelPedido = "Amarillo";
                sentimientoDelPedido = "Buena suerte, buenas noticias";
                noColorDelPedido1 = "Malva";
                noSentimientoDelPedido1 = "Seducción, amor secreto";

                break;

            case 8:
                text_order = "Necesito un ramo para esta noche. Me gustaría que destaque para impresionar a una chica. Si es posible, ¿podrías incluir alguna flor malva? Creo que quedaría muy bien en el ramo.";
                text_orderSummary = "- Me gustaría que destaque para impresionar a una chica.                                    - Si es posible, ¿podrías incluir alguna flor malva?";
                clienteDelPedido = "Ethan";
                colorDelPedido = "Malva";
                sentimientoDelPedido = "Seducción, amor secreto";
                noColorDelPedido1 = "Amarillo";
                noSentimientoDelPedido1 = "Buena suerte, buenas noticias";
                noSentimientoDelPedido2 = "Pureza del corazón";
                break;

            case 9:
                text_order = "Vengo por un ramo. He quedado con una chica y me gustaría agradecerle que me haya dado otra oportunidad para explicar un malentendido. ¿Puedes hacer que el ramo tenga alguna flor blanca? Es su color favorito.";
                text_orderSummary = "- Me gustaría agradecerle que me haya dado otra oportunidad para explicar un malentendido.                                    - ¿Puedes hacer que el ramo tenga alguna flor blanca ?";
                clienteDelPedido = "Ethan";
                colorDelPedido = "Blanco";
                sentimientoDelPedido = "Agradecimiento y gratitud";
                noColorDelPedido1 = "Rojo";
                noSentimientoDelPedido1 = "Belleza, belleza del alma";
                break;

            case 10:
                text_order = "Tengo una cita y necesito un ramo. Me gustaría que tuviera alguna flor roja, pero que no quedara muy recargado. ¡Ah sí! Y que transmita belleza. No quiero equivocarme como la otra vez y darle un ramo equivocado.";
                text_orderSummary = "- Me gustaría que tuviera alguna flor roja.                                    - ¡Ah sí!Y que transmita belleza.";
                clienteDelPedido = "Ethan";
                colorDelPedido = "Rojo";
                sentimientoDelPedido = "Belleza, belleza del alma";
                noColorDelPedido1 = "Blanco";
                noColorDelPedido2 = "Rosa";
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
                text_order = "Necesito un ramo para ponerlo como centro de mesa. ¿Me podrías ayudar? Me gustaría que transmitiera alegría a toda la habitación. Ah, y si puede ser que tenga alguna flor de color morada.";
                text_orderSummary = "- Me gustaría que transmitiera alegría a toda la habitación.                                    - Ah, y si puede ser que tenga alguna flor de color morada.";
                clienteDelPedido = "Allan";
                colorDelPedido = "Morado";
                sentimientoDelPedido = "Felicidad, alegría, confianza";
                noColorDelPedido1 = "Azul";
                noSentimientoDelPedido1 = "Decepción, desconfianza";

                break;

            case 2:
                text_order = "Me gustaría regalarle un ramo a mi vecina. Es una señora mayor que me ayuda mucho siempre. Me gustaría agradecerle todo lo que hace siempre por mí. ¿Podrías incluir alguna flor blanca en el ramo? ¡Es su color favorito!";
                text_orderSummary = "- Me gustaría agradecerle todo lo que hace siempre por mí.                                    - ¿Podrías incluir alguna flor blanca en el ramo?";
                clienteDelPedido = "Allan";
                colorDelPedido = "Blanco";
                sentimientoDelPedido = "Agradecimiento y gratitud";
                noColorDelPedido1 = "Rojo";
                noSentimientoDelPedido1 = "Belleza, belleza del alma";

                break;

            case 3:
                text_order = "Querría un ramo para mi vecina. La van a operar mañana y me gustaría desearle buena suerte. ¡Espero que salga todo bien! ¿Podrías incluir alguna flor rosa también?";
                text_orderSummary = "- La van a operar mañana y me gustaría desearle buena suerte.                                    - ¿Podrías incluir alguna flor rosa también?";
                clienteDelPedido = "Allan";
                colorDelPedido = "Rosa";
                sentimientoDelPedido = "Buena suerte, buenas noticias";
                noColorDelPedido1 = "Rojo";
                noSentimientoDelPedido1 = "Seducción, amor secreto";

                break;

            case 4:
                text_order = "¿Me podrías preparar un ramo? Tengo un nuevo compañero en el trabajo y me gustaría que fuéramos amigos. ¿Crees que le gustarán las flores? ¡Ah, sí! Creo que me dijo que su color favorito era el amarillo. ¿Podrías incluir alguna flor de ese color?";
                text_orderSummary = "- Tengo un nuevo compañero en el trabajo y me gustaría que fuéramos amigos.                                    - Creo que me dijo que su color favorito era el amarillo.";
                clienteDelPedido = "Allan";
                colorDelPedido = "Amarillo";
                sentimientoDelPedido = "Amistad";
                noColorDelPedido1 = "Malva";
                noSentimientoDelPedido1 = "Amor eterno, amor verdadero";

                break;

            case 5:
                text_order = "¿Me podrías ayudar a elegir un ramo? Me gustaría ponerlo en la entrada de mi casa para que me trasmita felicidad cuando llegue a casa después de un día duro. También me gustaría que tuviera alguna flor de color azul.";
                text_orderSummary = "- Me gustaría ponerlo en la entrada de mi casa para que me trasmita felicidad.                                    - También me gustaría que tuviera alguna flor de color azul.";
                clienteDelPedido = "Allan";
                colorDelPedido = "Azul";
                sentimientoDelPedido = "Felicidad, alegría, confianza";
                noColorDelPedido1 = "Morado";
                noSentimientoDelPedido1 = "Decepción, desconfianza";

                break;

            case 6:
                text_order = "Mi vecina me ha pedido que le compre un ramo de flores para poder regalárselo a su nieta. ¿Tienes alguna flor que signifique bondad o pureza? ¡Ah, sí! También me ha dicho que el color preferido de su nieta es el rojo.";
                text_orderSummary = "- ¿Tienes alguna flor que signifique bondad o pureza?                                    - También me ha dicho que el color preferido de su nieta es el rojo.";
                clienteDelPedido = "Allan";
                colorDelPedido = "Rojo";
                sentimientoDelPedido = "Pureza del corazón";
                noColorDelPedido1 = "Rosa";
                noColorDelPedido2 = "Blanco";
                noSentimientoDelPedido1 = "Seducción, amor secreto";

                break;

            case 7:
                text_order = "Querría un ramo de flores para ponerlo como centro de mesa. Me gustaría que fuera alegre y muy colorido, para que destaque en la estancia. ¿Podrías poner alguna flor blanca también?";
                text_orderSummary = "- Me gustaría que fuera alegre y muy colorido.                                    - ¿Podrías poner alguna flor blanca también?";
                clienteDelPedido = "Allan";
                colorDelPedido = "Blanco";
                sentimientoDelPedido = "Felicidad, alegría, confianza";
                noColorDelPedido1 = "Rojo";
                noSentimientoDelPedido1 = "Decepción, desconfianza";

                break;

            case 8:
                text_order = "¿Me podrías ayudar a escoger un ramo? Me gustaría agradecerle al guía del botánico que me explique tantas cosas de las plantas y que, aunque me ponga un poco pesado con las flores, siempre me responda con una sonrisa. ¿Podrías incluir alguna flor rosa?";
                text_orderSummary = "- Me gustaría agradecerle al guía del botánico que me explique tantas cosas de las plantas.                                    - ¿Podrías incluir alguna flor rosa?";
                clienteDelPedido = "Allan";
                colorDelPedido = "Rosa";
                sentimientoDelPedido = "Agradecimiento y gratitud";
                noColorDelPedido1 = "Rojo";
                noSentimientoDelPedido1 = "Belleza, belleza del alma";

                break;

            case 9:
                text_order = "¿Me podrías preparar un ramo para ponerlo en mi casa? Me gustaría que me diera buena suerte en mi trabajo para que el jefe no me regañe tanto. También querría que tuviera alguna flor amarilla si puede ser.";
                text_orderSummary = "- Me gustaría que me diera buena suerte en mi trabajo para que el jefe no me regañe tanto.                                    - También querría que tuviera alguna flor amarilla si puede ser.";
                clienteDelPedido = "Allan";
                colorDelPedido = "Amarillo";
                sentimientoDelPedido = "Buena suerte, buenas noticias";
                noColorDelPedido1 = "Malva";
                noSentimientoDelPedido1 = "Seducción, amor secreto";
                break;

            case 10:
                text_order = "Quiero un ramo con alguna flor azul. Me gustaría regalárselo a mi vecina para agradecerle que me enseñara a preparar un plato de cocina. ¡Siempre se porta muy bien conmigo!";
                text_orderSummary = "- Quiero un ramo con alguna flor azul.                                    - Me gustaría regalárselo a mi vecina para agradecerle que me enseñara a preparar un plato de cocina.";
                clienteDelPedido = "Allan";
                colorDelPedido = "Azul";
                sentimientoDelPedido = "Agradecimiento y gratitud";
                noColorDelPedido1 = "Morado";
                noSentimientoDelPedido1 = "Belleza, belleza del alma";
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
                text_order = "Umm. Me gustaría llevarme un ramo de flores para poder seguir pintando en casa. ¿Tienes alguna flor que pegue con la corriente impresionista? Alguna que transmita belleza, me viene bien. Ah, y que el ramo incluya algo de rosa.";
                text_orderSummary = "- Alguna que transmita belleza, me viene bien.                                    - Ah, y que el ramo incluya algo de rosa.";
                clienteDelPedido = "Pietro";
                colorDelPedido = "Rosa";
                sentimientoDelPedido = "Belleza, belleza del alma";
                noColorDelPedido1 = "Rojo";
                noSentimientoDelPedido1 = "Agradecimiento y gratitud";
                break;

            case 2:
                text_order = "Hoy quiero pintar una flor más abstracta. Umm… ¿Me puedes hacer un ramo que transmita sinceridad? También necesitaría que tuviera alguna flor amarilla.";
                text_orderSummary = "- ¿Me puedes hacer un ramo que transmita sinceridad?                                    - También necesitaría que tuviera alguna flor amarilla.";
                clienteDelPedido = "Pietro";
                colorDelPedido = "Amarillo";
                sentimientoDelPedido = "Sinceridad";
                noColorDelPedido1 = "Malva";
                noSentimientoDelPedido1 = "Decepción, desconfianza";
                break;

            case 3:
                text_order = "Me gustaría hacer un bodegón con flores al estilo postimpresionista que refleje la pureza del corazón. Umm. ¿Tienes girasoles? ¿No? Vaya, es una pena….. Me conformo entonces con alguna flor azul. Me tendré que inspirar en “La noche estrellada” en lugar de en “Los girasoles” de Van Gogh.";
                text_orderSummary = "- Me gustaría hacer un bodegón con flores al estilo postimpresionista que refleje la pureza del corazón.                                    - Me conformo entonces con alguna flor azul.";
                clienteDelPedido = "Pietro";
                colorDelPedido = "Azul";
                sentimientoDelPedido = "Pureza del corazón";
                noColorDelPedido1 = "Morado";
                noSentimientoDelPedido1 = "Seducción, amor secreto";
                break;

            case 4:
                text_order = "Quiero un ramo para poder seguir pintando en casa. Umm. ¿Tienes alguna flor que inspire desconfianza? ¿Y alguna azul? Podría quedar bien pintar el ramo con un estilo expresionista, como en el cuadro “El grito”.";
                text_orderSummary = "- ¿Tienes alguna flor que inspire desconfianza?                                    - ¿Y alguna azul?";
                clienteDelPedido = "Pietro";
                colorDelPedido = "Azul";
                sentimientoDelPedido = "Decepción, desconfianza";
                noColorDelPedido1 = "Morado";
                noSentimientoDelPedido1 = "Felicidad, alegría, confianza";
                noSentimientoDelPedido2 = "Sinceridad";
                break;

            case 5:
                text_order = "Hoy me apetece pintar un ramo que transmita agradecimiento. Ah, y que tenga alguna flor malva. No morada, sino malva, es muy importante. Si no es así no podré pintarlo con un estilo realista de manera adecuada, y eso sería un problema.";
                text_orderSummary = "- Hoy me apetece pintar un ramo que transmita agradecimiento.                                    - Ah, y que tenga alguna flor malva.";
                clienteDelPedido = "Pietro";
                colorDelPedido = "Malva";
                sentimientoDelPedido = "Agradecimiento y gratitud";
                noColorDelPedido1 = "Amarillo";
                noSentimientoDelPedido1 = "Belleza, belleza del alma";
                break;

            case 6:
                text_order = "Hoy me llevo un ramo para poder seguir pintando en casa. ¿Tienes alguna flor negra? ¿No? Vaya… Pues ponme alguna flor blanca en su lugar. Ah, sí. Y que el ramo transmita felicidad. Me gustaría hacer un cuadro de óleo sobre lienzo en blanco y negro.";
                text_orderSummary = "- Pues ponme alguna flor blanca en su lugar.                                    - Ah, sí.Y que el ramo transmita felicidad.";
                clienteDelPedido = "Pietro";
                colorDelPedido = "Blanco";
                sentimientoDelPedido = "Felicidad, alegría, confianza";
                noColorDelPedido1 = "Rojo";
                noSentimientoDelPedido1 = "Decepción, desconfianza";
                break;

            case 7:
                text_order = "Me gustaría llevarme un ramo para seguir pintando en casa. ¿Puedes incluir alguna flor amarilla? Ah sí, casi se me olvida. ¿Tienes alguna flor de Belladona? ¿No? Entonces, ¿puedes hacer que el ramo transmita seducción en su lugar?";
                text_orderSummary = "- ¿Puedes incluir alguna flor amarilla?                                    - Entonces, ¿puedes hacer que el ramo transmita seducción en su lugar?";
                clienteDelPedido = "Pietro";
                colorDelPedido = "Amarillo";
                sentimientoDelPedido = "Seducción, amor secreto";
                noColorDelPedido1 = "Malva";
                noSentimientoDelPedido1 = "Buena suerte, buenas noticias";
                noSentimientoDelPedido2 = "Pureza del corazón";
                break;

            case 8:
                text_order = "Hoy me gustaría llevarme un ramo que transmita amor eterno…. Umm. ¿Tienes alguna flor morada? ¿Podrías incluirla en el ramo?";
                text_orderSummary = "- Hoy me gustaría llevarme un ramo que transmita amor eterno…                                    - ¿Tienes alguna flor morada?";
                clienteDelPedido = "Pietro";
                colorDelPedido = "Morado";
                sentimientoDelPedido = "Amor eterno, amor verdadero";
                noColorDelPedido1 = "Azul";
                noSentimientoDelPedido1 = "Amistad";
                break;

            case 9:
                text_order = "Quiero un ramo para poder seguir pintando después. ¿Tienes alguna flor que transmita desconfianza? Ah, sí. También me gustaría que incluyeras alguna flor roja.";
                text_orderSummary = "- ¿Tienes alguna flor que transmita desconfianza?                                    - Ah, sí.También me gustaría que incluyeras alguna flor roja.";
                clienteDelPedido = "Pietro";
                colorDelPedido = "Rojo";
                sentimientoDelPedido = "Decepción, desconfianza";
                noColorDelPedido1 = "Blanco";
                noColorDelPedido2 = "Rosa";
                noSentimientoDelPedido1 = "Felicidad, alegría, confianza";
                noSentimientoDelPedido2 = "Sinceridad";
                break;

            case 10:
                text_order = "Hoy quiero un ramo que transmita amistad para poder pintarlo de manera abstracta. Umm. También me gustaría que tuviera alguna flor de alguno de los colores del amanecer. ¡Ya sé! ¡Amarilla!";
                text_orderSummary = "- Hoy quiero un ramo que transmita amistad para poder pintarlo de manera abstracta.                                    - ¡Ya sé! ¡Amarilla!";
                clienteDelPedido = "Pietro";
                colorDelPedido = "Amarillo";
                sentimientoDelPedido = "Amistad";
                noColorDelPedido1 = "Malva";
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
                text_order = "Me gustaría comprar un ramo, pero no entiendo mucho de flores. ¿Se puede poner alguna flor que transmita felicidad? Ah, casi se me olvida, también me gustaría que tuviera alguna flor amarilla, si es posible.";
                text_orderSummary = "- ¿Se puede poner alguna flor que transmita felicidad?                                    - Ah, casi se me olvida, también me gustaría que tuviera alguna flor amarilla, si es posible.";
                clienteDelPedido = "Sagrario";
                colorDelPedido = "Amarillo";
                sentimientoDelPedido = "Felicidad, alegría, confianza";
                noColorDelPedido1 = "Malva";
                noSentimientoDelPedido1 = "Decepción, desconfianza";
                break;

            case 2:
                text_order = "Quisiera un ramo, por favor. ¿Podrías poner alguna flor blanca? Ah, sí. Y también te agradecería mucho que transmitiera agradecimiento.";
                text_orderSummary = "- Podrías poner alguna flor blanca?                                    - Ah, sí.Y también te agradecería mucho que transmitiera agradecimiento.";
                clienteDelPedido = "Sagrario";
                colorDelPedido = "Blanco";
                sentimientoDelPedido = "Agradecimiento y gratitud";
                noColorDelPedido1 = "Rojo";
                noSentimientoDelPedido1 = "Belleza, belleza del alma";
                break;

            case 3:
                text_order = "¿Me podrías hacer un ramo bien bonito, niña? Ah, sí. Y a ser posible, que tenga muchas flores rojas para que llame la atención.";
                text_orderSummary = "- ¿Me podrías hacer un ramo bien bonito, niña?                                    - Y a ser posible, que tenga muchas flores rojas para que llame la atención.";
                clienteDelPedido = "Sagrario";
                colorDelPedido = "Rojo";
                sentimientoDelPedido = "Belleza, belleza del alma";
                noColorDelPedido1 = "Blanco";
                noColorDelPedido2 = "Rosa";
                noSentimientoDelPedido1 = "Agradecimiento y gratitud";

                break;

            case 4:
                text_order = "Me gustaría comprar un ramo que hiciera feliz a todo aquel que lo viera. Ah, sí (que cabeza tengo). También quisiera que tuviera alguna flor rosa si no es mucha molestia.";
                text_orderSummary = "- Me gustaría comprar un ramo que hiciera feliz a todo aquel que lo viera.                                    - También quisiera que tuviera alguna flor rosa si no es mucha molestia.";
                clienteDelPedido = "Sagrario";
                colorDelPedido = "Rosa";
                sentimientoDelPedido = "Felicidad, alegría, confianza";
                noColorDelPedido1 = "Rojo";
                noSentimientoDelPedido1 = "Decepción, desconfianza";
                break;

            case 5:
                text_order = "Quisiera comprar un ramo que transmitiera amistad. Además, me gustaría que tuviera flores de color malva, si es posible.";
                text_orderSummary = "- Quisiera comprar un ramo que transmitiera amistad.                                    - Además, me gustaría que tuviera flores de color malva, si es posible.";
                clienteDelPedido = "Sagrario";
                colorDelPedido = "Malva";
                sentimientoDelPedido = "Amistad";
                noColorDelPedido1 = "Amarillo";
                noSentimientoDelPedido1 = "Amor eterno, amor verdadero";
                break;

            case 6:
                text_order = "Quisiera un ramo bonito y vistoso, por favor. ¿Tienes alguna flor azul, niña? Me gustaría ponerla en el ramo.";
                text_orderSummary = "- Quisiera un ramo bonito y vistoso, por favor.                                    - ¿Tienes alguna flor azul, niña?";
                clienteDelPedido = "Sagrario";
                colorDelPedido = "Azul";
                sentimientoDelPedido = "Belleza, belleza del alma";
                noColorDelPedido1 = "Morado";
                noSentimientoDelPedido1 = "Agradecimiento y gratitud";
                break;

            case 7:
                text_order = "Me gustaría comprar un ramo. ¿Podrías hacer que transmitiera buena suerte? Creo que la voy a necesitar. No te preocupes por mí, niña. Son cosas mías. También quisiera añadirle alguna flor roja, si no es mucha molestia.";
                text_orderSummary = "- ¿Podrías hacer que transmitiera buena suerte?                                    - También quisiera añadirle alguna flor roja, si no es mucha molestia.";
                clienteDelPedido = "Sagrario";
                colorDelPedido = "Rojo";
                sentimientoDelPedido = "Buena suerte, buenas noticias";
                noColorDelPedido1 = "Blanco";
                noColorDelPedido2 = "Rosa";
                noSentimientoDelPedido1 = "Seducción, amor secreto";
                break;

            case 8:
                text_order = "Quisiera un ramo que transmita amor eterno a todo aquel que lo mire. Ah, sí. ¿Te queda alguna flor morada, niña? Me gustaría incluirla en el ramo.";
                text_orderSummary = "- Quisiera un ramo que transmita amor eterno a todo aquel que lo mire.                                    - ¿Te queda alguna flor morada, niña?";
                clienteDelPedido = "Sagrario";
                colorDelPedido = "Morado";
                sentimientoDelPedido = "Amor eterno, amor verdadero";
                noColorDelPedido1 = "Azul";
                noSentimientoDelPedido1 = "Amistad";

                break;

            case 9:
                text_order = "Quisiera un ramo, por favor. ¿Puedes hacer que transmita agradecimiento? Ah, sí. También me gustaría que tuviera alguna flor rosa, si es posible.";
                text_orderSummary = "- ¿Puedes hacer que transmita agradecimiento?                                    - También me gustaría que tuviera alguna flor rosa, si es posible.";
                clienteDelPedido = "Sagrario";
                colorDelPedido = "Rosa";
                sentimientoDelPedido = "Agradecimiento y gratitud";
                noColorDelPedido1 = "Rojo";
                noSentimientoDelPedido1 = "Belleza, belleza del alma";
                break;

            case 10:
                text_order = "Me gustaría comprar un ramo que transmitiera felicidad. También quisiera que incluyera alguna flor morada, si no es mucha molestia.";
                text_orderSummary = "- Me gustaría comprar un ramo que transmitiera felicidad.                                    - También quisiera que incluyera alguna flor morada, si no es mucha molestia.";
                clienteDelPedido = "Sagrario";
                colorDelPedido = "Morado";
                sentimientoDelPedido = "Felicidad, alegría, confianza";
                noColorDelPedido1 = "Azul";
                noSentimientoDelPedido1 = "Decepción, desconfianza";
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
