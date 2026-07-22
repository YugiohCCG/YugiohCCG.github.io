namespace System;

public struct ValueTuple : IEquatable<ValueTuple`3<T1, T2, T3>>, IStructuralEquatable, IStructuralComparable, IComparable, IComparable<ValueTuple`3<T1, T2, T3>>, IValueTupleInternal, ITuple
{
	public T1 Item1; //Field offset: 0x0
	public T2 Item2; //Field offset: 0x0
	public T3 Item3; //Field offset: 0x0

	private override int System.Runtime.CompilerServices.ITuple.Length
	{
		[CallerCount(Count = 6)]
		[DeduplicatedMethod]
		private get { } //Length: 6
	}

	[CalledBy(Type = "UnityEngine.UIElements.DefaultEventSystem+LegacyInputProcessor", Member = "ProcessTabEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Event", "UnityEngine.EventModifiers"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.TextCore.RichTextTagParser", Member = "AddLink", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.TextCore.RichTextTagParser+TagType", typeof(string), "System.Collections.Generic.List`1<ValueTuple`3<Int32, TagType, String>>"}, ReturnType = typeof(int))]
	[CalledBy(Type = "ProfanityFilter.ProfanityFilter", Member = "GetCompleteWord", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = "System.Nullable`1<ValueTuple`3<Int32, Int32, String>>")]
	[CalledBy(Type = "ProfanityFilter.ProfanityFilter", Member = "CensorStringByProfanityList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), "System.Collections.Generic.List`1<String>", typeof(StringBuilder), typeof(StringBuilder), typeof(bool)}, ReturnType = typeof(StringBuilder))]
	[CalledBy(Type = "ProfanityFilter.ProfanityFilter", Member = "FilterSwearListForCompleteWordsOnly", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "System.Collections.Generic.List`1<String>"}, ReturnType = "System.Collections.Generic.List`1<String>")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public ValueTuple`3(T1 item1, T2 item2, T3 item3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Collections.Generic.Comparer`1<System.Boolean>), Member = "get_Default", ReturnType = typeof(System.Collections.Generic.Comparer`1<System.Boolean>))]
	[Calls(Type = typeof(System.Collections.Generic.Comparer`1<System.Byte>), Member = "get_Default", ReturnType = typeof(System.Collections.Generic.Comparer`1<System.Byte>))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	public override int CompareTo(ValueTuple<T1, T2, T3> other) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ValueTuple`3), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ValueTuple`3<T1, T2, T3>"}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 6)]
	[DeduplicatedMethod]
	public virtual bool Equals(object obj) { }

	[CalledBy(Type = typeof(ValueTuple`3), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.Collections.Generic.EqualityComparer`1<System.Byte>), Member = "CreateComparer", ReturnType = typeof(System.Collections.Generic.EqualityComparer`1<System.Byte>))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 16)]
	[DeduplicatedMethod]
	public override bool Equals(ValueTuple<T1, T2, T3> other) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(bool), Member = "GetHashCode", ReturnType = typeof(int))]
	[Calls(Type = typeof(ValueTuple), Member = "CombineHashCodes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public virtual int GetHashCode() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ValueTuple), Member = "CombineHashCodes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 7)]
	[DeduplicatedMethod]
	private int GetHashCodeCore(IEqualityComparer comparer) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 23)]
	[DeduplicatedMethod]
	private override int System.Collections.IStructuralComparable.CompareTo(object other, IComparer comparer) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 15)]
	[DeduplicatedMethod]
	private override bool System.Collections.IStructuralEquatable.Equals(object other, IEqualityComparer comparer) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	private override int System.Collections.IStructuralEquatable.GetHashCode(IEqualityComparer comparer) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 15)]
	[DeduplicatedMethod]
	private override int System.IComparable.CompareTo(object other) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	private override int System.IValueTupleInternal.GetHashCode(IEqualityComparer comparer) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(bool), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(byte), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 11)]
	[DeduplicatedMethod]
	private override string System.IValueTupleInternal.ToStringEnd() { }

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	private override int System.Runtime.CompilerServices.ITuple.get_Length() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(bool), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(byte), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 12)]
	[DeduplicatedMethod]
	public virtual string ToString() { }

}

