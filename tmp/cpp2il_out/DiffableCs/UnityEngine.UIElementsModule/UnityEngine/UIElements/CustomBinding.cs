namespace UnityEngine.UIElements;

[UxmlObject]
public abstract class CustomBinding : Binding
{

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	protected private override BindingResult Update(in BindingContext context) { }

}

