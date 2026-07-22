namespace UnityEngine;

[RequiredByNativeCode]
public struct Resolution
{
	private int m_Width; //Field offset: 0x0
	private int m_Height; //Field offset: 0x4
	private RefreshRate m_RefreshRate; //Field offset: 0x8

	public int height
	{
		[CallerCount(Count = 57)]
		[DeduplicatedMethod]
		 get { } //Length: 6
	}

	public int width
	{
		[CallerCount(Count = 262)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	[CallerCount(Count = 57)]
	[DeduplicatedMethod]
	public int get_height() { }

	[CallerCount(Count = 262)]
	[DeduplicatedMethod]
	public int get_width() { }

	[CallerCount(Count = 0)]
	[Calls(Type = "UnityEngine.UnityString", Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 14)]
	public virtual string ToString() { }

}

