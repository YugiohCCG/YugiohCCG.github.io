namespace UnityEngine.UI;

public struct Navigation : IEquatable<Navigation>
{
	[Flags]
	internal enum Mode
	{
		None = 0,
		Horizontal = 1,
		Vertical = 2,
		Automatic = 3,
		Explicit = 4,
	}

	[SerializeField]
	private Mode m_Mode; //Field offset: 0x0
	[SerializeField]
	[Tooltip("Enables navigation to wrap around from last to first or first to last element. Does not work for automatic grid navigation")]
	private bool m_WrapAround; //Field offset: 0x4
	[SerializeField]
	private Selectable m_SelectOnUp; //Field offset: 0x8
	[SerializeField]
	private Selectable m_SelectOnDown; //Field offset: 0x10
	[SerializeField]
	private Selectable m_SelectOnLeft; //Field offset: 0x18
	[SerializeField]
	private Selectable m_SelectOnRight; //Field offset: 0x20

	public static Navigation defaultNavigation
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 26
	}

	public Mode mode
	{
		[CallerCount(Count = 173)]
		[DeduplicatedMethod]
		 get { } //Length: 3
		[CallerCount(Count = 11)]
		[DeduplicatedMethod]
		 set { } //Length: 3
	}

	public Selectable selectOnDown
	{
		[CallerCount(Count = 106)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	public Selectable selectOnLeft
	{
		[CallerCount(Count = 31)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 9)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	public Selectable selectOnRight
	{
		[CallerCount(Count = 12)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 10)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	public Selectable selectOnUp
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	public bool wrapAround
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	public override bool Equals(Navigation other) { }

	[CallerCount(Count = 0)]
	public static Navigation get_defaultNavigation() { }

	[CallerCount(Count = 173)]
	[DeduplicatedMethod]
	public Mode get_mode() { }

	[CallerCount(Count = 106)]
	[DeduplicatedMethod]
	public Selectable get_selectOnDown() { }

	[CallerCount(Count = 31)]
	[DeduplicatedMethod]
	public Selectable get_selectOnLeft() { }

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	public Selectable get_selectOnRight() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public Selectable get_selectOnUp() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool get_wrapAround() { }

	[CallerCount(Count = 11)]
	[DeduplicatedMethod]
	public void set_mode(Mode value) { }

	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_selectOnDown(Selectable value) { }

	[CallerCount(Count = 9)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_selectOnLeft(Selectable value) { }

	[CallerCount(Count = 10)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_selectOnRight(Selectable value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_selectOnUp(Selectable value) { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public void set_wrapAround(bool value) { }

}

