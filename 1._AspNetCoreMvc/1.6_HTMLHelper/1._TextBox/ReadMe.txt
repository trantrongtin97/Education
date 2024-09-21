=========================================================================================================== Asp.Net Core Text HTML Helper

Model Binding
	- Html.TextBox : Manual handling for model binding.
	- Html.TextBoxFor: Automatically connects the form field to the property in the model

Type Safety
	- Html.TextBox : Not type-safe. Error will only be caught at runtime
	- Html.TextBoxFor: Type-safe. Error will be caught at compile time.

Automatic Binding
	- Html.TextBox : Manually specify the field name
	- Html.TextBoxFor: Automatically populates the input field with the value of the specified model property.
						The value is automatically bound back to the model property when the form is submitted

Usage in Strongly Typed Views
	- Html.TextBox : Can be used in both strongly typed and non-strongly typed
	- Html.TextBoxFor: Primarily used in strongly typed views

IntelliSense and Refactoring
	- Html.TextBox : Not support IntelliSense, Refactoring tools will not update
	- Html.TextBoxFor: Supports IntelliSense in the lambda, Automatically updated during refactoring.