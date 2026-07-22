namespace Effects;

public class EffectHandler : MonoBehaviour
{
	[CompilerGenerated]
	private struct <MoveHandler>d__20 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public EffectHandler <>4__this; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
		[Calls(Type = typeof(General), Member = "GetAbsolutePosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform)}, ReturnType = typeof(Vector3))]
		[Calls(Type = typeof(General), Member = "MoveAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform), typeof(Vector3), typeof(float), typeof(bool)}, ReturnType = typeof(DG.Tweening.Core.TweenerCore`3<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>))]
		[Calls(Type = typeof(ShortcutExtensions), Member = "DOPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform), typeof(Vector3[]), typeof(float), typeof(PathType), typeof(PathMode), typeof(int), typeof(System.Nullable`1<UnityEngine.Color>)}, ReturnType = typeof(DG.Tweening.Core.TweenerCore`3<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions>))]
		[Calls(Type = typeof(AsyncExtensions), Member = "WaitForSeconds", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 4)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	public bool IsStatic; //Field offset: 0x20
	public float Duration; //Field offset: 0x24
	public bool Infinite; //Field offset: 0x28
	public RectTransform ReferenceRect; //Field offset: 0x30
	public Canvas TargetParentCanvas; //Field offset: 0x38
	public Transform Target; //Field offset: 0x40
	public Vector3 TargetPosition; //Field offset: 0x48
	public Transform Destination; //Field offset: 0x58
	public Vector3[] Path; //Field offset: 0x60
	public string PostEffect; //Field offset: 0x68
	public float SpeedMultiplier; //Field offset: 0x70
	private bool IsMoving; //Field offset: 0x74
	public float SizeMultiplier; //Field offset: 0x78
	public Action Callback; //Field offset: 0x80
	public readonly List<ParticleSystem> AllSystems; //Field offset: 0x88
	public ParticleSystemRenderer MainParticleSystemRenderer; //Field offset: 0x90
	public bool IsFullScreen; //Field offset: 0x98
	public Canvas GFXCanvas; //Field offset: 0xA0

	private bool HasLifeEnded
	{
		[CalledBy(Type = typeof(EffectHandler), Member = "Init", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(EffectHandler), Member = "Update", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
		[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy", ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		private get { } //Length: 313
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public EffectHandler() { }

	[CalledBy(Type = typeof(EffectHandler), Member = "Init", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(EffectHandler), Member = "ListAllParticles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(EffectHandler), Member = "ParseParticleData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParticleSystem), typeof(Single&)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	private void CalculateEffect() { }

	[CalledBy(Type = typeof(EffectHandler), Member = "Init", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EffectHandler), Member = "Update", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Canvas), Member = "get_renderMode", ReturnType = typeof(RenderMode))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Transform), Member = "get_position", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(General), Member = "GetAbsolutePosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Transform), Member = "set_position", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	private void DefinePosition() { }

	[CalledBy(Type = typeof(EffectHandler), Member = "Init", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EffectHandler), Member = "Update", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(EffectsManager), Member = "AddEffect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Transform), typeof(float), typeof(string), typeof(float), typeof(float), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(EffectHandler), Member = "RemoveFX", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	private void EndLife() { }

	[CalledBy(Type = typeof(EffectHandler), Member = "Init", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EffectHandler), Member = "Update", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy", ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private bool get_HasLifeEnded() { }

	[CalledBy(Type = "Effects.EffectsManager+<>c__DisplayClass54_0`1", Member = "<LoadEffect>b__0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "Create", ReturnType = typeof(AsyncVoidMethodBuilder))]
	[Calls(Type = typeof(EffectHandler), Member = "EndLife", ReturnType = typeof(void))]
	[Calls(Type = typeof(EffectHandler), Member = "get_HasLifeEnded", ReturnType = typeof(bool))]
	[Calls(Type = typeof(EffectHandler), Member = "CalculateEffect", ReturnType = typeof(void))]
	[Calls(Type = typeof(EffectHandler), Member = "DefinePosition", ReturnType = typeof(void))]
	[Calls(Type = typeof(Transform), Member = "GetChild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Transform), Member = "get_childCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(RectTransform), Member = "get_sizeDelta", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "GetComponentInChildren", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(Transform), Member = "set_localScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Transform), Member = "get_localScale", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<MoveHandler>d__20)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<MoveHandler>d__20&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 7)]
	public void Init() { }

	[CalledBy(Type = typeof(EffectHandler), Member = "ListAllParticles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EffectHandler), Member = "CalculateEffect", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Transform), Member = "get_childCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(Transform), Member = "GetChild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Transform))]
	[Calls(Type = typeof(EffectHandler), Member = "ListAllParticles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	private void ListAllParticles(Transform parent) { }

	[AsyncStateMachine(typeof(<MoveHandler>d__20))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "Create", ReturnType = typeof(AsyncVoidMethodBuilder))]
	[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<MoveHandler>d__20)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<MoveHandler>d__20&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private void MoveHandler() { }

	[CalledBy(Type = typeof(EffectHandler), Member = "CalculateEffect", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(MainModule), Member = "get_duration", ReturnType = typeof(float))]
	[Calls(Type = typeof(MainModule), Member = "set_loop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MainModule), Member = "get_simulationSpeed", ReturnType = typeof(float))]
	[Calls(Type = typeof(MainModule), Member = "set_simulationSpeed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Renderer), Member = "get_sortingOrder", ReturnType = typeof(int))]
	[Calls(Type = typeof(Renderer), Member = "set_sortingOrder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Canvas), Member = "get_sortingOrder", ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void ParseParticleData(ParticleSystem system, ref float time) { }

	[CalledBy(Type = typeof(EffectHandler), Member = "EndLife", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EffectsManager), Member = "EndEffect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(EffectsManager), Member = "UnRegisterEffect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EffectHandler), typeof(Transform)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(Helper), Member = "CloseScreen", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[])}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	public void RemoveFX() { }

	[CallerCount(Count = 5)]
	[DeduplicatedMethod]
	public void SetFinite() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EffectHandler), Member = "get_HasLifeEnded", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(EffectHandler), Member = "DefinePosition", ReturnType = typeof(void))]
	[Calls(Type = typeof(EffectHandler), Member = "EndLife", ReturnType = typeof(void))]
	[Calls(Type = typeof(Time), Member = "get_deltaTime", ReturnType = typeof(float))]
	[ContainsUnimplementedInstructions]
	private void Update() { }

}

