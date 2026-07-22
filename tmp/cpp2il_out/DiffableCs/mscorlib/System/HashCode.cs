namespace System;

public struct HashCode
{
	private static readonly uint s_seed; //Field offset: 0x0
	private uint _v1; //Field offset: 0x0
	private uint _v2; //Field offset: 0x4
	private uint _v3; //Field offset: 0x8
	private uint _v4; //Field offset: 0xC
	private uint _queue1; //Field offset: 0x10
	private uint _queue2; //Field offset: 0x14
	private uint _queue3; //Field offset: 0x18
	private uint _length; //Field offset: 0x1C

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Interop), Member = "GetRandomBytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(int)}, ReturnType = typeof(void))]
	private static HashCode() { }

	[CalledBy(Type = typeof(HashCode), Member = "Add", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	private void Add(int value) { }

	[CalledBy(Type = "UnityEngine.TextCore.Text.TextGenerationSettings", Member = "GetHashCode", ReturnType = typeof(int))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(bool), Member = "GetHashCode", ReturnType = typeof(int))]
	[Calls(Type = typeof(HashCode), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void Add(T value) { }

	[CalledBy(Type = "Unity.IntegerTime.RationalTime+TicksPerSecond", Member = "GetHashCode", ReturnType = typeof(int))]
	[CalledBy(Type = "Unity.Hierarchy.HierarchyFlattenedNode", Member = "GetHashCode", ReturnType = typeof(int))]
	[CalledBy(Type = "Unity.Hierarchy.HierarchyNode", Member = "GetHashCode", ReturnType = typeof(int))]
	[CalledBy(Type = "UnityEngine.PhysicsScene", Member = "GetHashCode", ReturnType = typeof(int))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(HashCode), Member = "MixEmptyState", ReturnType = typeof(uint))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public static int Combine(T1 value1, T2 value2) { }

	[CalledBy(Type = "UnityEngine.AssemblyFullName", Member = "GetHashCode", ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = "UnityEngine.AssemblyVersion", Member = "GetHashCode", ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public static int Combine(T1 value1, T2 value2, T3 value3, T4 value4) { }

	[CalledBy(Type = "UnityEngine.TextCore.Text.RenderedText", Member = "GetHashCode", ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(char), Member = "GetHashCode", ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public static int Combine(T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6) { }

	[CalledBy(Type = "UnityEngine.Rendering.SHCoefficients", Member = "GetHashCode", ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(float), Member = "GetHashCode", ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public static int Combine(T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	[Obsolete("HashCode is a mutable struct and should not be compared with other HashCodes.", True)]
	public virtual bool Equals(object obj) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Interop), Member = "GetRandomBytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(int)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	private static uint GenerateGlobalSeed() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	[Obsolete("HashCode is a mutable struct and should not be compared with other HashCodes. Use ToHashCode to retrieve the computed hash code.", True)]
	public virtual int GetHashCode() { }

	[CallerCount(Count = 0)]
	private static void Initialize(out uint v1, out uint v2, out uint v3, out uint v4) { }

	[CalledBy(Type = typeof(HashCode), Member = "Combine", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T1", "T2"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T1", "T2"}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	private static uint MixEmptyState() { }

	[CallerCount(Count = 0)]
	private static uint MixFinal(uint hash) { }

	[CallerCount(Count = 0)]
	private static uint MixState(uint v1, uint v2, uint v3, uint v4) { }

	[CallerCount(Count = 0)]
	private static uint QueueRound(uint hash, uint queuedValue) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	private static uint Rol(uint value, int count) { }

	[CallerCount(Count = 0)]
	private static uint Round(uint hash, uint input) { }

	[CalledBy(Type = "UnityEngine.TextCore.Text.TextGenerationSettings", Member = "GetHashCode", ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public int ToHashCode() { }

}

