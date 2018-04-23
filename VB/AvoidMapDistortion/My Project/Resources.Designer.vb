﻿' Developer Express Code Central Example:
' How to provide cylindrical equal-area projections of a map
' 
' This example illustrates how to get map equal-area projections (Lambert,
' Behrmann, Tristan Edwards, Peters, Gall orthographic and Balthasart) for the
' shapes loaded from the Shapefiles (Countries.shp, Countries.dbf).
' 
' To
' accomplish this task, create an EqualAreaProjection object and assign it to the
' VectorLayerBase.MapProjection
' (http://documentation.devexpress.com/#WPF/DevExpressXpfMapVectorLayerBase_MapProjectiontopic)
' property. Then, specify the Width/height aspect ratio for each equal area
' projection using the VectorLayerBase.InitialMapSize
' (http://documentation.devexpress.com/#WPF/DevExpressXpfMapVectorLayerBase_InitialMapSizetopic)
' property. To learn more about the equal-area projections, see Cylindrical
' equal-area projection
' (http://en.wikipedia.org/wiki/Cylindrical_equal-area_projection).
' 
' You can find sample updates and versions for different programming languages here:
' http://www.devexpress.com/example=E4253

'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.269
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Namespace My.Resources


    ''' <summary>
    '''   A strongly-typed resource class, for looking up localized strings, etc.
    ''' </summary>
    ' This class was auto-generated by the StronglyTypedResourceBuilder
    ' class via a tool like ResGen or Visual Studio.
    ' To add or remove a member, edit your .ResX file then rerun ResGen
    ' with the /str option, or rebuild your VS project.
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0"), Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(), _
    Global.Microsoft.VisualBasic.HideModuleNameAttribute()> _
    Friend Module Resources

        Private resourceMan As Global.System.Resources.ResourceManager

        Private resourceCulture As Global.System.Globalization.CultureInfo

'        internal Resources()
'        {
'        }

        ''' <summary>
        '''   Returns the cached ResourceManager instance used by this class.
        ''' </summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Friend ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
            Get
                If (resourceMan Is Nothing) Then
                    Dim temp As New Global.System.Resources.ResourceManager("Resources", GetType(Resources).Assembly)
                    resourceMan = temp
                End If
                Return resourceMan
            End Get
        End Property

        ''' <summary>
        '''   Overrides the current thread's CurrentUICulture property for all
        '''   resource lookups using this strongly typed resource class.
        ''' </summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Friend Property Culture() As Global.System.Globalization.CultureInfo
            Get
                Return resourceCulture
            End Get
            Set(ByVal value As System.Globalization.CultureInfo)
                resourceCulture = value
            End Set
        End Property
    End Module
End Namespace
