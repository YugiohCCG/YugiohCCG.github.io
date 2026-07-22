namespace Unity.IntegerTime;

[NativeHeader("Runtime/Input/RationalTime.h")]
public struct RationalTime
{
	internal struct TicksPerSecond : IEquatable<TicksPerSecond>
	{
		public static readonly TicksPerSecond DefaultTicksPerSecond; //Field offset: 0x0
		public static readonly TicksPerSecond TicksPerSecond24; //Field offset: 0x8
		public static readonly TicksPerSecond TicksPerSecond25; //Field offset: 0x10
		public static readonly TicksPerSecond TicksPerSecond30; //Field offset: 0x18
		public static readonly TicksPerSecond TicksPerSecond50; //Field offset: 0x20
		public static readonly TicksPerSecond TicksPerSecond60; //Field offset: 0x28
		public static readonly TicksPerSecond TicksPerSecond120; //Field offset: 0x30
		public static readonly TicksPerSecond TicksPerSecond2397; //Field offset: 0x38
		public static readonly TicksPerSecond TicksPerSecond2425; //Field offset: 0x40
		public static readonly TicksPerSecond TicksPerSecond2997; //Field offset: 0x48
		public static readonly TicksPerSecond TicksPerSecond5994; //Field offset: 0x50
		public static readonly TicksPerSecond TicksPerSecond11988; //Field offset: 0x58
		internal static readonly TicksPerSecond DiscreteTimeRate; //Field offset: 0x60
		[SerializeField]
		private uint m_Numerator; //Field offset: 0x0
		[SerializeField]
		private uint m_Denominator; //Field offset: 0x4

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TicksPerSecond), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(uint)}, ReturnType = typeof(void))]
		private static TicksPerSecond() { }

		[CalledBy(Type = typeof(TicksPerSecond), Member = ".cctor", ReturnType = typeof(void))]
		[CallerCount(Count = 13)]
		[ContainsUnimplementedInstructions]
		public TicksPerSecond(uint num, uint den = 1) { }

		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		[IsReadOnly]
		public override bool Equals(TicksPerSecond rhs) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[IsReadOnly]
		public virtual bool Equals(object rhs) { }

		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		private static uint Gcd(uint a, uint b) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(HashCode), Member = "Combine", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T1", "T2"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T1", "T2"}, ReturnType = typeof(int))]
		[IsReadOnly]
		public virtual int GetHashCode() { }

		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		private static void Simplify(ref uint num, ref uint den) { }

	}

	[SerializeField]
	private long m_Count; //Field offset: 0x0
	[SerializeField]
	private TicksPerSecond m_TicksPerSecond; //Field offset: 0x8

	public long Count
	{
		[CallerCount(Count = 138)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	[CallerCount(Count = 138)]
	[DeduplicatedMethod]
	public long get_Count() { }

	[CalledBy(Type = "UnityEngine.InputForUI.InputEventPartialProvider", Member = "RequestCurrentState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputForUI.Event+Type"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.InputSystem.Plugins.InputForUI.InputSystemProvider", Member = "OnScrollWheelPerformed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputSystem.InputAction+CallbackContext"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.InputSystem.Plugins.InputForUI.InputSystemProvider", Member = "OnClickPerformed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputSystem.InputAction+CallbackContext", "UnityEngine.InputForUI.EventSource", "UnityEngine.InputForUI.PointerEvent+Button"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.InputSystem.Plugins.InputForUI.InputSystemProvider", Member = "OnCancelPerformed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputSystem.InputAction+CallbackContext"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.InputSystem.Plugins.InputForUI.InputSystemProvider", Member = "OnSubmitPerformed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputSystem.InputAction+CallbackContext"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.InputSystem.Plugins.InputForUI.InputSystemProvider", Member = "OnPointerPerformed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputSystem.InputAction+CallbackContext"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.InputSystem.Plugins.InputForUI.InputSystemProvider", Member = "RequestCurrentState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputForUI.Event+Type"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.InputSystem.Plugins.InputForUI.InputSystemProvider", Member = "Update", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.InputForUI.InputManagerProvider", Member = "Update", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.InputForUI.InputEventPartialProvider", Member = "ToCommandEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Event&"}, ReturnType = "UnityEngine.InputForUI.CommandEvent")]
	[CalledBy(Type = "UnityEngine.InputForUI.InputEventPartialProvider", Member = "SendNextOrPreviousNavigationEventOnTabKeyDownEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Event&"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.InputForUI.InputEventPartialProvider", Member = "ToTextInputEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Event&"}, ReturnType = "UnityEngine.InputForUI.TextInputEvent")]
	[CalledBy(Type = "UnityEngine.InputForUI.InputEventPartialProvider", Member = "ToKeyEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Event&"}, ReturnType = "UnityEngine.InputForUI.KeyEvent")]
	[CalledBy(Type = "UnityEngine.InputForUI.InputEventPartialProvider", Member = "GetTimestamp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Event&"}, ReturnType = typeof(DiscreteTime))]
	[CalledBy(Type = "UnityEngine.InputSystem.Plugins.InputForUI.InputSystemProvider", Member = "get_m_CurrentTime", ReturnType = typeof(DiscreteTime))]
	[CallerCount(Count = 20)]
	[CallsUnknownMethods(Count = 2)]
	public static DiscreteTime op_Explicit(RationalTime t) { }

}

