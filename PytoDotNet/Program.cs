using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IronPython.Runtime;
using IronPython.Hosting;

namespace PytoDotNet
{
    class Program
    {
        static void Main(string[] args)
        {
            var engine = Python.CreateEngine();

            ////Normal Execution using the python expression
            //string pythonExpression = @"print 'something'";
            //var source = engine.CreateScriptSourceFromString(pythonExpression);
            //var scope = engine.CreateScope();
            //source.Execute(scope);


            //Execution of code Inside a given file
            //var source = engine.CreateScriptSourceFromFile("../../testClass.py");
            //var compiledSource = source.Compile();
            //var scope = engine.CreateScope();
            //var pyObj = compiledSource.Execute(scope);

            //// Get the Python Class
            //object testClass = engine.Operations.Invoke(scope.GetVariable("testClass"));
            //// Invoke a method of the class
            //engine.Operations.InvokeMember(testClass, "printHello", new object[0]);
            //var valReturn = engine.Operations.InvokeMember(testClass, "sumTwo", new object[] { 1, 4 });
            //Console.WriteLine("Value returned by sumTwo function is " + valReturn);

            Console.Read();
        }
    }
}
