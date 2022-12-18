Imports System.Collections.Generic
Imports System.Windows
Imports System.Windows.Controls

Namespace AvoidMapDistortion

    Public Partial Class MainWindow
        Inherits Window

        Public Structure WidthHeightRatio

            Public Property Name As String

            Public Property Value As Double
        End Structure

        Private defaultSideSize As Integer = 512

        Private ratiosField As List(Of WidthHeightRatio) = New List(Of WidthHeightRatio)() From {New WidthHeightRatio() With {.Name = "(Default)", .Value = 1}, New WidthHeightRatio() With {.Name = "Lambert", .Value = 3.14}, New WidthHeightRatio() With {.Name = "Behrmann", .Value = 2.36}, New WidthHeightRatio() With {.Name = "Trystan Edwards", .Value = 2.0}, New WidthHeightRatio() With {.Name = "Gall-Peters", .Value = 1.57}, New WidthHeightRatio() With {.Name = "Balthasart", .Value = 1.3}}

        Public ReadOnly Property Ratios As List(Of WidthHeightRatio)
            Get
                Return ratiosField
            End Get
        End Property

        Public Sub New()
            Me.InitializeComponent()
        End Sub

        Private Sub Window_Loaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
            DataContext = Ratios
        End Sub

        Private Sub ListBox_SelectionChanged(ByVal sender As Object, ByVal e As SelectionChangedEventArgs)
            Me.mapControl.InitialMapSize = New Size() With {.Width = defaultSideSize, .Height = CInt((defaultSideSize / CType(Me.lbRatio.SelectedValue, WidthHeightRatio).Value))}
        End Sub
    End Class
End Namespace
