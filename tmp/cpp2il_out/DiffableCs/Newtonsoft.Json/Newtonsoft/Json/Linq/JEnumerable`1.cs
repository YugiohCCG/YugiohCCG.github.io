namespace Newtonsoft.Json.Linq;

[DefaultMember("Item")]
[IsReadOnly]
[Nullable(0)]
[NullableContext(1)]
public struct JEnumerable : IJEnumerable<T>, IEnumerable<T>, IEnumerable, IEquatable<JEnumerable`1<T>>
{
	[Nullable(new IL2CPP_TYPE_U1[] {0, 1})]
	public static readonly JEnumerable<T> Empty; //Field offset: 0x0
	private readonly IEnumerable<T> _enumerable; //Field offset: 0x0

	public override IJEnumerable<JToken> Item
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ValidationUtils), Member = "ArgumentNotNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		 get { } //Length: 296
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ValidationUtils), Member = "ArgumentNotNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 11)]
	[DeduplicatedMethod]
	private static JEnumerable`1() { }

	[CalledBy(Type = typeof(Extensions), Member = "AsJEnumerable", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<T>"}, ReturnType = "Newtonsoft.Json.Linq.IJEnumerable`1<T>")]
	[CalledBy(Type = typeof(JContainer), Member = "Children", ReturnType = typeof(Newtonsoft.Json.Linq.JEnumerable`1<Newtonsoft.Json.Linq.JToken>))]
	[CalledBy(Type = typeof(JObject), Member = "PropertyValues", ReturnType = typeof(Newtonsoft.Json.Linq.JEnumerable`1<Newtonsoft.Json.Linq.JToken>))]
	[CalledBy(Type = typeof(JToken), Member = "Children", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "Newtonsoft.Json.Linq.JEnumerable`1<T>")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(ValidationUtils), Member = "ArgumentNotNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public JEnumerable`1(IEnumerable<T> enumerable) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public override bool Equals(JEnumerable<T> other) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	[DeduplicatedMethod]
	[NullableContext(2)]
	public virtual bool Equals(object obj) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ValidationUtils), Member = "ArgumentNotNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public override IJEnumerable<JToken> get_Item(object key) { }

	[CalledBy(Type = "Newtonsoft.Json.Linq.Extensions+<Values>d__11`2", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(JArray), Member = "GetEnumerator", ReturnType = typeof(System.Collections.Generic.IEnumerator`1<Newtonsoft.Json.Linq.JToken>))]
	[CalledBy(Type = typeof(JToken), Member = "System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken>.GetEnumerator", ReturnType = typeof(System.Collections.Generic.IEnumerator`1<Newtonsoft.Json.Linq.JToken>))]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 9)]
	[DeduplicatedMethod]
	public override IEnumerator<T> GetEnumerator() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public virtual int GetHashCode() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

