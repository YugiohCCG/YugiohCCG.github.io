namespace Effects;

public class EdgeGlow : MonoBehaviour
{
	[CompilerGenerated]
	private struct <Awake>d__35 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public EdgeGlow <>4__this; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(EdgeGlow), Member = "GetComponentFrom", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParticleSystem)}, ReturnType = "T")]
		[Calls(Type = typeof(AsyncExtensions), Member = "WaitUntil", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Func`1<System.Boolean>)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Canvas), Member = "get_sortingOrder", ReturnType = typeof(int))]
		[Calls(Type = typeof(Renderer), Member = "set_sortingOrder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
		[Calls(Type = typeof(Transform), Member = "get_rotation", ReturnType = typeof(Quaternion))]
		[Calls(Type = typeof(Transform), Member = "set_rotation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 9)]
		[CallsUnknownMethods(Count = 36)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	public static readonly Vector3 Size; //Field offset: 0x0
	public ParticleSystem GlowSystemActive; //Field offset: 0x20
	public ParticleSystem GlowSystemActiveInner; //Field offset: 0x28
	public ParticleSystem GlowSystemInactive; //Field offset: 0x30
	public ParticleSystem GlowSystemInactiveInner; //Field offset: 0x38
	public ParticleSystem InactiveOuterGlow; //Field offset: 0x40
	public ParticleSystem ActiveOuterGlow; //Field offset: 0x48
	private ParticleSystemRenderer GlowSystemActiveRenderer; //Field offset: 0x50
	private ParticleSystemRenderer GlowSystemInactiveRenderer; //Field offset: 0x58
	private ParticleSystemRenderer GlowSystemActiveInnerRenderer; //Field offset: 0x60
	private ParticleSystemRenderer GlowSystemInactiveInnerRenderer; //Field offset: 0x68
	private ParticleSystemRenderer InactiveOuterGlowRenderer; //Field offset: 0x70
	private ParticleSystemRenderer ActiveOuterGlowRenderer; //Field offset: 0x78
	private int _sortOrder; //Field offset: 0x80
	[CompilerGenerated]
	private bool <IsActive>k__BackingField; //Field offset: 0x84
	[CompilerGenerated]
	private bool <IsSelectionActive>k__BackingField; //Field offset: 0x85
	public FieldSlot SlotTarget; //Field offset: 0x88
	public Template CardTarget; //Field offset: 0x90
	public EffectHandler EffectSystem; //Field offset: 0x98

	public private bool IsActive
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 11)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 7
	}

	public bool IsCard
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		 get { } //Length: 83
	}

	public bool IsFieldSlot
	{
		[CalledBy(Type = typeof(CardListDisplay), Member = "ResetCardState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Template), "Scenes.Battle.CardListDisplay+CardState"}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(HoverZoom), Member = "SetZoomState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(EdgeGlow), Member = "CalculateSizing", ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		 get { } //Length: 83
	}

	public private bool IsSelectionActive
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 7
	}

	public int SortOrder
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 7
		[CalledBy(Type = "Scenes.Battle.CardListDisplay+<AddCard>d__40", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(CardListDisplay), Member = "ResetCardState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Template), "Scenes.Battle.CardListDisplay+CardState"}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(HoverZoom), Member = "SetZoomState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(Renderer), Member = "set_sortingOrder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 161
	}

	[CallerCount(Count = 0)]
	private static EdgeGlow() { }

	[CallerCount(Count = 36)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public EdgeGlow() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	private bool <Awake>b__35_0() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	private bool <Awake>b__35_1() { }

	[AsyncStateMachine(typeof(<Awake>d__35))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "Create", ReturnType = typeof(AsyncVoidMethodBuilder))]
	[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<Awake>d__35)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<Awake>d__35&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private void Awake() { }

	[CalledBy(Type = typeof(EdgeGlow), Member = "Update", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy", ReturnType = typeof(bool))]
	[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(EdgeGlow), Member = "get_IsFieldSlot", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Transform), Member = "get_lossyScale", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Transform), Member = "set_localScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ParticleSystem), Member = "get_isPlaying", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ParticleSystem), Member = "Play", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public void CalculateSizing() { }

	[CallerCount(Count = 11)]
	[DeduplicatedMethod]
	public void ChangeState(bool state) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	public static void ChangeState(EdgeGlow instance, object state) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public bool get_IsActive() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	public bool get_IsCard() { }

	[CalledBy(Type = typeof(CardListDisplay), Member = "ResetCardState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Template), "Scenes.Battle.CardListDisplay+CardState"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HoverZoom), Member = "SetZoomState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EdgeGlow), Member = "CalculateSizing", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	public bool get_IsFieldSlot() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	public bool get_IsSelectionActive() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public int get_SortOrder() { }

	[CalledBy(Type = typeof(<Awake>d__35), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	private T GetComponentFrom(ParticleSystem ps) { }

	[CallerCount(Count = 11)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_IsActive(bool value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_IsSelectionActive(bool value) { }

	[CalledBy(Type = "Scenes.Battle.CardListDisplay+<AddCard>d__40", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CardListDisplay), Member = "ResetCardState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Template), "Scenes.Battle.CardListDisplay+CardState"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HoverZoom), Member = "SetZoomState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Renderer), Member = "set_sortingOrder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void set_SortOrder(int value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EdgeGlow), Member = "CalculateSizing", ReturnType = typeof(void))]
	private void Update() { }

}

