namespace System.ComponentModel;

public abstract class CustomTypeDescriptor : ICustomTypeDescriptor
{
	private readonly ICustomTypeDescriptor _parent; //Field offset: 0x10

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	protected CustomTypeDescriptor() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public override AttributeCollection GetAttributes() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public override string GetClassName() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public override string GetComponentName() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	public override TypeConverter GetConverter() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public override EventDescriptor GetDefaultEvent() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public override PropertyDescriptor GetDefaultProperty() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public override object GetEditor(Type editorBaseType) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public override EventDescriptorCollection GetEvents() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public override EventDescriptorCollection GetEvents(Attribute[] attributes) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public override PropertyDescriptorCollection GetProperties() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public override PropertyDescriptorCollection GetProperties(Attribute[] attributes) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public override object GetPropertyOwner(PropertyDescriptor pd) { }

}

