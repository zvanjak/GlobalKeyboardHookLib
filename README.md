# GlobalKeyboardHookLib
Simple library to make it easier to create global hooks for keyboard keys combination in C# .NET application

Functionality:

1. Registering combination of pressed keys for some functionality
	1. also reporting all existing hooks for that combination (if possible)
2. Unregistering global key hook
3. SIMPLE USE:
	1. create GlobalKeyboardHook object
	2. call on it Register with parameters:
		1. combination of keys
		2. function pointer/delegate to member function that should be called after key combination is pressed 


