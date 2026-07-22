namespace UnityEngine;

[NativeHeader("Modules/Animation/AnimatorInfo.h")]
[RequiredByNativeCode]
public struct AnimatorStateInfo
{
	private int m_Name; //Field offset: 0x0
	private int m_Path; //Field offset: 0x4
	private int m_FullPath; //Field offset: 0x8
	private float m_NormalizedTime; //Field offset: 0xC
	private float m_Length; //Field offset: 0x10
	private float m_Speed; //Field offset: 0x14
	private float m_SpeedMultiplier; //Field offset: 0x18
	private int m_Tag; //Field offset: 0x1C
	private int m_Loop; //Field offset: 0x20

	public int fullPathHash
	{
		[CallerCount(Count = 45)]
		[DeduplicatedMethod]
		 get { } //Length: 6
	}

	public float normalizedTime
	{
		[CallerCount(Count = 32)]
		[DeduplicatedMethod]
		 get { } //Length: 8
	}

	public float speed
	{
		[CallerCount(Count = 7)]
		[DeduplicatedMethod]
		 get { } //Length: 8
	}

	public float speedMultiplier
	{
		[CallerCount(Count = 63)]
		[DeduplicatedMethod]
		 get { } //Length: 8
	}

	[CallerCount(Count = 45)]
	[DeduplicatedMethod]
	public int get_fullPathHash() { }

	[CallerCount(Count = 32)]
	[DeduplicatedMethod]
	public float get_normalizedTime() { }

	[CallerCount(Count = 7)]
	[DeduplicatedMethod]
	public float get_speed() { }

	[CallerCount(Count = 63)]
	[DeduplicatedMethod]
	public float get_speedMultiplier() { }

}

