namespace Newtonsoft.Json;

[AttributeUsage(1036, AllowMultiple = False)]
public sealed class JsonObjectAttribute : JsonContainerAttribute
{
	private MemberSerialization _memberSerialization; //Field offset: 0x68
	internal Nullable<MissingMemberHandling> _missingMemberHandling; //Field offset: 0x6C
	internal Nullable<Required> _itemRequired; //Field offset: 0x74
	internal Nullable<NullValueHandling> _itemNullValueHandling; //Field offset: 0x7C

	public NullValueHandling ItemNullValueHandling
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 61
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		 set { } //Length: 91
	}

	public Required ItemRequired
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 55
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		 set { } //Length: 91
	}

	public MemberSerialization MemberSerialization
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 10)]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public MissingMemberHandling MissingMemberHandling
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 55
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		 set { } //Length: 91
	}

	[CallerCount(Count = 162)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public JsonObjectAttribute() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public JsonObjectAttribute(MemberSerialization memberSerialization) { }

	[CallerCount(Count = 27)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[NullableContext(1)]
	public JsonObjectAttribute(string id) { }

	[CallerCount(Count = 0)]
	public NullValueHandling get_ItemNullValueHandling() { }

	[CallerCount(Count = 0)]
	public Required get_ItemRequired() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public MemberSerialization get_MemberSerialization() { }

	[CallerCount(Count = 0)]
	public MissingMemberHandling get_MissingMemberHandling() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void set_ItemNullValueHandling(NullValueHandling value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void set_ItemRequired(Required value) { }

	[CallerCount(Count = 10)]
	[DeduplicatedMethod]
	public void set_MemberSerialization(MemberSerialization value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void set_MissingMemberHandling(MissingMemberHandling value) { }

}

