namespace UnityEngine.UI.Extensions;

[AddComponentMenu("UI/Effects/Extensions/UIParticleSystem")]
[ExecuteInEditMode]
[RequireComponent(typeof(CanvasRenderer), typeof(ParticleSystem))]
public class UIParticleSystem : MaskableGraphic
{
	[Tooltip("Having this enabled run the system in LateUpdate rather than in Update making it faster but less precise (more clunky)")]
	public bool fixedTime; //Field offset: 0xE0
	[Tooltip("Enables 3d rotation for the particles")]
	public bool use3dRotation; //Field offset: 0xE1
	private Transform _transform; //Field offset: 0xE8
	private ParticleSystem pSystem; //Field offset: 0xF0
	private Particle[] particles; //Field offset: 0xF8
	private UIVertex[] _quad; //Field offset: 0x100
	private Vector4 imageUV; //Field offset: 0x108
	private TextureSheetAnimationModule textureSheetAnimation; //Field offset: 0x118
	private int textureSheetAnimationFrames; //Field offset: 0x120
	private Vector2 textureSheetAnimationFrameSize; //Field offset: 0x124
	private ParticleSystemRenderer pRenderer; //Field offset: 0x130
	private bool isInitialised; //Field offset: 0x138
	private Material currentMaterial; //Field offset: 0x140
	private Texture currentTexture; //Field offset: 0x148
	private MainModule mainModule; //Field offset: 0x150

	public virtual Texture mainTexture
	{
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(SemaphoreSlim), Member = "Release", ReturnType = typeof(int))]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 96
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MaskableGraphic), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public UIParticleSystem() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIParticleSystem), Member = "Initialize", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Behaviour), Member = "set_enabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	protected virtual void Awake() { }

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SemaphoreSlim), Member = "Release", ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public virtual Texture get_mainTexture() { }

	[CalledBy(Type = typeof(UIParticleSystem), Member = "Awake", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIParticleSystem), Member = "Update", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIParticleSystem), Member = "LateUpdate", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(TextureSheetAnimationModule), Member = "get_numTilesY", ReturnType = typeof(int))]
	[Calls(Type = typeof(TextureSheetAnimationModule), Member = "get_numTilesX", ReturnType = typeof(int))]
	[Calls(Type = typeof(TextureSheetAnimationModule), Member = "get_enabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(MainModule), Member = "set_scalingMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParticleSystemScalingMode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Texture2D), Member = "get_whiteTexture", ReturnType = typeof(Texture2D))]
	[Calls(Type = typeof(Material), Member = "get_mainTexture", ReturnType = typeof(Texture))]
	[Calls(Type = typeof(Material), Member = "HasProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Material), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Shader)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(Shader), Member = "Find", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Shader))]
	[Calls(Type = typeof(Dictionary`2), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Renderer), Member = "set_enabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(MainModule), Member = "set_maxParticles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MainModule), Member = "get_maxParticles", ReturnType = typeof(int))]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 11)]
	protected bool Initialize() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Application), Member = "get_isPlaying", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Time), Member = "get_unscaledDeltaTime", ReturnType = typeof(float))]
	[Calls(Type = typeof(ParticleSystem), Member = "Simulate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Material), Member = "get_mainTexture", ReturnType = typeof(Texture))]
	[Calls(Type = typeof(Material), Member = "get_shader", ReturnType = typeof(Shader))]
	[Calls(Type = typeof(UIParticleSystem), Member = "Initialize", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 3)]
	private void LateUpdate() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	protected virtual void OnDestroy() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TextureSheetAnimationModule), Member = "get_enabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Quaternion), Member = "Internal_FromEulerRad", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Quaternion))]
	[Calls(Type = typeof(Particle), Member = "get_rotation3D", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(TextureSheetAnimationModule), Member = "get_numTilesY", ReturnType = typeof(int))]
	[Calls(Type = typeof(TextureSheetAnimationModule), Member = "get_rowMode", ReturnType = typeof(ParticleSystemAnimationRowMode))]
	[Calls(Type = typeof(TextureSheetAnimationModule), Member = "get_rowIndex", ReturnType = typeof(int))]
	[Calls(Type = typeof(TextureSheetAnimationModule), Member = "get_numTilesX", ReturnType = typeof(int))]
	[Calls(Type = typeof(TextureSheetAnimationModule), Member = "get_animation", ReturnType = typeof(ParticleSystemAnimationType))]
	[Calls(Type = typeof(TextureSheetAnimationModule), Member = "get_cycleCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(AnimationCurve), Member = "Evaluate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(TextureSheetAnimationModule), Member = "get_frameOverTime", ReturnType = typeof(MinMaxCurve))]
	[Calls(Type = typeof(Particle), Member = "get_startLifetime", ReturnType = typeof(float))]
	[Calls(Type = typeof(Particle), Member = "get_remainingLifetime", ReturnType = typeof(float))]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Canvas), Member = "get_scaleFactor", ReturnType = typeof(float))]
	[Calls(Type = typeof(MainModule), Member = "get_scalingMode", ReturnType = typeof(ParticleSystemScalingMode))]
	[Calls(Type = typeof(Particle), Member = "GetCurrentSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParticleSystem)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(Particle), Member = "GetCurrentColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParticleSystem)}, ReturnType = typeof(Color32))]
	[Calls(Type = typeof(Particle), Member = "get_rotation", ReturnType = typeof(float))]
	[Calls(Type = typeof(Transform), Member = "InverseTransformPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(MainModule), Member = "get_simulationSpace", ReturnType = typeof(ParticleSystemSimulationSpace))]
	[Calls(Type = typeof(ParticleSystem), Member = "GetParticles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Particle[])}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ParticleSystem), Member = "Stop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(ParticleSystemStopBehavior)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MainModule), Member = "get_playOnAwake", ReturnType = typeof(bool))]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(VertexHelper), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(Graphic), Member = "get_canvas", ReturnType = typeof(Canvas))]
	[Calls(Type = typeof(VertexHelper), Member = "AddUIVertexQuad", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UIVertex[])}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 12)]
	[CallsUnknownMethods(Count = 10)]
	[ContainsUnimplementedInstructions]
	protected virtual void OnPopulateMesh(VertexHelper vh) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ParticleSystem), Member = "Stop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(ParticleSystemStopBehavior)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void PauseParticleEmission() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ParticleSystem), Member = "set_time", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ParticleSystem), Member = "Play", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void StartParticleEmission() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ParticleSystem), Member = "Stop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(ParticleSystemStopBehavior)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void StopParticleEmission() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Application), Member = "get_isPlaying", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Time), Member = "get_unscaledDeltaTime", ReturnType = typeof(float))]
	[Calls(Type = typeof(ParticleSystem), Member = "Simulate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Material), Member = "get_mainTexture", ReturnType = typeof(Texture))]
	[Calls(Type = typeof(Material), Member = "get_shader", ReturnType = typeof(Shader))]
	[Calls(Type = typeof(UIParticleSystem), Member = "Initialize", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	private void Update() { }

}

