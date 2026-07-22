namespace System.ComponentModel;

public class ComponentConverter : ReferenceConverter
{

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public ComponentConverter(Type type) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TypeDescriptor), Member = "GetProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Attribute[])}, ReturnType = typeof(PropertyDescriptorCollection))]
	public virtual PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object value, Attribute[] attributes) { }

	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	public virtual bool GetPropertiesSupported(ITypeDescriptorContext context) { }

}

