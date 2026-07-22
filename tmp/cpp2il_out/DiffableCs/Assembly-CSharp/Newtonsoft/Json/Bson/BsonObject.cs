namespace Newtonsoft.Json.Bson;

internal class BsonObject : BsonToken, IEnumerable<BsonProperty>, IEnumerable
{
	private readonly List<BsonProperty> _children; //Field offset: 0x20

	public virtual BsonType Type
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 3
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public BsonObject() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 7)]
	public void Add(string name, BsonToken token) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public virtual BsonType get_Type() { }

	[CalledBy(Type = typeof(BsonBinaryWriter), Member = "WriteTokenInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BsonToken)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BsonBinaryWriter), Member = "CalculateSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BsonToken)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(BsonObject), Member = "System.Collections.IEnumerable.GetEnumerator", ReturnType = typeof(IEnumerator))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[CallsUnknownMethods(Count = 1)]
	public override IEnumerator<BsonProperty> GetEnumerator() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BsonObject), Member = "GetEnumerator", ReturnType = typeof(System.Collections.Generic.IEnumerator`1<Newtonsoft.Json.Bson.BsonProperty>))]
	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

