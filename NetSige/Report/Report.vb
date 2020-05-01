Imports System.CodeDom.Compiler
Imports System.Reflection
Imports ControlLibrary

Public Class Report
    Public Class ReportResult
        Public Property Sucesss As Boolean
        Public Property Path As String
        Public Property Message As String
    End Class
    Public Shared Function Compile(ByVal ReportPath As String, Optional ByVal Parameters As List(Of Object) = Nothing) As ReportResult
        Dim objResult As Object = ""
        '
        ' Instantiate the VB compiler.
        '
        Dim objCodeCompiler As CodeDomProvider = CodeDomProvider.CreateProvider("VisualBasic")

        '
        ' Pass parameters into the compiler.
        '
        Dim objCompilerParameters As New CompilerParameters
        objCompilerParameters.ReferencedAssemblies.Add("System.dll")
        objCompilerParameters.ReferencedAssemblies.Add("System.XML.dll")
        objCompilerParameters.ReferencedAssemblies.Add("System.Data.dll")
        objCompilerParameters.ReferencedAssemblies.Add("System.Data.SQLite.dll")
        objCompilerParameters.ReferencedAssemblies.Add("System.Windows.Forms.dll")
        objCompilerParameters.ReferencedAssemblies.Add("Microsoft.VisualBasic.dll")
        objCompilerParameters.ReferencedAssemblies.Add("ClosedXML.dll")
        objCompilerParameters.ReferencedAssemblies.Add("ControlLibrary.dll")
        objCompilerParameters.ReferencedAssemblies.Add(Assembly.GetEntryAssembly().Location)
        objCompilerParameters.GenerateInMemory = True

        '
        ' Get te source code and compile it.
        '
        Dim strCode As String = IO.File.ReadAllText(ReportPath)
        Dim objCompileResults As CompilerResults = objCodeCompiler.CompileAssemblyFromSource(objCompilerParameters, strCode)

        '
        ' Check for compiler errors.
        '
        If objCompileResults.Errors.HasErrors Then
            Return New ReportResult With {.Sucesss = False, .Message = "O Relatório possui um erro na linha " & objCompileResults.Errors(0).Line.ToString & ", " & objCompileResults.Errors(0).ErrorText, .Path = Nothing}

        End If

        '
        ' Get a reference to the assembly.
        '
        Dim objAssembly As System.Reflection.Assembly = objCompileResults.CompiledAssembly

        '
        ' Create an instance of the DynamicCode class referenced in the source code.
        '
        Dim objTheClass As Object = objAssembly.CreateInstance("ReportScript")

        If objTheClass Is Nothing Then
            Return New ReportResult With {.Sucesss = False, .Message = "A classe ReportScrip do relatório não foi encontrada." & objCompileResults.Errors(0).Line.ToString & ", " & objCompileResults.Errors(0).ErrorText, .Path = Nothing}
        End If

        '
        ' Create a parameter to be passed into the ExecuteCode function in class DynamicCode.



        Dim objFunctionParameters() As Object
        If Parameters Is Nothing Then Parameters = New List(Of Object)
        objFunctionParameters = Parameters.ToArray

        'objFunctionParameters(0) = "1"

        '
        ' Call the DynamicCode.ExecuteCode
        '
        Try
            'objresult é o resultado da função.
            objResult = objTheClass.GetType.InvokeMember("Run", BindingFlags.InvokeMethod, Nothing, objTheClass, objFunctionParameters)
            'MessageBox.Show(objResult.ToString())
        Catch ex As Exception
            If ex.InnerException IsNot Nothing Then
                Return New ReportResult With {.Sucesss = False, .Message = "Um método do relatório retornou o erro: " & ex.InnerException.Message, .Path = Nothing}
            Else
                Return New ReportResult With {.Sucesss = False, .Message = "O método ReportScript.Run do relatório não foi encontrado.", .Path = Nothing}
            End If
        End Try
        Return objResult
    End Function

End Class
