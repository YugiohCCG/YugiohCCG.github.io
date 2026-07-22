namespace System.Xml.Serialization;

public sealed class XmlSerializationFixupCallback : MulticastDelegate
{

	[CallerCount(Count = 60)]
	[CallsUnknownMethods(Count = 7)]
	[DeduplicatedMethod]
	public XmlSerializationFixupCallback(object object, IntPtr method) { }

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public override void Invoke(object fixup) { }

}

