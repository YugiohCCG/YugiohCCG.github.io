namespace Newtonsoft.Json.Linq;

[Nullable(0)]
[NullableContext(1)]
public class JPropertyDescriptor : PropertyDescriptor
{

	public virtual Type ComponentType
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		 get { } //Length: 77
	}

	public virtual bool IsReadOnly
	{
		[CallerCount(Count = 271)]
		[DeduplicatedMethod]
		 get { } //Length: 3
	}

	protected virtual int NameHashCode
	{
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	public virtual Type PropertyType
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[DeduplicatedMethod]
		 get { } //Length: 50
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public JPropertyDescriptor(string name) { }

	[CallerCount(Count = 271)]
	[DeduplicatedMethod]
	public virtual bool CanResetValue(object component) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private static JObject CastInstance(object instance) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	public virtual Type get_ComponentType() { }

	[CallerCount(Count = 271)]
	[DeduplicatedMethod]
	public virtual bool get_IsReadOnly() { }

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	protected virtual int get_NameHashCode() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[DeduplicatedMethod]
	public virtual Type get_PropertyType() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JObject), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(JToken))]
	[CallsDeduplicatedMethods(Count = 1)]
	[NullableContext(2)]
	public virtual object GetValue(object component) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public virtual void ResetValue(object component) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JValue), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JObject), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(JToken)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[NullableContext(2)]
	public virtual void SetValue(object component, object value) { }

	[CallerCount(Count = 271)]
	[DeduplicatedMethod]
	public virtual bool ShouldSerializeValue(object component) { }

}

