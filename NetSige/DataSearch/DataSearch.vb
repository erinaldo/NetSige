Imports System.ComponentModel

Public Class DataSearch
    Public Class CostSharingFilter
        Inherits CostSharing.Filter
        <Browsable(False)>
        Overrides Property Status As String
        Public Overrides Function Filter(Optional SelectedRow As Integer = 0) As Boolean
            Status = "Ativo"
            Return MyBase.Filter(SelectedRow)
        End Function
    End Class
    Public Class ItemFilter
        Inherits Item.Filter
        <Browsable(False)>
        Overrides Property Status As String
        Public Overrides Function Filter(Optional SelectedRow As Integer = 0) As Boolean
            Status = "Ativo"
            Return MyBase.Filter(SelectedRow)
        End Function
    End Class
    Public Class ItemGroupFilter
        Inherits ItemGroup.Filter
        <Browsable(False)>
        Overrides Property Status As String
        Public Overrides Function Filter(Optional SelectedRow As Integer = 0) As Boolean
            Status = "Ativo"
            Return MyBase.Filter(SelectedRow)
        End Function
    End Class
    Public Class ItemUnitFilter
        Inherits ItemUnit.Filter
        <Browsable(False)>
        Overrides Property Status As String
        Public Overrides Function Filter(Optional SelectedRow As Integer = 0) As Boolean
            Status = "Ativo"
            Return MyBase.Filter(SelectedRow)
        End Function
    End Class
    Public Class PaymentTermFilter
        Inherits PaymentTerm.Filter
        <Browsable(False)>
        Overrides Property Status As String
        Public Overrides Function Filter(Optional SelectedRow As Integer = 0) As Boolean
            Status = "Ativo"
            Return MyBase.Filter(SelectedRow)
        End Function
    End Class
    Public Class PersonProviderFilter
        Inherits Person.Filter
        <Browsable(False)>
        Overrides Property Status As String
        <Browsable(False)>
        Overrides Property Category As PersonCategoryFilter
        Public Overrides Function Filter(Optional SelectedRow As Integer = 0) As Boolean
            Status = "Ativo"
            Category.Carrier = Nothing
            Category.Provider = "Sim"
            Category.Customer = Nothing
            Return MyBase.Filter(SelectedRow)
        End Function
    End Class
    Public Class PersonCustomerFilter
        Inherits Person.Filter
        <Browsable(False)>
        Overrides Property Status As String
        <Browsable(False)>
        Overrides Property Category As PersonCategoryFilter
        Public Overrides Function Filter(Optional SelectedRow As Integer = 0) As Boolean
            Status = "Ativo"
            Category.Carrier = Nothing
            Category.Provider = Nothing
            Category.Customer = "Sim"
            Return MyBase.Filter(SelectedRow)
        End Function
    End Class
    Public Class PersonCarrierFilter
        Inherits Person.Filter
        <Browsable(False)>
        Overrides Property Status As String
        <Browsable(False)>
        Overrides Property Category As PersonCategoryFilter
        Public Overrides Function Filter(Optional SelectedRow As Integer = 0) As Boolean
            Status = "Ativo"
            Category.Carrier = "Sim"
            Category.Provider = Nothing
            Category.Customer = Nothing
            Return MyBase.Filter(SelectedRow)
        End Function
    End Class
End Class
