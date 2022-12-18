' Developer Express Code Central Example:
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
Imports System.Windows

Namespace AvoidMapDistortion

    ''' <summary>
    ''' Interaction logic for App.xaml
    ''' </summary>
    Public Partial Class App
        Inherits Application

    End Class
End Namespace
