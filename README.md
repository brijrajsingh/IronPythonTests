# IronPythonTests
A repository with projects built using Iron Python, showcasing the interoperability using IronPython. 

1. netClassLib - A C# class library project, that is referenced by the TestIronPython project
2. TestIronPython - An Iron Python project consuming the class library produced by the netClassLib
3. PytoDotNet - A C# project that references the IronPython libs, loads a given Python program using Python expressions or Python files with classes, and executes the given expression or creates an object for the given class in python and calls methods on it.