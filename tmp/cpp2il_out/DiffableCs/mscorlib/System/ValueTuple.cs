namespace System;

public struct ValueTuple : IEquatable<ValueTuple>, IStructuralEquatable, IStructuralComparable, IComparable, IComparable<ValueTuple>, IValueTupleInternal, ITuple
{

	private override int System.Runtime.CompilerServices.ITuple.Length
	{
		[CallerCount(Count = 182)]
		[DeduplicatedMethod]
		private get { } //Length: 3
	}

	[CalledBy(Type = typeof(ValueTuple`8), Member = "GetHashCode", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(ValueTuple`8), Member = "GetHashCodeCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IEqualityComparer)}, ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 8)]
	internal static int CombineHashCodes(int h1, int h2, int h3, int h4, int h5, int h6, int h7, int h8) { }

	[CalledBy(Type = typeof(ValueTuple`8), Member = "GetHashCode", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(ValueTuple`8), Member = "GetHashCodeCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IEqualityComparer)}, ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 6)]
	internal static int CombineHashCodes(int h1, int h2, int h3, int h4, int h5, int h6) { }

	[CalledBy(Type = typeof(ValueTuple`5), Member = "GetHashCode", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(ValueTuple`5), Member = "GetHashCodeCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IEqualityComparer)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(ValueTuple`8), Member = "GetHashCode", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(ValueTuple`8), Member = "GetHashCodeCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IEqualityComparer)}, ReturnType = typeof(int))]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 5)]
	internal static int CombineHashCodes(int h1, int h2, int h3, int h4, int h5) { }

	[CalledBy(Type = typeof(ValueTuple`4), Member = "GetHashCode", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(ValueTuple`4), Member = "GetHashCodeCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IEqualityComparer)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(ValueTuple`8), Member = "GetHashCode", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(ValueTuple`8), Member = "GetHashCodeCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IEqualityComparer)}, ReturnType = typeof(int))]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 4)]
	internal static int CombineHashCodes(int h1, int h2, int h3, int h4) { }

	[CalledBy(Type = typeof(ValueTuple`3), Member = "GetHashCode", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(ValueTuple`3), Member = "GetHashCodeCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IEqualityComparer)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(ValueTuple`8), Member = "GetHashCode", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(ValueTuple`8), Member = "GetHashCodeCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IEqualityComparer)}, ReturnType = typeof(int))]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 3)]
	internal static int CombineHashCodes(int h1, int h2, int h3) { }

	[CalledBy(Type = typeof(ValueTuple`2), Member = "GetHashCode", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(ValueTuple`2), Member = "GetHashCodeCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IEqualityComparer)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(ValueTuple`8), Member = "GetHashCode", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(ValueTuple`8), Member = "GetHashCodeCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IEqualityComparer)}, ReturnType = typeof(int))]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 2)]
	internal static int CombineHashCodes(int h1, int h2) { }

	[CalledBy(Type = typeof(ValueTuple`8), Member = "GetHashCode", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(ValueTuple`8), Member = "GetHashCodeCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IEqualityComparer)}, ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 7)]
	internal static int CombineHashCodes(int h1, int h2, int h3, int h4, int h5, int h6, int h7) { }

	[CallerCount(Count = 182)]
	[DeduplicatedMethod]
	public override int CompareTo(ValueTuple other) { }

	[CalledBy(Type = "UnityEngine.Rendering.RenderGraphModule.RenderGraphBuilders", Member = "SetGlobalTextureAfterPass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RenderGraphModule.TextureHandle&", typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.RenderGraphModule.RenderGraphBuilders", Member = "UnityEngine.Rendering.RenderGraphModule.IBaseRenderGraphBuilder.SetGlobalTextureAfterPass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RenderGraphModule.TextureHandle&", typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public static ValueTuple<T1, T2> Create(T1 item1, T2 item2) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public virtual bool Equals(object obj) { }

	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	public override bool Equals(ValueTuple other) { }

	[CallerCount(Count = 182)]
	[DeduplicatedMethod]
	public virtual int GetHashCode() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 8)]
	private override int System.Collections.IStructuralComparable.CompareTo(object other, IComparer comparer) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	private override bool System.Collections.IStructuralEquatable.Equals(object other, IEqualityComparer comparer) { }

	[CallerCount(Count = 182)]
	[DeduplicatedMethod]
	private override int System.Collections.IStructuralEquatable.GetHashCode(IEqualityComparer comparer) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 8)]
	private override int System.IComparable.CompareTo(object other) { }

	[CallerCount(Count = 182)]
	[DeduplicatedMethod]
	private override int System.IValueTupleInternal.GetHashCode(IEqualityComparer comparer) { }

	[CallerCount(Count = 0)]
	private override string System.IValueTupleInternal.ToStringEnd() { }

	[CallerCount(Count = 182)]
	[DeduplicatedMethod]
	private override int System.Runtime.CompilerServices.ITuple.get_Length() { }

	[CallerCount(Count = 0)]
	public virtual string ToString() { }

}

