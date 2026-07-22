namespace System.Dynamic.Utils;

[DefaultMember("Item")]
internal sealed class CacheDict
{
	private sealed class Entry
	{
		internal readonly int _hash; //Field offset: 0x0
		internal readonly TKey _key; //Field offset: 0x0
		internal readonly TValue _value; //Field offset: 0x0

		[CallerCount(Count = 24)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		internal Entry(int hash, TKey key, TValue value) { }

	}

	private readonly int _mask; //Field offset: 0x0
	private readonly Entry<TKey, TValue>[] _entries; //Field offset: 0x0

	internal TKey Item
	{
		[CalledBy(Type = typeof(Expression), Member = "CreateLambda", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Expression), typeof(string), typeof(bool), typeof(System.Collections.ObjectModel.ReadOnlyCollection`1<System.Linq.Expressions.ParameterExpression>)}, ReturnType = typeof(LambdaExpression))]
		[CalledBy(Type = typeof(Expression), Member = "ValidateLambdaArgs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Expression&), typeof(System.Collections.ObjectModel.ReadOnlyCollection`1<System.Linq.Expressions.ParameterExpression>), typeof(string)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LightLambda), Member = "MakeRunDelegateCtor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(System.Func`2<System.Linq.Expressions.Interpreter.LightLambda, System.Delegate>))]
		[CalledBy(Type = typeof(TypeExtensions), Member = "GetParametersCached", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase)}, ReturnType = typeof(ParameterInfo[]))]
		[CallerCount(Count = 4)]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 6)]
		[DeduplicatedMethod]
		internal set { } //Length: 309
	}

	[CalledBy(Type = typeof(Expression), Member = "CreateLambda", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Expression), typeof(string), typeof(bool), typeof(System.Collections.ObjectModel.ReadOnlyCollection`1<System.Linq.Expressions.ParameterExpression>)}, ReturnType = typeof(LambdaExpression))]
	[CalledBy(Type = typeof(Expression), Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightLambda), Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TypeExtensions), Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	internal CacheDict`2(int size) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 6)]
	[DeduplicatedMethod]
	internal void Add(TKey key, TValue value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	private static int AlignSize(int size) { }

	[CalledBy(Type = typeof(Expression), Member = "CreateLambda", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Expression), typeof(string), typeof(bool), typeof(System.Collections.ObjectModel.ReadOnlyCollection`1<System.Linq.Expressions.ParameterExpression>)}, ReturnType = typeof(LambdaExpression))]
	[CalledBy(Type = typeof(Expression), Member = "ValidateLambdaArgs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Expression&), typeof(System.Collections.ObjectModel.ReadOnlyCollection`1<System.Linq.Expressions.ParameterExpression>), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightLambda), Member = "MakeRunDelegateCtor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(System.Func`2<System.Linq.Expressions.Interpreter.LightLambda, System.Delegate>))]
	[CalledBy(Type = typeof(TypeExtensions), Member = "GetParametersCached", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase)}, ReturnType = typeof(ParameterInfo[]))]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 6)]
	[DeduplicatedMethod]
	internal void set_Item(TKey key, TValue value) { }

	[CalledBy(Type = typeof(Expression), Member = "CreateLambda", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Expression), typeof(string), typeof(bool), typeof(System.Collections.ObjectModel.ReadOnlyCollection`1<System.Linq.Expressions.ParameterExpression>)}, ReturnType = typeof(LambdaExpression))]
	[CalledBy(Type = typeof(Expression), Member = "ValidateLambdaArgs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Expression&), typeof(System.Collections.ObjectModel.ReadOnlyCollection`1<System.Linq.Expressions.ParameterExpression>), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightLambda), Member = "GetRunDelegateCtor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(System.Func`2<System.Linq.Expressions.Interpreter.LightLambda, System.Delegate>))]
	[CalledBy(Type = typeof(TypeExtensions), Member = "GetParametersCached", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase)}, ReturnType = typeof(ParameterInfo[]))]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	internal bool TryGetValue(TKey key, out TValue value) { }

}

