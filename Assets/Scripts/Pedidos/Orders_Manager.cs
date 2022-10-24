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
    
    #endregion

    #region Awake
    private void Awake()
    {
        //Longitud máxima de los pedidos 288 caracteres con espacios incluidos

        string cliente = PlayerPrefs.GetString("clienteActual");
        character = cliente;

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
                text_orderSummary = "ResumenSophie1";
                clienteDelPedido = "Sophie";
                colorDelPedido = "Morado";
                sentimientoDelPedido = "Felicidad";

                break;

            case 2:
                text_order = "Mi hermana quiere un ramo que le dé buena suerte (aunque no creo que seas capaz de hacerlo, pero bueno). También le gustaría que tuviera alguna flor blanca.";
                text_orderSummary = "ResumenSophie2";
                clienteDelPedido = "Sophie";
                colorDelPedido = "Blanca";
                sentimientoDelPedido = "Buena suerte";

                break;

            case 3:
                text_order = "Necesito un ramo para mi hermana. Quiere regalárselo a una amiga suya así que espero que no la decepciones. Me ha dicho que el color preferido de su amiga es el amarillo. ¿Te ha quedado claro?";
                text_orderSummary = "ResumenSophie3";
                clienteDelPedido = "Sophie";
                colorDelPedido = "Amarillo";
                sentimientoDelPedido = "Amistad";

                break;

            case 4:
                text_order = "Quiero un ramo con alguna flor rosa. Mi hermana quiere dárselo a una amiga suya para pedirle perdón por no haber sido sincera con ella. No tardes mucho, que tengo prisa.";
                text_orderSummary = "ResumenSophie4";
                clienteDelPedido = "Sophie";
                colorDelPedido = "Rosa";
                sentimientoDelPedido = "Sinceridad";

                break;

            case 5:
                text_order = "Mi hermana me ha pedido un ramo. Quiere que sea lo más bonito posible porque se lo quiere regalar a una amiga por su cumpleaños (aunque no sé por qué te tengo que dar explicaciones). También quiere que tenga alguna flor roja. ";
                text_orderSummary = "ResumenSophie5";
                clienteDelPedido = "Sophie";
                colorDelPedido = "Rojo";
                sentimientoDelPedido = "Belleza";

                break;

            case 6:
                text_order = "Quiero un ramo que sea alegre y colorido para mi hermana. Además, quiero que tenga alguna flor malva (aunque no creo que tengas ninguna flor así, pero bueno).";
                text_orderSummary = "ResumenSophie6";
                clienteDelPedido = "Sophie";
                colorDelPedido = "Malva";
                sentimientoDelPedido = "Felicidad";

                break;

            case 7:
                text_order = "Necesito un ramo para agradecerle a mi hermana una cosa. ¿Qué por qué? Yo no tengo que darte explicaciones. Simplemente ponme el ramo. Ah, y no te olvides de incluir alguna flor azul.";
                text_orderSummary = "ResumenSophie7";
                clienteDelPedido = "Sophie";
                colorDelPedido = "Azul";
                sentimientoDelPedido = "Agradecimiento";

                break;

            case 8:
                text_order = "Mi hermana quiere un ramo para desearle buena suerte a un amigo. No te olvides de poner flores blancas para que destaque (aunque no puedo esperar mucho de ti).";
                text_orderSummary = "ResumenSophie8";
                clienteDelPedido = "Sophie";
                colorDelPedido = "Blanco";
                sentimientoDelPedido = "Buena suerte";

                break;

            case 9:
                text_order = "Quiero un ramo con alguna flor morada. Y date prisa, que tengo que llevárselo a mi hermana para que pueda dárselo a su nueva amiga.";
                text_orderSummary = "ResumenSophie9";
                clienteDelPedido = "Sophie";
                colorDelPedido = "Morado";
                sentimientoDelPedido = "Amistad";

                break;

            case 10:
                text_order = "Mi hermana quiere un ramo que sea llamativo y bonito. Me ha pedido que incluyas muchas flores rojas. Espero que no la decepciones.";
                text_orderSummary = "ResumenSophie10";
                clienteDelPedido = "Sophie";
                colorDelPedido = "Rojo";
                sentimientoDelPedido = "Belleza";

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
                text_orderSummary = "ResumenLigon1";
                clienteDelPedido = "Ethan";
                colorDelPedido = "Rojo";
                sentimientoDelPedido = "Seducción";

                break;

            case 2:
                text_order = "Tengo una cita y necesito un ramo. Si no recuerdo mal, uno de los colores que más le gustan es el morado. ¿Tienes alguna flor morada? También me gustaría que el ramo fuera espectacular para poder impresionarla.";
                text_orderSummary = "ResumenLigon2";
                clienteDelPedido = "Ethan";
                colorDelPedido = "Morado";
                sentimientoDelPedido = "Seducción";
         
                break;

            case 3:
                text_order = "Hay una chica que no para de perseguirme, pero a mí no me gusta. ¿Se te ocurre algo para decirle que solo quiero ser su amigo? Si puede ser me gustaría que el ramo también incluyera alguna flor de color rosa, ¿me harías ese favor?";
                text_orderSummary = "ResumenLigon3";
                clienteDelPedido = "Ethan";
                colorDelPedido = "Rosa";
                sentimientoDelPedido = "Amistad";

                break;

            case 4:
                text_order = "Hoy tengo una cita, pero en verdad me gustaría cortar con la chica. ¿Conoces alguna flor que me sirva? Además, creo recordar que el color que menos le gusta es el azul. ¡Seguro que si le llevo un ramo con una flor de ese color ya no querrá salir conmigo! ¿Puedes crear un ramo así?";
                text_orderSummary = "ResumenLigon4";
                clienteDelPedido = "Ethan";
                colorDelPedido = "Azul";
                sentimientoDelPedido = "Decepción";

                break;

            case 5:
                text_order = "Hoy tengo una cita y necesito un ramo. Tienes alguna flor que sirva para decir “¿No te dolió cuando caíste del cielo?”. Es que me gustaría sorprenderla, pero está cansada de escuchar mis piropos. También querría que el ramo incluyera alguna flor de un color poco habitual.";
                text_orderSummary = "ResumenLigon5";
                clienteDelPedido = "Ethan";
                colorDelPedido = "Azul";
                sentimientoDelPedido = "Belleza";

                break;

            case 6:
                text_order = "Necesito un ramo urgentemente. La chica con la que estoy saliendo no cree que lo que digo sea cierto y necesito un ramo que demuestre lo contrario. ¿Podrías incluir también alguna flor blanca?";
                text_orderSummary = "ResumenLigon6";
                clienteDelPedido = "Ethan";
                colorDelPedido = "Blanco";
                sentimientoDelPedido = "Sinceridad";

                break;

            case 7:
                text_order = "Tengo una cita y necesito un ramo. ¿Tienes alguna flor naranja? ¿No? Vaya, es una pena. ¿Y alguna no sé, de color amarillo? Espero que este ramo me dé buena suerte durante la cita.";
                text_orderSummary = "ResumenLigon6";
                clienteDelPedido = "Ethan";
                colorDelPedido = "Amarillo";
                sentimientoDelPedido = "Buena suerte";

                break;

            case 8:
                text_order = "Necesito un ramo para esta noche. Me gustaría que destaque para impresionar a una chica. Si es posible, ¿podrías incluir alguna flor malva? Creo que quedaría muy bien en el ramo.";
                text_orderSummary = "ResumenLigon8";
                clienteDelPedido = "Ethan";
                colorDelPedido = "Malva";
                sentimientoDelPedido = "Seducción";

                break;

            case 9:
                text_order = "Vengo por un ramo. He quedado con una chica y me gustaría agradecerle que me haya dado otra oportunidad para explicar un malentendido. ¿Puedes hacer que el ramo tenga alguna flor blanca? Es su color favorito.";
                text_orderSummary = "ResumenLigon9";
                clienteDelPedido = "Ethan";
                colorDelPedido = "Blanco";
                sentimientoDelPedido = "Agradecimiento";

                break;

            case 10:
                text_order = "Tengo una cita y necesito un ramo. Me gustaría que tuviera alguna flor roja, pero que no quedara muy recargado. ¡Ah sí! Y que transmita belleza. No quiero equivocarme como la otra vez y darle un ramo equivocado.";
                text_orderSummary = "ResumenLigon10";
                clienteDelPedido = "Ethan";
                colorDelPedido = "Rojo";
                sentimientoDelPedido = "Belleza";

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
                text_orderSummary = "ResumenCachopan1";
                clienteDelPedido = "Allan";
                colorDelPedido = "Morado";
                sentimientoDelPedido = "Alegría";

                break;

            case 2:
                text_order = "Me gustaría regalarle un ramo a mi vecina. Es una señora mayor que me ayuda mucho siempre. Me gustaría agradecerle todo lo que hace siempre por mí. ¿Podrías incluir alguna flor blanca en el ramo? ¡Es su color favorito!";
                text_orderSummary = "ResumenCachopan2";
                clienteDelPedido = "Allan";
                colorDelPedido = "Blanco";
                sentimientoDelPedido = "Agradecimiento";

                break;

            case 3:
                text_order = "Querría un ramo para mi vecina. La van a operar mañana y me gustaría desearle buena suerte. ¡Espero que salga todo bien! ¿Podrías incluir alguna flor rosa también?";
                text_orderSummary = "ResumenCachopan3";
                clienteDelPedido = "Allan";
                colorDelPedido = "Rosa";
                sentimientoDelPedido = "Buena suerte";

                break;

            case 4:
                text_order = "¿Me podrías preparar un ramo? Tengo un nuevo compañero en el trabajo y me gustaría que fuéramos amigos. ¿Crees que le gustarán las flores? ¡Ah, sí! Creo que me dijo que su color favorito era el amarillo. ¿Podrías incluir alguna flor de ese color?";
                text_orderSummary = "ResumenCachopan4";
                clienteDelPedido = "Allan";
                colorDelPedido = "Amarillo";
                sentimientoDelPedido = "Amistad";

                break;

            case 5:
                text_order = "¿Me podrías ayudar a elegir un ramo? Me gustaría ponerlo en la entrada de mi casa para que me trasmita felicidad cuando llegue a casa después de un día duro. También me gustaría que tuviera alguna flor de color azul.";
                text_orderSummary = "ResumenCachopan5";
                clienteDelPedido = "Allan";
                colorDelPedido = "Azul";
                sentimientoDelPedido = "Felicidad";

                break;

            case 6:
                text_order = "Mi vecina me ha pedido que le compre un ramo de flores para poder regalárselo a su nieta. ¿Tienes alguna flor que signifique bondad o pureza? ¡Ah, sí! También me ha dicho que el color preferido de su nieta es el rojo.";
                text_orderSummary = "ResumenCachopan6";
                clienteDelPedido = "Allan";
                colorDelPedido = "Rojo";
                sentimientoDelPedido = "Pureza del corazón";

                break;

            case 7:
                text_order = "Querría un ramo de flores para ponerlo como centro de mesa. Me gustaría que fuera alegre y muy colorido, para que destaque en la estancia. ¿Podrías poner alguna flor blanca también?";
                text_orderSummary = "ResumenCachopan7";
                clienteDelPedido = "Allan";
                colorDelPedido = "Blanco";
                sentimientoDelPedido = "Alegría";

                break;

            case 8:
                text_order = "¿Me podrías ayudar a escoger un ramo? Me gustaría agradecerle al guía del botánico que me explique tantas cosas de las plantas y que, aunque me ponga un poco pesado con las flores, siempre me responda con una sonrisa. ¿Podrías incluir alguna flor rosa?";
                text_orderSummary = "ResumenCachopan8";
                clienteDelPedido = "Allan";
                colorDelPedido = "Rosa";
                sentimientoDelPedido = "Agradecimiento";

                break;

            case 9:
                text_order = "¿Me podrías preparar un ramo para ponerlo en mi casa? Me gustaría que me diera buena suerte en mi trabajo para que el jefe no me regañe tanto. También querría que tuviera alguna flor amarilla si puede ser.";
                text_orderSummary = "ResumenCachopan9";
                clienteDelPedido = "Allan";
                colorDelPedido = "Amarillo";
                sentimientoDelPedido = "Buena suerte";

                break;

            case 10:
                text_order = "Quiero un ramo con alguna flor azul. Me gustaría regalárselo a mi vecina para agradecerle que me enseñara a preparar un plato de cocina. ¡Siempre se porta muy bien conmigo!";
                text_orderSummary = "ResumenCahopan10";
                clienteDelPedido = "Allan";
                colorDelPedido = "Azul";
                sentimientoDelPedido = "Agradecimiento";

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
                text_orderSummary = "ResumenPietro1";
                clienteDelPedido = "Pietro";
                colorDelPedido = "Rosa";
                sentimientoDelPedido = "Belleza";

                break;

            case 2:
                text_order = "Hoy quiero pintar una flor más abstracta. Umm… ¿Me puedes hacer un ramo que transmita sinceridad? También necesitaría que tuviera alguna flor amarilla.";
                text_orderSummary = "ResumenPietro2";
                clienteDelPedido = "Pietro";
                colorDelPedido = "Amarillo";
                sentimientoDelPedido = "Sinceridad";

                break;

            case 3:
                text_order = "Me gustaría hacer un bodegón con flores al estilo postimpresionista que refleje la pureza del corazón. Umm. ¿Tienes girasoles? ¿No? Vaya, es una pena….. Me conformo entonces con alguna flor azul. Me tendré que inspirar en “La noche estrellada” en lugar de en “Los girasoles” de Van Gogh.";
                text_orderSummary = "ResumenPietro3";
                clienteDelPedido = "Pietro";
                colorDelPedido = "Azul";
                sentimientoDelPedido = "Pureza del corazón";

                break;

            case 4:
                text_order = "Quiero un ramo para poder seguir pintando en casa. Umm. ¿Tienes alguna flor que inspire desconfianza? ¿Y alguna azul? Podría quedar bien pintar el ramo con un estilo expresionista, como en el cuadro “El grito”.";
                text_orderSummary = "ResumenPietro4";
                clienteDelPedido = "Pietro";
                colorDelPedido = "Azul";
                sentimientoDelPedido = "Desconfianza";

                break;

            case 5:
                text_order = "Hoy me apetece pintar un ramo que transmita agradecimiento. Ah, y que tenga alguna flor malva. No morada, sino malva, es muy importante. Si no es así no podré pintarlo con un estilo realista de manera adecuada, y eso sería un problema.";
                text_orderSummary = "ResumenPietro5";
                clienteDelPedido = "Pietro";
                colorDelPedido = "Malva";
                sentimientoDelPedido = "Agradecimiento";

                break;

            case 6:
                text_order = "Hoy me llevo un ramo para poder seguir pintando en casa. ¿Tienes alguna flor negra? ¿No? Vaya… Pues ponme alguna flor blanca en su lugar. Ah, sí. Y que el ramo transmita felicidad. Me gustaría hacer un cuadro de óleo sobre lienzo en blanco y negro.";
                text_orderSummary = "ResumenPietro6";
                clienteDelPedido = "Pietro";
                colorDelPedido = "Blanco";
                sentimientoDelPedido = "Felicidad";

                break;

            case 7:
                text_order = "Me gustaría llevarme un ramo para seguir pintando en casa. ¿Puedes incluir alguna flor amarilla? Ah sí, casi se me olvida. ¿Tienes alguna flor de Belladona? ¿No? Entonces, ¿puedes hacer que el ramo transmita seducción en su lugar?";
                text_orderSummary = "ResumenPietro7";
                clienteDelPedido = "Pietro";
                colorDelPedido = "Amarillo";
                sentimientoDelPedido = "Seducción";

                break;

            case 8:
                text_order = "Hoy me gustaría llevarme un ramo que transmita amor eterno…. Umm. ¿Tienes alguna flor morada? ¿Podrías incluirla en el ramo?";
                text_orderSummary = "ResumenPietro8";
                clienteDelPedido = "Pietro";
                colorDelPedido = "Morado";
                sentimientoDelPedido = "Amor eterno";

                break;

            case 9:
                text_order = "Quiero un ramo para poder seguir pintando después. ¿Tienes alguna flor que transmita desconfianza? Ah, sí. También me gustaría que incluyeras alguna flor roja.";
                text_orderSummary = "ResumenPietro9";
                clienteDelPedido = "Pietro";
                colorDelPedido = "Rojo";
                sentimientoDelPedido = "Desconfianza";

                break;

            case 10:
                text_order = "Hoy quiero un ramo que transmita amistad para poder pintarlo de manera abstracta. Umm. También me gustaría que tuviera alguna flor de alguno de los colores del amanecer. ¡Ya sé! ¡Amarilla!";
                text_orderSummary = "ResumenPietro10";
                clienteDelPedido = "Pietro";
                colorDelPedido = "Amarillo";
                sentimientoDelPedido = "Amistad";

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
                text_orderSummary = "ResumenAbuela1";
                clienteDelPedido = "Sagrario";
                colorDelPedido = "Amarillo";
                sentimientoDelPedido = "Felicidad";

                break;

            case 2:
                text_order = "Quisiera un ramo, por favor. ¿Podrías poner alguna flor blanca? Ah, sí. Y también te agradecería mucho que transmitiera agradecimiento.";
                text_orderSummary = "ResumenAbuela2";
                clienteDelPedido = "Sagrario";
                colorDelPedido = "Blanco";
                sentimientoDelPedido = "Agradecimiento";

                break;

            case 3:
                text_order = "¿Me podrías hacer un ramo bien bonito, niña? Ah, sí. Y a ser posible, que tenga muchas flores rojas para que llame la atención.";
                text_orderSummary = "ResumenAbuela3";
                clienteDelPedido = "Sagrario";
                colorDelPedido = "Rojo";
                sentimientoDelPedido = "Belleza";

                break;

            case 4:
                text_order = "Me gustaría comprar un ramo que hiciera feliz a todo aquel que lo viera. Ah, sí (que cabeza tengo). También quisiera que tuviera alguna flor rosa si no es mucha molestia.";
                text_orderSummary = "ResumenAbuela4";
                clienteDelPedido = "Sagrario";
                colorDelPedido = "Rosa";
                sentimientoDelPedido = "Felicidad";

                break;

            case 5:
                text_order = "Quisiera comprar un ramo que transmitiera amistad. Además, me gustaría que tuviera flores de color malva, si es posible.";
                text_orderSummary = "ResumenAbuela5";
                clienteDelPedido = "Sagrario";
                colorDelPedido = "Malva";
                sentimientoDelPedido = "Amistad";

                break;

            case 6:
                text_order = "Quisiera un ramo bonito y vistoso, por favor. ¿Tienes alguna flor azul, niña? Me gustaría ponerla en el ramo.";
                text_orderSummary = "ResumenAbuela6";
                clienteDelPedido = "Sagrario";
                colorDelPedido = "Azul";
                sentimientoDelPedido = "Belleza";

                break;

            case 7:
                text_order = "Me gustaría comprar un ramo. ¿Podrías hacer que transmitiera buena suerte? Creo que la voy a necesitar. No te preocupes por mí, niña. Son cosas mías. También quisiera añadirle alguna flor roja, si no es mucha molestia.";
                text_orderSummary = "ResumenAbuela7";
                clienteDelPedido = "Sagrario";
                colorDelPedido = "Rojo";
                sentimientoDelPedido = "Buena suerte";

                break;

            case 8:
                text_order = "Quisiera un ramo que transmita amor eterno a todo aquel que lo mire. Ah, sí. ¿Te queda alguna flor morada, niña? Me gustaría incluirla en el ramo.";
                text_orderSummary = "ResumenAbuela8";
                clienteDelPedido = "Sagrario";
                colorDelPedido = "Morado";
                sentimientoDelPedido = "Amor eterno";

                break;

            case 9:
                text_order = "Quisiera un ramo, por favor. ¿Puedes hacer que transmita agradecimiento? Ah, sí. También me gustaría que tuviera alguna flor rosa, si es posible.";
                text_orderSummary = "ResumenAbuela9";
                clienteDelPedido = "Sagrario";
                colorDelPedido = "Rosa";
                sentimientoDelPedido = "Agradecimiento";

                break;

            case 10:
                text_order = "Me gustaría comprar un ramo que transmitiera felicidad. También quisiera que incluyera alguna flor morada, si no es mucha molestia.";
                text_orderSummary = "ResumenAbuela10";
                clienteDelPedido = "Sagrario";
                colorDelPedido = "Morada";
                sentimientoDelPedido = "Felicidad";

                break;
        }

        Order.text = text_order;
        Summary.text = text_orderSummary;
    }

    #endregion
    /*
    #region Variables

    //Variables flores
    int typeOfFlower;
    int color;
    int feeling;

    //Variables textos
    private string text_typeOfFlower;
    private string text_color;
    private string text_feeling;

    public TMP_Text Type;
    public TMP_Text Color;
    public TMP_Text Feeling;

    #endregion


    #region Awake

    private void Awake()
    {
        typeOfFlower = Random.Range(1, 11);
        color = Random.Range(1, 11);
        feeling = Random.Range(1, 11);


        FlowersType(typeOfFlower);
        FlowersColor(color);
        Feelings(feeling);
    }

    #endregion


    #region FuncionesPedidosFlores
    private void FlowersType(int typeOfFlower)
    {
        switch (typeOfFlower)
        {
            case 1:
                text_typeOfFlower = "Tipo1";
                break;

            case 2:
                text_typeOfFlower = "Tipo2";
                break;

            case 3:
                text_typeOfFlower = "Tipo3";
                break;

            case 4:
                text_typeOfFlower = "Tipo4";
                break;

            case 5:
                text_typeOfFlower = "Tipo5";
                break;

            case 6:
                text_typeOfFlower = "Tipo6";
                break;

            case 7:
                text_typeOfFlower = "Tipo7";
                break;

            case 8:
                text_typeOfFlower = "Tipo8";
                break;

            case 9:
                text_typeOfFlower = "Tipo9";
                break;

            case 10:
                text_typeOfFlower = "Tipo10";
                break;

        }
        Type.text = text_typeOfFlower;
    }

    private void FlowersColor(int color)
    {
        switch (color)
        {
            case 1:
                text_color = "Color1";
                break;

            case 2:
                text_color = "Color2";
                break;

            case 3:
                text_color = "Color3";
                break;

            case 4:
                text_color = "Color4";
                break;

            case 5:
                text_color = "Color5";
                break;

            case 6:
                text_color = "Color6";
                break;

            case 7:
                text_color = "Color7";
                break;

            case 8:
                text_color = "Color8";
                break;

            case 9:
                text_color = "Color9";
                break;

            case 10:
                text_color = "Color10";
                break;

        }

        Color.text = text_color;
    }

    private void Feelings(int feeling)
    {
        switch (feeling)
        {
            case 1:
                text_feeling = "Sentimiento1";
                break;

            case 2:
                text_feeling = "Sentimiento2";
                break;

            case 3:
                text_feeling = "Sentimiento3";
                break;

            case 4:
                text_feeling = "Sentimiento4";
                break;

            case 5:
                text_feeling = "Sentimiento5";
                break;

            case 6:
                text_feeling = "Sentimiento6";
                break;

            case 7:
                text_feeling = "Sentimiento7";
                break;

            case 8:
                text_feeling = "Sentimiento8";
                break;

            case 9:
                text_feeling = "Sentimiento9";
                break;

            case 10:
                text_feeling = "Sentimiento10";
                break;
        }

        Feeling.text = text_feeling;
    }
    #endregion
    */


}
