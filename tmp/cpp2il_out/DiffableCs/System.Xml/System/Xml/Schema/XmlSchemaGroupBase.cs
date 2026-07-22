namespace System.Xml.Schema;

public abstract class XmlSchemaGroupBase : XmlSchemaParticle
{

	[XmlIgnore]
	public abstract XmlSchemaObjectCollection Items
	{
		 get { } //Length: 0
	}

	[CalledBy(Type = typeof(XmlSchemaSequence), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XmlSchemaParticle), Member = ".ctor", ReturnType = typeof(void))]
	protected XmlSchemaGroupBase() { }

	public abstract XmlSchemaObjectCollection get_Items() { }

	internal abstract void SetItems(XmlSchemaObjectCollection newItems) { }

}

