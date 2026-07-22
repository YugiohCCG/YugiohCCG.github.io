namespace UnityEngine.EventSystems;

public class AxisEventData : BaseEventData
{
	[CompilerGenerated]
	private Vector2 <moveVector>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private MoveDirection <moveDir>k__BackingField; //Field offset: 0x28

	public MoveDirection moveDir
	{
		[CallerCount(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 5)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public Vector2 moveVector
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		 get { } //Length: 19
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 5
	}

	[CalledBy(Type = "UnityEngine.InputSystem.UI.ExtendedAxisEventData", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventSystem)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.InputSystem.UI.InputSystemUIInputModule", Member = "ProcessNavigation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputSystem.UI.NavigationModel&"}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public AxisEventData(EventSystem eventSystem) { }

	[CallerCount(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public MoveDirection get_moveDir() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	public Vector2 get_moveVector() { }

	[CallerCount(Count = 5)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_moveDir(MoveDirection value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_moveVector(Vector2 value) { }

}

