﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.42000
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System

Namespace My.Resources
    
    'This class was auto-generated by the StronglyTypedResourceBuilder
    'class via a tool like ResGen or Visual Studio.
    'To add or remove a member, edit your .ResX file then rerun ResGen
    'with the /str option, or rebuild your VS project.
    '''<summary>
    '''  A strongly-typed resource class, for looking up localized strings, etc.
    '''</summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0"),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute()>  _
    Friend Class Language
        
        Private Shared resourceMan As Global.System.Resources.ResourceManager
        
        Private Shared resourceCulture As Global.System.Globalization.CultureInfo
        
        <Global.System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")>  _
        Friend Sub New()
            MyBase.New
        End Sub
        
        '''<summary>
        '''  Returns the cached ResourceManager instance used by this class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend Shared ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
            Get
                If Object.ReferenceEquals(resourceMan, Nothing) Then
                    Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("DotNet3dsToolkit.Language", GetType(Language).Assembly)
                    resourceMan = temp
                End If
                Return resourceMan
            End Get
        End Property
        
        '''<summary>
        '''  Overrides the current thread's CurrentUICulture property for all
        '''  resource lookups using this strongly typed resource class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend Shared Property Culture() As Global.System.Globalization.CultureInfo
            Get
                Return resourceCulture
            End Get
            Set
                resourceCulture = value
            End Set
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Complete.
        '''</summary>
        Friend Shared ReadOnly Property Complete() As String
            Get
                Return ResourceManager.GetString("Complete", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to StepCount cannot be 0..
        '''</summary>
        Friend Shared ReadOnly Property ErrorAsyncForInfiniteLoop() As String
            Get
                Return ResourceManager.GetString("ErrorAsyncForInfiniteLoop", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Neither file nor directory not found at &quot;{0}&quot;..
        '''</summary>
        Friend Shared ReadOnly Property ErrorFileDirNotFound() As String
            Get
                Return ResourceManager.GetString("ErrorFileDirNotFound", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to The file format is invalid or unsupported..
        '''</summary>
        Friend Shared ReadOnly Property ErrorInvalidFileFormat() As String
            Get
                Return ResourceManager.GetString("ErrorInvalidFileFormat", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to The given path is in an incorrect format: &quot;{0}&quot;.
        '''</summary>
        Friend Shared ReadOnly Property ErrorInvalidPathFormat() As String
            Get
                Return ResourceManager.GetString("ErrorInvalidPathFormat", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to A file required for building is missing: &quot;{0}&quot;.
        '''</summary>
        Friend Shared ReadOnly Property ErrorMissingFile() As String
            Get
                Return ResourceManager.GetString("ErrorMissingFile", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Using GenericFile.Save() requires GenericFile.OriginalFilename to not be null..
        '''</summary>
        Friend Shared ReadOnly Property ErrorNoSaveFilename() As String
            Get
                Return ResourceManager.GetString("ErrorNoSaveFilename", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to File at the given path in the ROM could not be found..
        '''</summary>
        Friend Shared ReadOnly Property ErrorROMFileNotFound() As String
            Get
                Return ResourceManager.GetString("ErrorROMFileNotFound", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Unsupported system format {0}.
        '''</summary>
        Friend Shared ReadOnly Property ErrorSystemNotSupported() As String
            Get
                Return ResourceManager.GetString("ErrorSystemNotSupported", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Attempted to write to a read-only file..
        '''</summary>
        Friend Shared ReadOnly Property ErrorWrittenReadonly() As String
            Get
                Return ResourceManager.GetString("ErrorWrittenReadonly", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Unpacking....
        '''</summary>
        Friend Shared ReadOnly Property LoadingUnpacking() As String
            Get
                Return ResourceManager.GetString("LoadingUnpacking", resourceCulture)
            End Get
        End Property
    End Class
End Namespace
