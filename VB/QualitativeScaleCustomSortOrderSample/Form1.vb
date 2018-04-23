Imports DevExpress.XtraCharts
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms

Namespace QualitativeScaleCustomSortOrderSample
    Partial Public Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        #Region "#QualitativeScaleComparer"
        Private Overloads Sub OnLoad(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            Dim diagram As XYDiagram = TryCast(chart.Diagram, XYDiagram)
            If diagram Is Nothing Then
                Return
            End If
            diagram.AxisX.QualitativeScaleComparer = New NumberComparer()
        End Sub
        #End Region ' #QualitativeScaleComparer
    End Class
End Namespace
