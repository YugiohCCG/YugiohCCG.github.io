namespace UnityEngine.UIElements;

public class VisualElementFocusChangeDirection : FocusChangeDirection
{
	private static readonly VisualElementFocusChangeDirection s_Left; //Field offset: 0x0
	private static readonly VisualElementFocusChangeDirection s_Right; //Field offset: 0x8

	public static FocusChangeDirection left
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 78
	}

	public static FocusChangeDirection right
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 79
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FocusChangeDirection), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FocusChangeDirection)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private static VisualElementFocusChangeDirection() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	protected VisualElementFocusChangeDirection(int value) { }

	[CallerCount(Count = 0)]
	public static FocusChangeDirection get_left() { }

	[CallerCount(Count = 0)]
	public static FocusChangeDirection get_right() { }

}

