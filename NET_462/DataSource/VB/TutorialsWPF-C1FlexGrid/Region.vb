'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated from a template.
'
'     Manual changes to this file may cause unexpected behavior in your application.
'     Manual changes to this file will be overwritten if the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Collections.Generic
Imports System.Collections.ObjectModel
Imports System.ComponentModel

Partial Public Class Region
	Implements INotifyPropertyChanged
    Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged
    Protected Sub OnPropertyChanged(ByVal propertyName As String)
        RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
    End Sub

    Private _RegionID As Integer
    Public Property RegionID As Integer
        Get
            Return _RegionID
        End Get
        Set(ByVal value As Integer)
            _RegionID = value
            OnPropertyChanged("RegionID")
        End Set
    End Property

    Private _RegionDescription As String
    Public Property RegionDescription As String
        Get
            Return _RegionDescription
        End Get
        Set(ByVal value As String)
            _RegionDescription = value
            OnPropertyChanged("RegionDescription")
        End Set
    End Property


    Private _Territories As ObservableCollection(Of Territory) = New ObservableCollection(Of Territory)
    Public Overridable Property Territories As ObservableCollection(Of Territory)
        Get
            Return _Territories
        End Get
        Set(ByVal value As ObservableCollection(Of Territory))
            _Territories = value
            OnPropertyChanged("Territories")
        End Set
    End Property

End Class