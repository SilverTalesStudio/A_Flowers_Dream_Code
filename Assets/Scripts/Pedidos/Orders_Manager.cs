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
        //Longitud m�xima de los pedidos 288 caracteres con espacios incluidos

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
                text_order = "Mi hermana quiere un ramo que le d� buena suerte (aunque no creo que seas capaz de hacerlo, pero bueno). Tambi�n le gustar�a que tuviera alguna flor blanca.";
                text_orderSummary = "ResumenSophie2";
                clienteDelPedido = "Sophie";
                colorDelPedido = "Blanca";
                sentimientoDelPedido = "Buena suerte";

                break;

            case 3:
                text_order = "Necesito un ramo para mi hermana. Quiere regal�rselo a una amiga suya as� que espero que no la decepciones. Me ha dicho que el color preferido de su amiga es el amarillo. �Te ha quedado claro?";
                text_orderSummary = "ResumenSophie3";
                clienteDelPedido = "Sophie";
                colorDelPedido = "Amarillo";
                sentimientoDelPedido = "Amistad";

                break;

            case 4:
                text_order = "Quiero un ramo con alguna flor rosa. Mi hermana quiere d�rselo a una amiga suya para pedirle perd�n por no haber sido sincera con ella. No tardes mucho, que tengo prisa.";
                text_orderSummary = "ResumenSophie4";
                clienteDelPedido = "Sophie";
                colorDelPedido = "Rosa";
                sentimientoDelPedido = "Sinceridad";

                break;

            case 5:
                text_order = "Mi hermana me ha pedido un ramo. Quiere que sea lo m�s bonito posible porque se lo quiere regalar a una amiga por su cumplea�os (aunque no s� por qu� te tengo que dar explicaciones). Tambi�n quiere que tenga alguna flor roja. ";
                text_orderSummary = "ResumenSophie5";
                clienteDelPedido = "Sophie";
                colorDelPedido = "Rojo";
                sentimientoDelPedido = "Belleza";

                break;

            case 6:
                text_order = "Quiero un ramo que sea alegre y colorido para mi hermana. Adem�s, quiero que tenga alguna flor malva (aunque no creo que tengas ninguna flor as�, pero bueno).";
                text_orderSummary = "ResumenSophie6";
                clienteDelPedido = "Sophie";
                colorDelPedido = "Malva";
                sentimientoDelPedido = "Felicidad";

                break;

            case 7:
                text_order = "Necesito un ramo para agradecerle a mi hermana una cosa. �Qu� por qu�? Yo no tengo que darte explicaciones. Simplemente ponme el ramo. Ah, y no te olvides de incluir alguna flor azul.";
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
                text_order = "Quiero un ramo con alguna flor morada. Y date prisa, que tengo que llev�rselo a mi hermana para que pueda d�rselo a su nueva amiga.";
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
                text_order = "Quiero un ramo con el que poder conquistar a una chica. Es la primera cita y quiero impresionarla. Creo que su color favorito era el rojo. No, era el morado. �O era el amarillo? Bueno da igual, pon alguna flor roja.";
                text_orderSummary = "ResumenLigon1";
                clienteDelPedido = "Ethan";
                colorDelPedido = "Rojo";
                sentimientoDelPedido = "Seducci�n";

                break;

            case 2:
                text_order = "Tengo una cita y necesito un ramo. Si no recuerdo mal, uno de los colores que m�s le gustan es el morado. �Tienes alguna flor morada? Tambi�n me gustar�a que el ramo fuera espectacular para poder impresionarla.";
                text_orderSummary = "ResumenLigon2";
                clienteDelPedido = "Ethan";
                colorDelPedido = "Morado";
                sentimientoDelPedido = "Seducci�n";
         
                break;

            case 3:
                text_order = "Hay una chica que no para de perseguirme, pero a m� no me gusta. �Se te ocurre algo para decirle que solo quiero ser su amigo? Si puede ser me gustar�a que el ramo tambi�n incluyera alguna flor de color rosa, �me har�as ese favor?";
                text_orderSummary = "ResumenLigon3";
                clienteDelPedido = "Ethan";
                colorDelPedido = "Rosa";
                sentimientoDelPedido = "Amistad";

                break;

            case 4:
                text_order = "Hoy tengo una cita, pero en verdad me gustar�a cortar con la chica. �Conoces alguna flor que me sirva? Adem�s, creo recordar que el color que menos le gusta es el azul. �Seguro que si le llevo un ramo con una flor de ese color ya no querr� salir conmigo! �Puedes crear un ramo as�?";
                text_orderSummary = "ResumenLigon4";
                clienteDelPedido = "Ethan";
                colorDelPedido = "Azul";
                sentimientoDelPedido = "Decepci�n";

                break;

            case 5:
                text_order = "Hoy tengo una cita y necesito un ramo. Tienes alguna flor que sirva para decir ��No te doli� cuando ca�ste del cielo?�. Es que me gustar�a sorprenderla, pero est� cansada de escuchar mis piropos. Tambi�n querr�a que el ramo incluyera alguna flor de un color poco habitual.";
                text_orderSummary = "ResumenLigon5";
                clienteDelPedido = "Ethan";
                colorDelPedido = "Azul";
                sentimientoDelPedido = "Belleza";

                break;

            case 6:
                text_order = "Necesito un ramo urgentemente. La chica con la que estoy saliendo no cree que lo que digo sea cierto y necesito un ramo que demuestre lo contrario. �Podr�as incluir tambi�n alguna flor blanca?";
                text_orderSummary = "ResumenLigon6";
                clienteDelPedido = "Ethan";
                colorDelPedido = "Blanco";
                sentimientoDelPedido = "Sinceridad";

                break;

            case 7:
                text_order = "Tengo una cita y necesito un ramo. �Tienes alguna flor naranja? �No? Vaya, es una pena. �Y alguna no s�, de color amarillo? Espero que este ramo me d� buena suerte durante la cita.";
                text_orderSummary = "ResumenLigon6";
                clienteDelPedido = "Ethan";
                colorDelPedido = "Amarillo";
                sentimientoDelPedido = "Buena suerte";

                break;

            case 8:
                text_order = "Necesito un ramo para esta noche. Me gustar�a que destaque para impresionar a una chica. Si es posible, �podr�as incluir alguna flor malva? Creo que quedar�a muy bien en el ramo.";
                text_orderSummary = "ResumenLigon8";
                clienteDelPedido = "Ethan";
                colorDelPedido = "Malva";
                sentimientoDelPedido = "Seducci�n";

                break;

            case 9:
                text_order = "Vengo por un ramo. He quedado con una chica y me gustar�a agradecerle que me haya dado otra oportunidad para explicar un malentendido. �Puedes hacer que el ramo tenga alguna flor blanca? Es su color favorito.";
                text_orderSummary = "ResumenLigon9";
                clienteDelPedido = "Ethan";
                colorDelPedido = "Blanco";
                sentimientoDelPedido = "Agradecimiento";

                break;

            case 10:
                text_order = "Tengo una cita y necesito un ramo. Me gustar�a que tuviera alguna flor roja, pero que no quedara muy recargado. �Ah s�! Y que transmita belleza. No quiero equivocarme como la otra vez y darle un ramo equivocado.";
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
                text_order = "Necesito un ramo para ponerlo como centro de mesa. �Me podr�as ayudar? Me gustar�a que transmitiera alegr�a a toda la habitaci�n. Ah, y si puede ser que tenga alguna flor de color morada.";
                text_orderSummary = "ResumenCachopan1";
                clienteDelPedido = "Allan";
                colorDelPedido = "Morado";
                sentimientoDelPedido = "Alegr�a";

                break;

            case 2:
                text_order = "Me gustar�a regalarle un ramo a mi vecina. Es una se�ora mayor que me ayuda mucho siempre. Me gustar�a agradecerle todo lo que hace siempre por m�. �Podr�as incluir alguna flor blanca en el ramo? �Es su color favorito!";
                text_orderSummary = "ResumenCachopan2";
                clienteDelPedido = "Allan";
                colorDelPedido = "Blanco";
                sentimientoDelPedido = "Agradecimiento";

                break;

            case 3:
                text_order = "Querr�a un ramo para mi vecina. La van a operar ma�ana y me gustar�a desearle buena suerte. �Espero que salga todo bien! �Podr�as incluir alguna flor rosa tambi�n?";
                text_orderSummary = "ResumenCachopan3";
                clienteDelPedido = "Allan";
                colorDelPedido = "Rosa";
                sentimientoDelPedido = "Buena suerte";

                break;

            case 4:
                text_order = "�Me podr�as preparar un ramo? Tengo un nuevo compa�ero en el trabajo y me gustar�a que fu�ramos amigos. �Crees que le gustar�n las flores? �Ah, s�! Creo que me dijo que su color favorito era el amarillo. �Podr�as incluir alguna flor de ese color?";
                text_orderSummary = "ResumenCachopan4";
                clienteDelPedido = "Allan";
                colorDelPedido = "Amarillo";
                sentimientoDelPedido = "Amistad";

                break;

            case 5:
                text_order = "�Me podr�as ayudar a elegir un ramo? Me gustar�a ponerlo en la entrada de mi casa para que me trasmita felicidad cuando llegue a casa despu�s de un d�a duro. Tambi�n me gustar�a que tuviera alguna flor de color azul.";
                text_orderSummary = "ResumenCachopan5";
                clienteDelPedido = "Allan";
                colorDelPedido = "Azul";
                sentimientoDelPedido = "Felicidad";

                break;

            case 6:
                text_order = "Mi vecina me ha pedido que le compre un ramo de flores para poder regal�rselo a su nieta. �Tienes alguna flor que signifique bondad o pureza? �Ah, s�! Tambi�n me ha dicho que el color preferido de su nieta es el rojo.";
                text_orderSummary = "ResumenCachopan6";
                clienteDelPedido = "Allan";
                colorDelPedido = "Rojo";
                sentimientoDelPedido = "Pureza del coraz�n";

                break;

            case 7:
                text_order = "Querr�a un ramo de flores para ponerlo como centro de mesa. Me gustar�a que fuera alegre y muy colorido, para que destaque en la estancia. �Podr�as poner alguna flor blanca tambi�n?";
                text_orderSummary = "ResumenCachopan7";
                clienteDelPedido = "Allan";
                colorDelPedido = "Blanco";
                sentimientoDelPedido = "Alegr�a";

                break;

            case 8:
                text_order = "�Me podr�as ayudar a escoger un ramo? Me gustar�a agradecerle al gu�a del bot�nico que me explique tantas cosas de las plantas y que, aunque me ponga un poco pesado con las flores, siempre me responda con una sonrisa. �Podr�as incluir alguna flor rosa?";
                text_orderSummary = "ResumenCachopan8";
                clienteDelPedido = "Allan";
                colorDelPedido = "Rosa";
                sentimientoDelPedido = "Agradecimiento";

                break;

            case 9:
                text_order = "�Me podr�as preparar un ramo para ponerlo en mi casa? Me gustar�a que me diera buena suerte en mi trabajo para que el jefe no me rega�e tanto. Tambi�n querr�a que tuviera alguna flor amarilla si puede ser.";
                text_orderSummary = "ResumenCachopan9";
                clienteDelPedido = "Allan";
                colorDelPedido = "Amarillo";
                sentimientoDelPedido = "Buena suerte";

                break;

            case 10:
                text_order = "Quiero un ramo con alguna flor azul. Me gustar�a regal�rselo a mi vecina para agradecerle que me ense�ara a preparar un plato de cocina. �Siempre se porta muy bien conmigo!";
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
                text_order = "Umm. Me gustar�a llevarme un ramo de flores para poder seguir pintando en casa. �Tienes alguna flor que pegue con la corriente impresionista? Alguna que transmita belleza, me viene bien. Ah, y que el ramo incluya algo de rosa.";
                text_orderSummary = "ResumenPietro1";
                clienteDelPedido = "Pietro";
                colorDelPedido = "Rosa";
                sentimientoDelPedido = "Belleza";

                break;

            case 2:
                text_order = "Hoy quiero pintar una flor m�s abstracta. Umm� �Me puedes hacer un ramo que transmita sinceridad? Tambi�n necesitar�a que tuviera alguna flor amarilla.";
                text_orderSummary = "ResumenPietro2";
                clienteDelPedido = "Pietro";
                colorDelPedido = "Amarillo";
                sentimientoDelPedido = "Sinceridad";

                break;

            case 3:
                text_order = "Me gustar�a hacer un bodeg�n con flores al estilo postimpresionista que refleje la pureza del coraz�n. Umm. �Tienes girasoles? �No? Vaya, es una pena�.. Me conformo entonces con alguna flor azul. Me tendr� que inspirar en �La noche estrellada� en lugar de en �Los girasoles� de Van Gogh.";
                text_orderSummary = "ResumenPietro3";
                clienteDelPedido = "Pietro";
                colorDelPedido = "Azul";
                sentimientoDelPedido = "Pureza del coraz�n";

                break;

            case 4:
                text_order = "Quiero un ramo para poder seguir pintando en casa. Umm. �Tienes alguna flor que inspire desconfianza? �Y alguna azul? Podr�a quedar bien pintar el ramo con un estilo expresionista, como en el cuadro �El grito�.";
                text_orderSummary = "ResumenPietro4";
                clienteDelPedido = "Pietro";
                colorDelPedido = "Azul";
                sentimientoDelPedido = "Desconfianza";

                break;

            case 5:
                text_order = "Hoy me apetece pintar un ramo que transmita agradecimiento. Ah, y que tenga alguna flor malva. No morada, sino malva, es muy importante. Si no es as� no podr� pintarlo con un estilo realista de manera adecuada, y eso ser�a un problema.";
                text_orderSummary = "ResumenPietro5";
                clienteDelPedido = "Pietro";
                colorDelPedido = "Malva";
                sentimientoDelPedido = "Agradecimiento";

                break;

            case 6:
                text_order = "Hoy me llevo un ramo para poder seguir pintando en casa. �Tienes alguna flor negra? �No? Vaya� Pues ponme alguna flor blanca en su lugar. Ah, s�. Y que el ramo transmita felicidad. Me gustar�a hacer un cuadro de �leo sobre lienzo en blanco y negro.";
                text_orderSummary = "ResumenPietro6";
                clienteDelPedido = "Pietro";
                colorDelPedido = "Blanco";
                sentimientoDelPedido = "Felicidad";

                break;

            case 7:
                text_order = "Me gustar�a llevarme un ramo para seguir pintando en casa. �Puedes incluir alguna flor amarilla? Ah s�, casi se me olvida. �Tienes alguna flor de Belladona? �No? Entonces, �puedes hacer que el ramo transmita seducci�n en su lugar?";
                text_orderSummary = "ResumenPietro7";
                clienteDelPedido = "Pietro";
                colorDelPedido = "Amarillo";
                sentimientoDelPedido = "Seducci�n";

                break;

            case 8:
                text_order = "Hoy me gustar�a llevarme un ramo que transmita amor eterno�. Umm. �Tienes alguna flor morada? �Podr�as incluirla en el ramo?";
                text_orderSummary = "ResumenPietro8";
                clienteDelPedido = "Pietro";
                colorDelPedido = "Morado";
                sentimientoDelPedido = "Amor eterno";

                break;

            case 9:
                text_order = "Quiero un ramo para poder seguir pintando despu�s. �Tienes alguna flor que transmita desconfianza? Ah, s�. Tambi�n me gustar�a que incluyeras alguna flor roja.";
                text_orderSummary = "ResumenPietro9";
                clienteDelPedido = "Pietro";
                colorDelPedido = "Rojo";
                sentimientoDelPedido = "Desconfianza";

                break;

            case 10:
                text_order = "Hoy quiero un ramo que transmita amistad para poder pintarlo de manera abstracta. Umm. Tambi�n me gustar�a que tuviera alguna flor de alguno de los colores del amanecer. �Ya s�! �Amarilla!";
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
                text_order = "Me gustar�a comprar un ramo, pero no entiendo mucho de flores. �Se puede poner alguna flor que transmita felicidad? Ah, casi se me olvida, tambi�n me gustar�a que tuviera alguna flor amarilla, si es posible.";
                text_orderSummary = "ResumenAbuela1";
                clienteDelPedido = "Sagrario";
                colorDelPedido = "Amarillo";
                sentimientoDelPedido = "Felicidad";

                break;

            case 2:
                text_order = "Quisiera un ramo, por favor. �Podr�as poner alguna flor blanca? Ah, s�. Y tambi�n te agradecer�a mucho que transmitiera agradecimiento.";
                text_orderSummary = "ResumenAbuela2";
                clienteDelPedido = "Sagrario";
                colorDelPedido = "Blanco";
                sentimientoDelPedido = "Agradecimiento";

                break;

            case 3:
                text_order = "�Me podr�as hacer un ramo bien bonito, ni�a? Ah, s�. Y a ser posible, que tenga muchas flores rojas para que llame la atenci�n.";
                text_orderSummary = "ResumenAbuela3";
                clienteDelPedido = "Sagrario";
                colorDelPedido = "Rojo";
                sentimientoDelPedido = "Belleza";

                break;

            case 4:
                text_order = "Me gustar�a comprar un ramo que hiciera feliz a todo aquel que lo viera. Ah, s� (que cabeza tengo). Tambi�n quisiera que tuviera alguna flor rosa si no es mucha molestia.";
                text_orderSummary = "ResumenAbuela4";
                clienteDelPedido = "Sagrario";
                colorDelPedido = "Rosa";
                sentimientoDelPedido = "Felicidad";

                break;

            case 5:
                text_order = "Quisiera comprar un ramo que transmitiera amistad. Adem�s, me gustar�a que tuviera flores de color malva, si es posible.";
                text_orderSummary = "ResumenAbuela5";
                clienteDelPedido = "Sagrario";
                colorDelPedido = "Malva";
                sentimientoDelPedido = "Amistad";

                break;

            case 6:
                text_order = "Quisiera un ramo bonito y vistoso, por favor. �Tienes alguna flor azul, ni�a? Me gustar�a ponerla en el ramo.";
                text_orderSummary = "ResumenAbuela6";
                clienteDelPedido = "Sagrario";
                colorDelPedido = "Azul";
                sentimientoDelPedido = "Belleza";

                break;

            case 7:
                text_order = "Me gustar�a comprar un ramo. �Podr�as hacer que transmitiera buena suerte? Creo que la voy a necesitar. No te preocupes por m�, ni�a. Son cosas m�as. Tambi�n quisiera a�adirle alguna flor roja, si no es mucha molestia.";
                text_orderSummary = "ResumenAbuela7";
                clienteDelPedido = "Sagrario";
                colorDelPedido = "Rojo";
                sentimientoDelPedido = "Buena suerte";

                break;

            case 8:
                text_order = "Quisiera un ramo que transmita amor eterno a todo aquel que lo mire. Ah, s�. �Te queda alguna flor morada, ni�a? Me gustar�a incluirla en el ramo.";
                text_orderSummary = "ResumenAbuela8";
                clienteDelPedido = "Sagrario";
                colorDelPedido = "Morado";
                sentimientoDelPedido = "Amor eterno";

                break;

            case 9:
                text_order = "Quisiera un ramo, por favor. �Puedes hacer que transmita agradecimiento? Ah, s�. Tambi�n me gustar�a que tuviera alguna flor rosa, si es posible.";
                text_orderSummary = "ResumenAbuela9";
                clienteDelPedido = "Sagrario";
                colorDelPedido = "Rosa";
                sentimientoDelPedido = "Agradecimiento";

                break;

            case 10:
                text_order = "Me gustar�a comprar un ramo que transmitiera felicidad. Tambi�n quisiera que incluyera alguna flor morada, si no es mucha molestia.";
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
