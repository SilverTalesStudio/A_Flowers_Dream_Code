using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Yarn.Unity.Example
{
	/// <summary>
	/// runs Yarn commands and manages sprites for the Visual Novel example
	/// </summary>
	 public enum NPCsDateable
	{
		Sophie, Allan, Ethan, None
	}

public class VNManager : DialogueViewBase
    {
		[SerializeField] DialogueRunner runner;
		//public YarnProject yarnProject;
		public SceneChanger SceneChanger;

		[Header("Assets"), Tooltip("you can manually assign various assets here if you don't want to use /Resources/ folder")]
		public List<Sprite> loadSprites = new List<Sprite>();
		public List<AudioClip> loadAudio = new List<AudioClip>();

		[Tooltip("if enabled: will automatically load all Sprites and AudioClips in any /Resources/ folder including any subfolders")]
		public bool useResourcesFolders = false;


		[Header("Sprite UI settings")] // UI tuning variables and references
		[Tooltip("all sprites will be tinted with this color")] 
		public Color defaultTint;
		[Tooltip("when speaking, a sprite will be highlighted by tinting it with this color")]
		public Color highlightTint;


		[Header("Object references"), Tooltip("don't change these unless you know what you're doing")]
		public RectTransform spriteGroup; // used for screenshake
		public Image bgImage, fadeBG, nameplateBG;
		public Image genericSprite; // local prefab, used for instantiating sprites
		public AudioSource genericAudioSource; // local prefab, used for instantiating sounds

		// big lists to keep track of all instantiated objects
		public List<AudioSource> sounds = new List<AudioSource>(); // big list of all instantiated sounds
		List<Image> sprites = new List<Image>(); // big list of all instantianted sprites

		// store sprite references for "actors" (characters, etc.)
		[HideInInspector] public Dictionary<string, VNActor> actors = new Dictionary<string, VNActor>(); // tracks names to sprites

		static Vector2 screenSize = new Vector2( 1280f, 720f); // needed for position calcuations, e.g. what does "left" mean?
		string startNodeManually;
		//bool YarnProjectLoaded;
		void Awake () {
			//YarnProjectLoaded = false;

			//Carga por el nodo que tocaba o si es partida nueva empieza desde el principio
			if (PlayerPrefs.GetString("nodeSaved").Length > 1 && PlayerPrefs.GetString("YarnBasicSave").Length > 1)
			{
				runner.LoadStateFromPlayerPrefs();
				startNodeManually = PlayerPrefs.GetString("nodeSaved");

			}
			else
			{
				//Inicializa el startNode
				startNodeManually = "Semana1";
			}
			Debug.Log("Previa a stratNode: "+startNodeManually);
			runner.startNode = startNodeManually;



			//chequear musica

			if (PlayerPrefs.GetString("nodeSaved").Length > 1 && PlayerPrefs.GetString("YarnBasicSave").Length > 1)
			{
				string jsonMusic = PlayerPrefs.GetString("currentMusic");
				Debug.Log(jsonMusic);
				MusicSet musicaCarga = JsonUtility.FromJson<MusicSet>(jsonMusic);
				PlayAudio(musicaCarga.soundName, musicaCarga.volume, musicaCarga.loop);

			}


			// manually add all Yarn command handlers, so that we don't
			// have to type out game object names in Yarn scripts (also
			// gives us a performance increase by avoiding GameObject.Find)


			//Propios
			//Propios
			runner.AddCommandHandler<string, int>("Add_npc_likeability", AddToLikeability);
			runner.AddCommandHandler<string, string>("Go_to_minigame", GoToMinigame);
			runner.AddCommandHandler<string>("Save_node_to_jump_back", SaveNextNodeToJumpBack);
			runner.AddCommandHandler("Plans_To_Zero", PlansToZero);
			runner.AddCommandHandler("the_end", TheEnd);
			runner.AddCommandHandler<string, bool, bool>("Update_Plans", UpdatePlans);
			runner.AddCommandHandler<string>("citaFin", AddCitaFinal);
			runner.AddCommandHandler<string>("sobreMinerva", AddInfoMinerva);
			runner.AddCommandHandler<string>("seDejaPintaraPietro", AddPintarPietro);
			runner.AddCommandHandler<string>("LeisteLibroEthanMartes", AddLibroEthan);
			runner.AddCommandHandler<string>("conciertoSophieCancelado", AddConciertoSophie);
			//Ilustraciones
			runner.AddCommandHandler<string>("AllanIlustracion1FEM", ActiveAllanIllus1FEM);
			runner.AddCommandHandler<string>("AllanIlustracion2FEM", ActiveAllanIllus2FEM);
			runner.AddCommandHandler<string>("EthanIlustracion1FEM", ActiveEthanIllus1FEM);
			runner.AddCommandHandler<string>("EthanIlustracion2FEM", ActiveEthanIllus2FEM);
			runner.AddCommandHandler<string>("EthanIlustracion3FEM", ActiveEthanIllus3FEM);
			runner.AddCommandHandler<string>("SophieIlustracion1FEM", ActiveSophieIllus1FEM);
			runner.AddCommandHandler<string>("SophieIlustracion2FEM", ActiveSophieIllus2FEM);
			runner.AddCommandHandler<string>("AllanIlustracion1MAS", ActiveAllanIllus1MAS);
			runner.AddCommandHandler<string>("AllanIlustracion2MAS", ActiveAllanIllus2MAS);
			runner.AddCommandHandler<string>("EthanIlustracion1MAS", ActiveEthanIllus1MAS);
			runner.AddCommandHandler<string>("EthanIlustracion2MAS", ActiveEthanIllus2MAS);
			runner.AddCommandHandler<string>("EthanIlustracion3MAS", ActiveEthanIllus3MAS);
			runner.AddCommandHandler<string>("SophieIlustracion1MAS", ActiveSophieIllus1MAS);
			runner.AddCommandHandler<string>("SophieIlustracion2MAS", ActiveSophieIllus2MAS);

			//Ropework framework
			runner.AddCommandHandler<string>("Scene", DoSceneChange );
			runner.AddCommandHandler<string,string,string,string,string>("Act", SetActor );
			runner.AddCommandHandler<string,string,string>("Draw", SetSpriteYarn );

			runner.AddCommandHandler<string>("Hide", HideSprite );
			runner.AddCommandHandler("HideAll", HideAllSprites );
			runner.AddCommandHandler("Reset", ResetScene );

			runner.AddCommandHandler<string,string,string,float>("Move", MoveSprite );
			runner.AddCommandHandler<string,string>("Flip", FlipSprite );
			runner.AddCommandHandler<string,float>("Shake", ShakeSprite );

			runner.AddCommandHandler<string,float,string>("PlayAudio", PlayAudio );
			runner.AddCommandHandler<string>("StopAudio", StopAudio );
			runner.AddCommandHandler("StopAudioAll", StopAudioAll );

            runner.AddCommandHandler<string,float,float,float>("Fade", SetFade );
			runner.AddCommandHandler<float>("FadeIn", SetFadeIn );
			runner.AddCommandHandler<string,string,float>("CamOffset", SetCameraOffset );

			// adds all Resources to internal lists / one big pile... it
			// will scan inside all subfolders too! note: but when
			// referencing sprites in the Yarn script, just use the file
			// name and omit folder names
			if ( useResourcesFolders ) {
				var allSpritesInResources = Resources.LoadAll<Sprite>("");
				loadSprites.AddRange( allSpritesInResources );
				var allAudioInResources = Resources.LoadAll<AudioClip>("");
				loadAudio.AddRange( allAudioInResources );
			}
		}
		/*private void Update()
		{
			if (YarnProjectLoaded == false) 
			{
				if (runner.yarnProject != null)
				{
					YarnProjectLoaded=true;
					runner.StartDialogue(startNodeManually);
				}

			}
			
		}*/
      /*  private void Start()
		{
			runner.startNode = startNodeManually;
		}*/
		#region YarnCommands
		public void TheEnd()
		{

			SceneChanger.changeScene("TheEnd");
		}
		public void PlansToZero()
		{

			string json = PlayerPrefs.GetString("Planes");
			Planes_Finde obj = JsonUtility.FromJson<Planes_Finde>(json);
			obj.Plan_Ethan_isTherePlan = false;
			obj.Plan_Ethan_isLocked = false;
			obj.Plan_Sophie_isTherePlan = false;
			obj.Plan_Sophie_isLocked = false;
			obj.Plan_Allan_isTherePlan = false;
			obj.Plan_Allan_isLocked = false;
			json = JsonUtility.ToJson(obj);
			PlayerPrefs.SetString("Planes", json);
		}

		public void UpdatePlans(string name, bool isPlan, bool isLocked)
		{
			string json = PlayerPrefs.GetString("Planes");
			Planes_Finde obj = JsonUtility.FromJson<Planes_Finde>(json);
			NPCsDateable enumerator = System.Enum.Parse<NPCsDateable>(name);
			switch (enumerator)
			{
				case NPCsDateable.Sophie:
					if (isPlan)
					{
						if (isLocked)
						{
							obj.Plan_Sophie_isTherePlan=true;
							obj.Plan_Sophie_isLocked=true;

						}
						else
						{
							obj.Plan_Sophie_isTherePlan = true;
							obj.Plan_Sophie_isLocked = false;
						}
					}
					break;
				case NPCsDateable.Allan:
					if (isPlan)
					{
						if (isLocked)
						{
							obj.Plan_Allan_isTherePlan = true;
							obj.Plan_Allan_isLocked = true;

						}
						else
						{
							obj.Plan_Allan_isTherePlan = true;
							obj.Plan_Allan_isLocked = false;
						}
					}
					break;
				case NPCsDateable.Ethan:
					if (isPlan)
					{
						if (isLocked)
						{
							obj.Plan_Ethan_isTherePlan = true;
							obj.Plan_Ethan_isLocked = true;

						}
						else
						{
							obj.Plan_Ethan_isTherePlan = true;
							obj.Plan_Ethan_isLocked = false;
						}
					}
					break;
				case NPCsDateable.None:
					break;
				default:
					break;
			}

			Debug.Log(obj.Plan_Allan_isTherePlan);
			string json2 = JsonUtility.ToJson(obj);
			PlayerPrefs.SetString("Planes", json2);
		}
		///<summary> Añade al sistema de love-hate de personaje un valor positivo o negativo</summary>

		public void AddToLikeability(string keyVar, int sumValue)
		{
			Debug.Log("Entra al add likeability");
			string json = PlayerPrefs.GetString(keyVar);
			NPC_stats npc = JsonUtility.FromJson<NPC_stats>(json);
			npc.likeability += sumValue;

			json = JsonUtility.ToJson(npc);
			PlayerPrefs.SetString(keyVar, json);
		}

		public void GoToMinigame(string nombreCliente, string pedidoFijo)
		{
			Debug.Log("Entra en go to minigame");
			Debug.Log(nombreCliente);
			Debug.Log(pedidoFijo);
			PlayerPrefs.SetString("clienteActual", nombreCliente);
			PlayerPrefs.SetString("fijo", pedidoFijo);
			Debug.Log(runner.CurrentNodeName);
			PlayerPrefs.SetString("currentMinigame", runner.CurrentNodeName);
			runner.SaveStateToPlayerPrefs();
			SceneChanger.nextOrder = nombreCliente;
			//Se llama con PlayerPrefs.GetString("clienteActual");


			// SceneChanger.changeScene("MinijuegoFlores");
		}
		public void AddCitaFinal(string cita)
        {
			Debug.Log("Entra en AddCitaFinal");
			PlayerPrefs.SetString("citafinal", cita);
			Debug.Log(cita);
        }

		public void AddInfoMinerva(string info)
		{
			Debug.Log("Entra en AddInfoMinerva");
			PlayerPrefs.SetString("infoMinerva", info);
			Debug.Log(info);
		}

		public void AddPintarPietro(string pintar)
		{
			Debug.Log("Entra en AddPintarPietro");
			PlayerPrefs.SetString("dejaPintar", pintar);
			Debug.Log(pintar);
		}

		public void AddLibroEthan(string libro)
		{
			Debug.Log("Entra en AddLibroEthan");
			PlayerPrefs.SetString("libroLeido", libro);
			Debug.Log(libro);
		}

		public void AddConciertoSophie(string concierto)
		{
			Debug.Log("Entra en AddConciertoSophie");
			PlayerPrefs.SetString("conciertoCancelado", concierto);
			Debug.Log(concierto);
		}

		//Ilustraciones FEM
		public void ActiveAllanIllus1FEM(string activado)
		{
			Debug.Log("Activa Ilustración Allan semana 1 FEM");
			PlayerPrefs.SetString("AllanIllus1FEM", activado);
			Debug.Log(activado);
		}
		public void ActiveAllanIllus2FEM(string activado)
		{
			Debug.Log("Activa Ilustración Allan semana 3 FEM");
			PlayerPrefs.SetString("AllanIllus2FEM", activado);
			Debug.Log(activado);
		}
		public void ActiveEthanIllus1FEM(string activado)
		{
			Debug.Log("Activa Ilustración Ethan semana 1 FEM");
			PlayerPrefs.SetString("EthanIllus1FEM", activado);
			Debug.Log(activado);
		}
		public void ActiveEthanIllus2FEM(string activado)
		{
			Debug.Log("Activa Ilustración Ethan semana 2 FEM");
			PlayerPrefs.SetString("EthanIllus2FEM", activado);
			Debug.Log(activado);
		}
		public void ActiveEthanIllus3FEM(string activado)
		{
			Debug.Log("Activa Ilustración Ethan semana 3 FEM");
			PlayerPrefs.SetString("EthanIllus3FEM", activado);
			Debug.Log(activado);
		}
		public void ActiveSophieIllus1FEM(string activado)
		{
			Debug.Log("Activa Ilustración Sophie semana 1 FEM");
			PlayerPrefs.SetString("SophieIllus1FEM", activado);
			Debug.Log(activado);
		}
		public void ActiveSophieIllus2FEM(string activado)
		{
			Debug.Log("Activa Ilustración Sophie semana 3 FEM");
			PlayerPrefs.SetString("SophieIllus2FEM", activado);
			Debug.Log(activado);
		}

		//Ilustraciones MAS
		public void ActiveAllanIllus1MAS(string activado)
		{
			Debug.Log("Activa Ilustración Allan semana 1 MAS");
			PlayerPrefs.SetString("AllanIllus1MAS", activado);
			Debug.Log(activado);
		}
		public void ActiveAllanIllus2MAS(string activado)
		{
			Debug.Log("Activa Ilustración Allan semana 3 MAS");
			PlayerPrefs.SetString("AllanIllus2MAS", activado);
			Debug.Log(activado);
		}
		public void ActiveEthanIllus1MAS(string activado)
		{
			Debug.Log("Activa Ilustración Ethan semana 1 MAS");
			PlayerPrefs.SetString("EthanIllus1MAS", activado);
			Debug.Log(activado);
		}
		public void ActiveEthanIllus2MAS(string activado)
		{
			Debug.Log("Activa Ilustración Ethan semana 2 MAS");
			PlayerPrefs.SetString("EthanIllus2MAS", activado);
			Debug.Log(activado);
		}
		public void ActiveEthanIllus3MAS(string activado)
		{
			Debug.Log("Activa Ilustración Ethan semana 3 MAS");
			PlayerPrefs.SetString("EthanIllus3MAS", activado);
			Debug.Log(activado);
		}
		public void ActiveSophieIllus1MAS(string activado)
		{
			Debug.Log("Activa Ilustración Sophie semana 1 MAS");
			PlayerPrefs.SetString("SophieIllus1MAS", activado);
			Debug.Log(activado);
		}
		public void ActiveSophieIllus2MAS(string activado)
		{
			Debug.Log("Activa Ilustración Sophie semana 3 MAS");
			PlayerPrefs.SetString("SophieIllus2MAS", activado);
			Debug.Log(activado);
		}


		public void SaveNextNodeToJumpBack(string nextNode)
		{
			Debug.Log("Entra en SaveNextNodeToJumpBack");
			Debug.Log(startNodeManually);
			startNodeManually = nextNode;
			Debug.Log(startNodeManually);
			PlayerPrefs.SetString("nodeSaved", nextNode);
		}

		/// <summary>changes background image</summary>
		public void DoSceneChange(string spriteName) {
			bgImage.sprite = FetchAsset<Sprite>( spriteName );
		}

		/// <summary>
		/// SetActor(actorName,spriteName,positionX,positionY,color) main
		/// function for moving / adjusting characters</summary>
		public void SetActor(string actorName, string spriteName, string positionX = "", string positionY = "", string colorHex = "" ) {

			// have to use SetSprite() because par[2] and par[3] might be
			// keywords (e.g. "left", "right")
			var newActor = SetSpriteUnity( spriteName, positionX, positionY );

			// define text label BG color
            var actorColor = Color.black;
			if (colorHex != string.Empty && ColorUtility.TryParseHtmlString( colorHex, out actorColor ) ==false ) {
				Debug.LogErrorFormat(this, "VN Manager can't parse [{0}] as an HTML color (e.g. [#FFFFFF] or certain keywords like [white])", colorHex);
			}

			// if the actor is using a sprite already, then clone any
			// persisting data, and destroy it (just to be safe)
			if ( actors.ContainsKey(actorName)) {
				// if any missing position params, assume the actor
				// position should stay the same
				var newPos = newActor.rectTransform.anchoredPosition;
				if ( positionX == string.Empty && positionY == string.Empty ) { // missing 2 params, override both x and y
					newPos = actors[actorName].rectTransform.anchoredPosition;
				} else if ( positionY == string.Empty ) { // missing 1 param, override y
					newPos.y = actors[actorName].rectTransform.anchoredPosition.y;
				}
				// if any missing color params, then assume actor color
				// should stay the same
				if ( colorHex == string.Empty ) {
					actorColor = actors[actorName].actorColor;
				}
				newActor.rectTransform.anchoredPosition = newPos;
				// clean-up
				Destroy( actors[actorName].gameObject );
				actors.Remove(actorName);
				actors.Remove(actorName);
			}

			// save actor data
			actors.Add( actorName, new VNActor( newActor, actorColor) );
		}

		///<summary> Draw(spriteName,positionX,positionY) generic function
		///for sprite drawing</summary>
		public void SetSpriteYarn(string spriteName, string positionX = "", string positionY = "") {
			SetSpriteUnity( spriteName, positionX, positionY );
		}

		public Image SetSpriteUnity(string spriteName, string positionX = "", string positionY = "") {
			
			// position sprite
			var pos = new Vector2(0.5f, 0.5f);

            if (positionX != string.Empty) {
                pos.x = ConvertCoordinates(positionX);
            }
            
            if (positionY != string.Empty) {
                pos.y = ConvertCoordinates(positionY);
            }
        
			// actually instantiate and draw sprite now
			return SetSpriteActual( spriteName, pos );
		}

		///<summary>Hide(spriteName). "spriteName" can use wildcards, e.g.
		///HideSprite(Sally*) will hide both SallyIdle and
		///Sally_Happy</summary>
		public void HideSprite(string spriteName) {
			
			var wildcard = new Wildcard(spriteName);

			// generate lists of things to remove

			var imagesToDestroy = new List<Image>();
			var actorKeysToRemove = new List<string>();
			
			foreach ( var actor in actors ) {
				if ( wildcard.IsMatch(actor.Key) || wildcard.IsMatch(actor.Value.actorImage.name) ) {
					actorKeysToRemove.Add( actor.Key );
					imagesToDestroy.Add(actor.Value.actorImage);
				}
			}

			foreach ( var sprite in sprites ) {
				if (sprite != null)
				{
					if (wildcard.IsMatch(sprite.name))
					{
						imagesToDestroy.Add(sprite);
					}
				}
			}

			// actually remove all the things now, if any

			for( int i=0; i<actorKeysToRemove.Count; i++) {
				if ( actors.ContainsKey( actorKeysToRemove[i] ) ) { // this should never be false, but let's be safe
					actors.Remove( actorKeysToRemove[i] );
				}
			}

			for ( int i=0; i<imagesToDestroy.Count; i++) {
				if ( imagesToDestroy[i] != null ) { // this should never be false, but let's be safe
					CleanDestroy<Image>(imagesToDestroy[i].gameObject);
				}
			}

		}

		/// <summary>HideAll doesn't actually use any parameters</summary>
		public void HideAllSprites() {
			HideSprite( "*" );
			actors.Clear();
			sprites.Clear();
		}

		/// <summary>Reset doesn't actually use any parameters</summary>
		public void ResetScene() {
			bgImage.sprite = null;
			HideAllSprites();
			SetFadeIn(0);
		}

		// move a sprite usage: <<Move actorOrspriteName, screenPosX=0.5,
		// screenPosY=0.5, moveTime=1.0>> screenPosX and screenPosY are
		// normalized screen coordinates (0.0 - 1.0) moveTime is the time
		// in seconds it will take to reach that position
		public void MoveSprite(string actorOrSpriteName, string screenPosX="0.5", string screenPosY="0.5", float moveTime = 1) {
			
			var image = FindActorOrSprite( actorOrSpriteName );

			// get new screen position
			Vector2 newPos = new Vector2(0.5f, 0.5f);
			if ( screenPosX != string.Empty && screenPosY != string.Empty) {
				newPos = new Vector2( ConvertCoordinates(screenPosX), ConvertCoordinates(screenPosY) );
			} else if ( screenPosX != string.Empty ) {
				newPos.x = ConvertCoordinates(screenPosX);
			}

			// actually do the moving now
			StartCoroutine( MoveCoroutine( image.GetComponent<RectTransform>(), Vector2.Scale(newPos, screenSize), moveTime) );
		}

		/// <summary>flip a sprite, or force the sprite to face a
		/// direction< Move(actorOrSpriteName, xDirection=toggle)</sprite>
		public void FlipSprite(string actorOrSpriteName, string xDirection = "") {
			
			var image = FindActorOrSprite( actorOrSpriteName );


            float direction;

            if (xDirection != string.Empty) {
                direction = Mathf.Sign(ConvertCoordinates(xDirection) - 0.5f);
            }
            else {
                direction = Mathf.Sign(image.rectTransform.localScale.x) * -1f;
            }

			image.rectTransform.localScale = new Vector3( 
                direction * Mathf.Abs(image.rectTransform.localScale.x), 
                image.rectTransform.localScale.y, 
                image.rectTransform.localScale.z 
            );
		}

		/// <summary>Shake(actorName or spriteName, strength=0.5)</summary>
		public void ShakeSprite(string actorOrSpriteName, float shakeStrength = 0.5f) {
			
			var findShakeTarget = FindActorOrSprite( actorOrSpriteName );
			if ( findShakeTarget != null ) {
				StartCoroutine( SetShake( findShakeTarget.rectTransform, shakeStrength ) );
			}
		}

		/// <summary>PlayAudio( soundName,volume,"loop" )...
		/// PlayAudio(soundName,1.0) plays soundName once at 100% volume...
		/// if third parameter was word "loop" it would loop "volume" is a
		/// number from 0.0 to 1.0 "loop" is the word "loop" (or "true"),
		/// which tells the sound to loop over and over</summary>
		public void PlayAudio(string soundName, float volume = 1, string loop = "") {
			
			var audioClip = FetchAsset<AudioClip>(soundName);
			// detect volume setting
			
            if ( volume <= 0.01f ) {
                Debug.LogWarningFormat(this, "VN Manager is playing sound {0} at very low volume ({1}), just so you know", soundName, volume );
            }
			
			// detect loop setting
			bool shouldLoop = loop.Contains("loop") || loop.Contains("true");

            

			//Si suena loop significa que es música de fondo
			if (shouldLoop) {
				MusicSet musicaAct = new MusicSet(soundName, volume, loop);
				string json = JsonUtility.ToJson(musicaAct);
				Debug.Log(json);
			PlayerPrefs.SetString("currentMusic", json);	
			}


			
			//check if its already playing that loop sound
			if (!sounds.Exists(t => t.name == soundName))
			{

				// instantiate AudioSource and configure it (don't use
				// AudioSource.PlayOneShot because we also want the option to
				// use <<StopAudio>> and interrupt it)
				var newAudioSource = Instantiate<AudioSource>(genericAudioSource, genericAudioSource.transform.parent);
				newAudioSource.name = audioClip.name;
				newAudioSource.clip = audioClip;
				newAudioSource.volume *= volume;
				newAudioSource.loop = shouldLoop;
				newAudioSource.Play();
				sounds.Add(newAudioSource);
				
				// if it doesn't loop, let's set a max lifetime for this sound
				if (shouldLoop == false)
				{
					StartCoroutine(SetDestroyTime(newAudioSource, audioClip.length));
				}
            }
            else
            {

				if (shouldLoop == false)
				{

					// instantiate AudioSource and configure it (don't use
					// AudioSource.PlayOneShot because we also want the option to
					// use <<StopAudio>> and interrupt it)
					var newAudioSource = Instantiate<AudioSource>(genericAudioSource, genericAudioSource.transform.parent);
					newAudioSource.name = audioClip.name;
					newAudioSource.clip = audioClip;
					newAudioSource.volume *= volume;				
					newAudioSource.loop = shouldLoop;
					newAudioSource.Play();
					sounds.Add(newAudioSource);
					StartCoroutine(SetDestroyTime(newAudioSource, audioClip.length));
				}
            }


			
		}

		/// <summary>stops sound playback based on sound name, whether it's
		/// looping or not</summary>
		public void StopAudio(string soundName) {
			
			// let's just do this in a sloppy way for now, and also assume
			// there's only one object like it
			AudioSource toDestroy = null;
			foreach ( var audioObject in sounds ) {
				if (audioObject.name == soundName) {
					toDestroy = audioObject;
					break;
				}
			}

			// double-check there's any audioSource to destroy tho, because
			// it might have been destroyed already
			if ( toDestroy != null ) {
				CleanDestroy<AudioSource>( toDestroy.gameObject );
			} else {
				Debug.LogWarningFormat(this, "VN Manager tried to <<StopAudio {0}>> but couldn't find any sound \"{0}\" currently playing. Double-check the name, or maybe it already stopped.", soundName );
			}
		}

		/// <summary>stops all currently playing sounds, doesn't actually
		/// take any parameters</summary>
		public void StopAudioAll() {
			var toStop = new List<AudioSource>();
			foreach (var audioSrc in sounds ) {
				toStop.Add( audioSrc );
			}
			foreach ( var stopThis in toStop ) {
				StopAudio( stopThis.name );
			}
		}

		/// <summary>typical screen fade effect, good for transitions?
		/// usage: Fade( #hexcolor, startAlpha, endAlpha, fadeTime
		/// )</summary>
		public void SetFade(string fadeColorHex, float startAlpha = 0, float endAlpha = 1, float fadeTime = 1) {
			// grab the color
			
            if (ColorUtility.TryParseHtmlString( fadeColorHex, out var fadeColor ) == false ) {
				Debug.LogErrorFormat( this, "VN Manager <<Fade>> couldn't parse [{0}] as an HTML hex color... it should look like [#FFFFFF] or [##FFCC00FF], or a small number of keywords work too, like [black] or [red]", fadeColorHex );
				fadeColor = Color.magenta;
			}

			// do the fade
			StartCoroutine( FadeCoroutine( fadeColor, startAlpha, endAlpha, fadeTime ) );
		}

		/// <summary>convenient for an easy fade in, no matter what the
		/// previous fade color or alpha was</summary>
		public void SetFadeIn(float fadeTime = 1) {
			
			// do the fade in
			StartCoroutine( FadeCoroutine( fadeBG.color, -1f, 0f, fadeTime ) );
		}

		/// <summary>pan the camera. Usage: CameraOffset(xPos, yPos,
		/// moveTime)</summary>
		/// 0, 0 is center default
		public void SetCameraOffset(string xPos = "", string yPos = "", float moveTime = 0.25f) {
			
			Vector2 newOffset = Vector2.zero;
			if ( xPos != string.Empty && yPos != string.Empty ) {
				newOffset = new Vector2( ConvertCoordinates(xPos) - 0.5f, ConvertCoordinates(xPos) - 0.5f);
			} else if ( xPos != string.Empty ) {
				newOffset.x = ConvertCoordinates(xPos) - 0.5f;
			}

			// because we're using UI overlays, there's no actual "camera"
			// exactly so we do a fake camera scroll by moving the
			// "Sprites" game object container
			var parent = genericSprite.transform.parent.GetComponent<RectTransform>();
			var newPos = Vector2.Scale( new Vector2(0.5f, 0.5f) - newOffset, screenSize );
			StartCoroutine( MoveCoroutine( parent, newPos, moveTime ) );
		}

        #endregion



        #region Utility

        public override void RunLine(LocalizedLine dialogueLine, System.Action onDialogueLineFinished)
        {
            var actorName = dialogueLine.CharacterName;

            if (string.IsNullOrEmpty(actorName) == false && actors.ContainsKey(actorName)) {
                HighlightSprite(actors[actorName].actorImage);
				nameplateBG.color = actors[actorName].actorColor;
                nameplateBG.gameObject.SetActive(true);
            } else {
                nameplateBG.gameObject.SetActive(false);
				DeHighlightSprite();
			}

            onDialogueLineFinished();
        }

		public void HighlightSprite (Image sprite) {
			StopCoroutine("DeHighlightSpriteCoroutine");
			StopCoroutine( "HighlightSpriteCoroutine" ); // use StartCoroutine(string) overload so that we can Stop and Start the coroutine (it doesn't work otherwise?)
			StartCoroutine( "HighlightSpriteCoroutine", sprite );
		}
		public void DeHighlightSprite()
		{
			StopCoroutine("HighlightSpriteCoroutine");
			StopCoroutine("DeHighlightSpriteCoroutine"); // use StartCoroutine(string) overload so that we can Stop and Start the coroutine (it doesn't work otherwise?)
			StartCoroutine("DeHighlightSpriteCoroutine");
		}
		// called by HighlightSprite
		IEnumerator HighlightSpriteCoroutine (Image highlightedSprite) {
			float t = 0f;
			// over time, gradually change sprites to be "normal" or
			// "highlighted"
			while ( t < 1f ) {
				t += Time.deltaTime / 2f;
				foreach ( var spr in sprites ) {
					if (spr != null)
					{
						Vector3 regularScalePreserveXFlip = new Vector3(Mathf.Sign(spr.transform.localScale.x), 1f, 1f);
						if (spr != highlightedSprite)
						{ // set back to normal
							spr.transform.localScale = Vector3.MoveTowards(spr.transform.localScale, regularScalePreserveXFlip, Time.deltaTime);
							spr.color = Color.Lerp(spr.color, defaultTint, Time.deltaTime * 5f);
						}
						else
						{ // a little bit bigger / brighter
							spr.transform.localScale = Vector3.MoveTowards(spr.transform.localScale, regularScalePreserveXFlip * 1.05f, Time.deltaTime);
							spr.color = Color.Lerp(spr.color, highlightTint, Time.deltaTime * 5f);
							spr.transform.SetAsLastSibling();
						}
					}
				}
				yield return 0;
			}
		}
		IEnumerator DeHighlightSpriteCoroutine()
		{
			float t = 0f;
			// over time, gradually change sprites to be "normal" or
			// "highlighted"
			while (t < 1f)
			{
				t += Time.deltaTime / 2f;
				foreach (var spr in sprites)
				{
                    if (spr != null)
                    {
						Vector3 regularScalePreserveXFlip = new Vector3(Mathf.Sign(spr.transform.localScale.x), 1f, 1f);
						// set back to normal
						spr.transform.localScale = Vector3.MoveTowards(spr.transform.localScale, regularScalePreserveXFlip, Time.deltaTime);
						spr.color = Color.Lerp(spr.color, defaultTint, Time.deltaTime * 5f);

					}


				}
				yield return 0;
			}
		}
		IEnumerator MoveCoroutine(RectTransform transform, Vector2 newAnchorPos, float moveTime ) {
			Vector2 startPos = transform.anchoredPosition;
			float t = 0f;
			while (t < 1f ) {
				t += Time.deltaTime / Mathf.Max(0.001f, moveTime); // Math.Max to prevent divide by zero error
				transform.anchoredPosition = Vector2.Lerp( startPos, newAnchorPos, t);
				yield return 0;
			}
		}

		IEnumerator FadeCoroutine(Color fadeColor, float startAlpha, float endAlpha, float fadeTime) {
			Color startColor = fadeColor;
			if ( startAlpha >= 0f ) { // if startAlpha is -1f, that means just use whatever's there
				startColor.a = startAlpha;
			} else {
				startColor = fadeBG.color;
			}
			fadeColor.a = endAlpha;
			float t = 0f;
			while ( t < 1f ) {
				t += Time.deltaTime / Mathf.Max(0.001f, fadeTime); // Math.Max to prevent divide by zero error
				fadeBG.color = Color.Lerp( startColor, fadeColor, t );
				yield return 0;
			}
		}

		Image SetSpriteActual(string spriteName, Vector2 position) {
			var newSpriteObject = Instantiate<Image>(genericSprite, genericSprite.transform.parent);
			sprites.Add(newSpriteObject);
			newSpriteObject.name = spriteName;
			newSpriteObject.sprite = FetchAsset<Sprite>( spriteName );
			newSpriteObject.SetNativeSize();
			newSpriteObject.rectTransform.anchoredPosition = Vector2.Scale( position, screenSize );
			return newSpriteObject;
		}

		// TODO: change to Image[] and grab all valid results?
		Image FindActorOrSprite(string actorOrSpriteName) {
			if ( actors.ContainsKey( actorOrSpriteName ) ) {
				return actors[actorOrSpriteName].actorImage;
			} else { // or is it a generic sprite?
				foreach ( var sprite in sprites ) { // lazy sprite name search
					if ( sprite.name == actorOrSpriteName ) {
						return sprite;
					}
				}
				Debug.LogErrorFormat(this, "VN Manager couldn't find an actor or sprite with name \"{0}\", maybe it was misspelled or the sprite was hidden / destroyed already", actorOrSpriteName );
				return null;
			}
		}

		// shakes a RectTransform (usually sprites)
		IEnumerator SetShake( RectTransform thingToShake, float shakeStrength = 0.5f ) {
			var startPos = thingToShake.anchoredPosition;
			while ( shakeStrength > 0f ) {
				shakeStrength -= Time.deltaTime;
				float shakeDistance = Mathf.Clamp( shakeStrength * 69f, 0f, 69f);
				float shakeFrequency = Mathf.Clamp( shakeStrength * 5f, 0f, 5f);
				thingToShake.anchoredPosition = startPos + shakeDistance * new Vector2( Mathf.Sin(Time.time * shakeFrequency), Mathf.Sin(Time.time * shakeFrequency + 17f) * 0.62f );
				yield return 0;
			}
			thingToShake.anchoredPosition = startPos;
		}

		// timed destroy... can't use Destroy( gameObject, timeDelay )
		// because it might get destroyed earlier via <<StopAudio>> or
		// something, and we want to remove the reference from the list too
		IEnumerator SetDestroyTime(AudioSource destroyThis, float timeDelay) {
			float timer = timeDelay;
			while ( timer > 0f ) {
				if ( destroyThis == null ) { break; } // it could've been destroyed already, so let's just make sure
				if ( destroyThis.isPlaying ) {
					timer -= Time.deltaTime;
				}
				yield return 0;
			}
			if ( destroyThis != null ) { // it could've been destroyed already, so let's just make sure
				CleanDestroy<AudioSource>( destroyThis.gameObject );
			}
		}

		// CleanDestroy also removes any references to the gameObject from
		// sprites or sounds
		void CleanDestroy<T>( GameObject destroyThis ) {
			if ( typeof(T) == typeof(AudioSource) ) {
				sounds.Remove( destroyThis.GetComponent<AudioSource>() );
			} else if ( typeof(T) == typeof(Image) ) {
				sprites.Remove( destroyThis.GetComponent<Image>() );
			}

			Destroy( destroyThis );
		}

		// utility function to convert words like "left" or "right" into
		// equivalent position numbers
		float ConvertCoordinates(string coordinate) {
			// first, is anyone named after this coordinate? we'll use the
			// X position
			if ( actors.ContainsKey(coordinate) ) {
				return actors[coordinate].rectTransform.anchoredPosition.x / screenSize.x;
			}

			// next, let's see if they used a position keyword
			var labelCoordinate = coordinate.ToLower().Replace(" ", "").Replace("_", "").Replace("-", "");
			switch ( labelCoordinate ) {
				case "leftedge":
				case "bottomedge":
				case "loweredge":
					return 0f;
				case "bottom010":
					return 0.10f;
				case "bottom015":
					return 0.15f;
				case "bottom020":
					return 0.20f;
				case "left":
				case "bottom":
				case "lower":
					return 0.25f;
				case "lowercenter":
					return 0.4f;
				case "center":
				case "middle":
					return 0.5f;
				case "right":
				case "top":
				case "upper":
					return 0.75f;
				case "rightedge":
				case "topedge":
				case "upperedge":
					return 1f;
				case "offleft":
				    return -0.33f;
				case "offright":
				    return 1.33f;
			}

			// if none of those worked, then let's try parsing it as a
			// number
            float x;
            if (float.TryParse(coordinate, out x))
            {
                return x;
            }
            else
            {
                Debug.LogErrorFormat(this, "VN Manager couldn't convert position [{0}]... it must be an alignment (left, center, right, or top, middle, bottom) or a value (like 0.42 as 42%)", coordinate);
                return -1f;
            }

        }

		// utility function to find an asset, whether it's in \Resources\
		// or manually loaded via an array
		T FetchAsset<T>( string assetName ) where T : UnityEngine.Object {
			// first, check to see if it's a manully loaded asset, with
			// manual array checks... it's messy but I can't think of a
			// better way to do this
			if ( typeof(T) == typeof(Sprite) ) {
				foreach ( var spr in loadSprites ) {
					if (spr.name == assetName) {
						return spr as T;
					}
				}
			} else if ( typeof(T) == typeof(AudioClip) ) {
				foreach ( var ac in loadAudio ) {
					if ( ac.name == assetName ) {
						return ac as T;
					}
				}
			}

			// by default, we load all Resources assets into the asset
			// arrays already, but if you don't want that, then uncomment
			// this, etc. if ( useResourcesFolders ) {var newAsset =
			// Resources.Load<T>(assetName); if ( newAsset != null )
			// {return newAsset;
			//  }
			// }

			Debug.LogErrorFormat(this, "VN Manager can't find asset [{0}]... maybe it is misspelled, or isn't imported as {1}?", assetName, typeof(T).ToString() );
			return null; // didn't find any matching asset
		}


		#endregion
    } // end class

	/// <summary>
	/// stores data for actors (sprite reference and color), can be
	/// expanded if necessary
	/// </summary>
	[System.Serializable]
	public class VNActor {
		public Image actorImage;
		public Color actorColor;
		public RectTransform rectTransform { get { return actorImage.rectTransform; } }
		public GameObject gameObject { get { return actorImage.gameObject; } }

		public VNActor( Image actorImage, Color actorColor ) {
			this.actorImage = actorImage;
			this.actorColor = actorColor;
		}
	}

	// from
	// https://www.codeproject.com/Articles/11556/Converting-Wildcards-to-Regexes
	// by Rei Miyasaka
    class Wildcard : Regex {
        public Wildcard(string pattern) : base(WildcardToRegex(pattern)) { }

        public Wildcard(string pattern, RegexOptions options) : base(WildcardToRegex(pattern), options) { }

        public static string WildcardToRegex(string pattern) {
            return "^" + Regex.Escape(pattern).Replace("\\*", ".*").Replace("\\?", ".") + "$";
        }
    }

} // end namespace
class MusicSet{
	public string soundName;
	public float volume;
	public string loop;
	public MusicSet(string soundName_, float volume_, string loop_)
    {
		soundName = soundName_;
		volume = volume_;
		loop = loop_;
    }
}