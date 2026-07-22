namespace UnityEngine;

[RequiredByNativeCode]
public struct Keyframe
{
	private float m_Time; //Field offset: 0x0
	private float m_Value; //Field offset: 0x4
	private float m_InTangent; //Field offset: 0x8
	private float m_OutTangent; //Field offset: 0xC
	private int m_WeightedMode; //Field offset: 0x10
	private float m_InWeight; //Field offset: 0x14
	private float m_OutWeight; //Field offset: 0x18

	public float inTangent
	{
		[CallerCount(Count = 47)]
		[DeduplicatedMethod]
		 get { } //Length: 85
		[CallerCount(Count = 5)]
		[DeduplicatedMethod]
		 set { } //Length: 6
	}

	public float inWeight
	{
		[CallerCount(Count = 7)]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 6
	}

	public float outTangent
	{
		[CallerCount(Count = 32)]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		 set { } //Length: 6
	}

	public float outWeight
	{
		[CallerCount(Count = 63)]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 6
	}

	public float time
	{
		[CallerCount(Count = 84)]
		[DeduplicatedMethod]
		 get { } //Length: 7
		[CallerCount(Count = 22)]
		[DeduplicatedMethod]
		 set { } //Length: 5
	}

	public float value
	{
		[CallerCount(Count = 83)]
		[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[Calls(Type = typeof(float), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
		[Calls(Type = "UnityEngine.UnityString", Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 15)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		 get { } //Length: 742
		[CallerCount(Count = 14)]
		[DeduplicatedMethod]
		 set { } //Length: 6
	}

	public WeightedMode weightedMode
	{
		[CallerCount(Count = 59)]
		[DeduplicatedMethod]
		 get { } //Length: 6
		[CallerCount(Count = 7)]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	[CalledBy(Type = "UnityEngine.Rendering.LensFlareComponentSRP", Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.LensFlareDataElementSRP", Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 10)]
	public Keyframe(float time, float value) { }

	[CalledBy(Type = "UnityEngine.Rendering.LensFlareDataElementSRP", Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.KeyframeUtility", Member = "FetchKeyFromIndexClampEdge", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeArray`1<Keyframe>", typeof(int), typeof(float), typeof(float)}, ReturnType = typeof(Keyframe))]
	[CalledBy(Type = "UnityEngine.Rendering.KeyframeUtility", Member = "EvalKeyAtTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeArray`1<Keyframe>", typeof(int), typeof(int), typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(Keyframe))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.ColorCurves", Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 14)]
	public Keyframe(float time, float value, float inTangent, float outTangent) { }

	[CallerCount(Count = 47)]
	[DeduplicatedMethod]
	public float get_inTangent() { }

	[CallerCount(Count = 7)]
	[DeduplicatedMethod]
	public float get_inWeight() { }

	[CallerCount(Count = 32)]
	[DeduplicatedMethod]
	public float get_outTangent() { }

	[CallerCount(Count = 63)]
	[DeduplicatedMethod]
	public float get_outWeight() { }

	[CallerCount(Count = 84)]
	[DeduplicatedMethod]
	public float get_time() { }

	[CallerCount(Count = 83)]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(float), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Calls(Type = "UnityEngine.UnityString", Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 15)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public float get_value() { }

	[CallerCount(Count = 59)]
	[DeduplicatedMethod]
	public WeightedMode get_weightedMode() { }

	[CallerCount(Count = 5)]
	[DeduplicatedMethod]
	public void set_inTangent(float value) { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public void set_inWeight(float value) { }

	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	public void set_outTangent(float value) { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public void set_outWeight(float value) { }

	[CallerCount(Count = 22)]
	[DeduplicatedMethod]
	public void set_time(float value) { }

	[CallerCount(Count = 14)]
	[DeduplicatedMethod]
	public void set_value(float value) { }

	[CallerCount(Count = 7)]
	[DeduplicatedMethod]
	public void set_weightedMode(WeightedMode value) { }

}

