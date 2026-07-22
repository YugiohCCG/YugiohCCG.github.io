namespace UnityEngine.UIElements;

internal struct Spacing
{
	public float left; //Field offset: 0x0
	public float top; //Field offset: 0x4
	public float right; //Field offset: 0x8
	public float bottom; //Field offset: 0xC

	public float horizontal
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 12
	}

	public float vertical
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 13
	}

	[CallerCount(Count = 7)]
	[DeduplicatedMethod]
	public Spacing(float left, float top, float right, float bottom) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float get_horizontal() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float get_vertical() { }

	[CalledBy(Type = typeof(VisualElement), Member = "get_contentRect", ReturnType = typeof(Rect))]
	[CalledBy(Type = typeof(VisualElement), Member = "get_paddingRect", ReturnType = typeof(Rect))]
	[CallerCount(Count = 3)]
	public static Rect op_Subtraction(Rect r, Spacing a) { }

}

