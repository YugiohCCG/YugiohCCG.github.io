namespace Newtonsoft.Json.Bson;

internal class BsonArray : BsonToken, IEnumerable<BsonToken>, IEnumerable
{
	private readonly List<BsonToken> _children; //Field offset: 0x20

	public virtual BsonType Type
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 3
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public BsonArray() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public void Add(BsonToken token) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public virtual BsonType get_Type() { }

	[CalledBy(Type = typeof(BsonBinaryWriter), Member = "WriteTokenInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BsonToken)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BsonArray), Member = "System.Collections.IEnumerable.GetEnumerator", ReturnType = typeof(IEnumerator))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[CallsUnknownMethods(Count = 1)]
	public override IEnumerator<BsonToken> GetEnumerator() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BsonArray), Member = "GetEnumerator", ReturnType = typeof(System.Collections.Generic.IEnumerator`1<Newtonsoft.Json.Bson.BsonToken>))]
	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

