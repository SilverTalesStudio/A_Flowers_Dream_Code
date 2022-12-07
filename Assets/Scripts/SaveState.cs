using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class SaveState
{
  
        string PjName;
        string PjGender;
        string PjCharacter;
        string nodeSaved;
        string planes_Finde;
        string musicaActual;
        string varsInYarnJSON;
        string npcAllan;
        string npcSophie;
        string npcEthan;
        string npcSagrario;
        string npcPietro;
    public SaveState(string pjname_, string pjgender_, string pjcharacter_, string nodesaved_, string planesfinde_, string musicaactual_, string variablesinyarn_,
        string npcallan_, string npcSophie_, string npcEthan_, string npcPietro_, string npcsagrario_
        )
    {
        PjCharacter = pjcharacter_;
        PjName = pjname_;   
        PjGender = pjgender_;
        nodeSaved = nodesaved_;
        planes_Finde = planesfinde_;
        musicaActual = musicaactual_;
        varsInYarnJSON = variablesinyarn_;
        npcAllan = npcallan_;
        npcSophie = npcSophie_; 
        npcEthan = npcEthan_;
        npcPietro = npcPietro_;
        npcSagrario= npcsagrario_ ;
    }

    
}
