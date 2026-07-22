namespace Spine;

public class Event
{
	internal readonly EventData data; //Field offset: 0x10
	internal readonly float time; //Field offset: 0x18
	internal int intValue; //Field offset: 0x1C
	internal float floatValue; //Field offset: 0x20
	internal string stringValue; //Field offset: 0x28
	internal float volume; //Field offset: 0x30
	internal float balance; //Field offset: 0x34

	public float Balance
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 6
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 6
	}

	public EventData Data
	{
		[CallerCount(Count = 106)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public float Float
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 6
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 6
	}

	public int Int
	{
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public string String
	{
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	public float Time
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 6
	}

	public float Volume
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 6
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		 set { } //Length: 6
	}

	[CalledBy(Type = typeof(SkeletonBinary), Member = "ReadAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(SkeletonInput), typeof(SkeletonData)}, ReturnType = typeof(Animation))]
	[CalledBy(Type = typeof(SkeletonJson), Member = "ReadAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.Dictionary`2<System.String, System.Object>), typeof(string), typeof(SkeletonData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	public Event(float time, EventData data) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float get_Balance() { }

	[CallerCount(Count = 106)]
	[DeduplicatedMethod]
	public EventData get_Data() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float get_Float() { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public int get_Int() { }

	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	public string get_String() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float get_Time() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float get_Volume() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_Balance(float value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_Float(float value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_Int(int value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_String(string value) { }

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public void set_Volume(float value) { }

	[CallerCount(Count = 6)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public virtual string ToString() { }

}

