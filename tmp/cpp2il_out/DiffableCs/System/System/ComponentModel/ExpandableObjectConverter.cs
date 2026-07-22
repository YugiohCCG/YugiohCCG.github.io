namespace System.ComponentModel;

public class ExpandableObjectConverter : TypeConverter
{

	[CallerCount(Count = 162)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public ExpandableObjectConverter() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TypeDescriptor), Member = "GetProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Attribute[])}, ReturnType = typeof(PropertyDescriptorCollection))]
	public virtual PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object value, Attribute[] attributes) { }

	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	public virtual bool GetPropertiesSupported(ITypeDescriptorContext context) { }

}

