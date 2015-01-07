﻿using System;
using System.CodeDom;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Microsoft.CSharp;
using UncommonSense.CBreeze.DomWriter;

namespace UncommonSense.CBreeze.DomBuilder
{
    public static class CompilationExtensionMethods
    {
        public static void Compile(this Project project, string outputAssembly)
        {
            var csharpCodeProvider = new CSharpCodeProvider();
            var compilerParameters = new CompilerParameters();

            compilerParameters.ReferencedAssemblies.Add("System.dll");
            compilerParameters.GenerateExecutable = false;
            compilerParameters.OutputAssembly = outputAssembly;
            compilerParameters.GenerateInMemory = false;

            var sourceFileName = Path.GetTempFileName();
            project.WriteTo(sourceFileName);
            var compilerResults = csharpCodeProvider.CompileAssemblyFromFile(compilerParameters, sourceFileName);

            foreach (var error in compilerResults.Errors)
            {
                Console.WriteLine(error);
            }
        }
    }
}
