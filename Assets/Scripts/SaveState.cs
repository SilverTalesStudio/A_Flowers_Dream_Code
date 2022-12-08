using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class SaveState
{
  
        public string PjName;
    public string PjGender;
    public string PjCharacter;
    public string nodeSaved;
    public string planes_Finde;
    public string musicaActual;
    public string varsInYarnJSON;
    public string npcAllan;
    public string npcSophie;
    public string npcEthan;
    public string npcSagrario;
    public string npcPietro;
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

    public void setPlayerPrefs()
    {
        PlayerPrefs.SetString("PlayerName", PjName);
         PlayerPrefs.SetString("PlayerGender", PjGender);
            PlayerPrefs.SetString("PlayerMainCharacter", PjCharacter);
          PlayerPrefs.SetString("nodeSaved", nodeSaved);
            PlayerPrefs.SetString("Planes", planes_Finde);
           PlayerPrefs.SetString("currentMusic", musicaActual);
          PlayerPrefs.SetString("YarnBasicSave", varsInYarnJSON);
         PlayerPrefs.SetString("NPC_allan", npcAllan);
          PlayerPrefs.SetString("NPC_sophie", npcSophie);
         PlayerPrefs.SetString("NPC_ethan", npcEthan);
          PlayerPrefs.SetString("NPC_pietro", npcPietro);
        PlayerPrefs.SetString("NPC_sagrario", npcSagrario);

    }
}
