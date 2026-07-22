namespace UnityEngine.Rendering;

public abstract class VolumeParameter : ICloneable
{
	public const string k_DebuggerDisplay = "{m_Value} ({m_OverrideState})"; //Field offset: 0x0
	[SerializeField]
	protected bool m_OverrideState; //Field offset: 0x10

	public override bool overrideState
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(SemaphoreSlim), Member = "Release", ReturnType = typeof(int))]
		[Calls(Type = typeof(Math), Member = "ThrowAbsOverflow", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		 set { } //Length: 370
	}

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	protected VolumeParameter() { }

	public abstract object Clone() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public override bool get_overrideState() { }

	[CalledBy(Type = typeof(VolumeParameter`1), Member = "Clone", ReturnType = typeof(object))]
	[CalledBy(Type = typeof(AnimationCurveParameter), Member = "Clone", ReturnType = typeof(object))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	[DeduplicatedMethod]
	public T GetValue() { }

	internal abstract void Interp(VolumeParameter from, VolumeParameter to, float t) { }

	[CalledBy(Type = typeof(VolumeComponent), Member = "SetOverridesTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.Rendering.VolumeParameter>), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 1)]
	public static bool IsObjectParameter(Type type) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	protected private override void OnDisable() { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	protected private override void OnEnable() { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public override void Release() { }

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SemaphoreSlim), Member = "Release", ReturnType = typeof(int))]
	[Calls(Type = typeof(Math), Member = "ThrowAbsOverflow", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public override void set_overrideState(bool value) { }

	public abstract void SetValue(VolumeParameter parameter) { }

}

