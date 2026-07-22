namespace Newtonsoft.Json;

[AttributeUsage(1028, AllowMultiple = False)]
public sealed class JsonArrayAttribute : JsonContainerAttribute
{
	private bool _allowNullItems; //Field offset: 0x68

	public bool AllowNullItems
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	[CallerCount(Count = 162)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public JsonArrayAttribute() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public JsonArrayAttribute(bool allowNullItems) { }

	[CallerCount(Count = 27)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[NullableContext(1)]
	public JsonArrayAttribute(string id) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool get_AllowNullItems() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_AllowNullItems(bool value) { }

}

