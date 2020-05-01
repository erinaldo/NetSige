

Imports System.Text
Imports Microsoft.Reporting.WinForms

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Dim dso As New DsPurchaseOrder
        'dso.DtOrder.AddDtOrderRow("Nome Teste Para A Ordem de Compra")
        'dso.DtItems.AddDtItemsRow("Item Teste 1")
        'dso.DtItems.AddDtItemsRow("Item Teste 2")
        'dso.DtItems.AddDtItemsRow("Item Teste 3")
        'dso.DtItems.AddDtItemsRow("Item Teste 4")
        'dso.DtItems.AddDtItemsRow("Item Teste 5")
        'dso.DtItems.AddDtItemsRow("Item Teste 6")
        'dso.DtItems.AddDtItemsRow("Item Teste 7")
        ''A String deve ser o mesmo nome definido no conjunto de dados do relatorio
        'Dim rds As New ReportDataSource("Order", dso.Tables(0))
        'Dim rds2 As New ReportDataSource("Items", dso.Tables(1))
        'ReportViewer1.LocalReport.DataSources.Clear()
        'ReportViewer1.LocalReport.DataSources.Add(rds)
        'ReportViewer1.LocalReport.DataSources.Add(rds2)
        'ReportViewer1.Refresh()
        'Me.ReportViewer1.RefreshReport()


        Dim DsOrder As New DsPurchaseOrder
        DsOrder.Order.AddOrderRow("", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "C:\Users\leand\source\repos\GitHub\NetSige\NetSige\bin\Debug\Logo\0t4ouvk2.hyw", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "")
        Dim rds As New ReportDataSource("Order", DsOrder.Tables(0))
        Dim rds2 As New ReportDataSource("Items", DsOrder.Tables(1))
        ReportViewer1.LocalReport.DataSources.Clear()
        ReportViewer1.LocalReport.DataSources.Add(rds)
        ReportViewer1.LocalReport.DataSources.Add(rds2)
        ReportViewer1.LocalReport.EnableExternalImages = True
        ReportViewer1.Refresh()

        Me.ReportViewer1.RefreshReport()
    End Sub


End Class