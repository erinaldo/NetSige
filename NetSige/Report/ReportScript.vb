'GR=Compras
'NM=Pedido de Compra
'PR=Número
'DT=Integer
'CM=O número do pedido de compra a ser gerado.
'Public Class ReportScript
'    Public Function Run(ParamArray Parameters() As Object) As Object
'        Dim WorkSheet As ClosedXML.Excel.IXLWorksheet
'        Dim OrderTable As New System.Data.DataTable
'        Dim ItemsTable As New System.Data.DataTable
'        Dim SbOrder As System.Text.StringBuilder
'        Dim SbItems As System.Text.StringBuilder
'        Dim SbTextHelper As New System.Text.StringBuilder
'        Dim CurrentRow As Integer = 13
'        Dim LastRow As Integer
'        Dim ItemQuantity As System.Decimal
'        Dim ItemPrice As System.Decimal
'        Dim ItemIPI As System.Decimal
'        Dim ItemDiscount As System.Decimal
'        Dim TotalItem As System.Decimal
'        Dim TotalIPI As System.Decimal
'        Dim TotalDiscount As System.Decimal
'        Dim CarrierPrice As System.Decimal
'        Dim OrderDiscount As System.Decimal
'        Dim Expenses As System.Decimal
'        Dim ICMSST As System.Decimal
'        Dim Total As System.Decimal
'        Dim Logo As ClosedXML.Excel.Drawings.IXLPicture
'        SbOrder = New System.Text.StringBuilder
'        Dim TempFilePath As String
'        Dim SfdSave As System.Windows.Forms.SaveFileDialog
'        With SbOrder
'            .AppendLine("SELECT")
'            .AppendLine("    PURCHASEORDER.ID POID,")
'            .AppendLine("    'NÃO APROVADO' PAPPROVED,")
'            .AppendLine("    PURCHASEORDER.CREATIONDATE POCREATIONDATE,")
'            .AppendLine("    CASE")
'            .AppendLine("        WHEN PURCHASEORDER.CARRIERTYPEID = 0 THEN")
'            .AppendLine("            'SEM FRETE'")
'            .AppendLine("        WHEN PURCHASEORDER.CARRIERTYPEID = 1 THEN")
'            .AppendLine("            'CIF'")
'            .AppendLine("       WHEN PURCHASEORDER.CARRIERTYPEID = 2 THEN")
'            .AppendLine("            'FOB'")
'            .AppendLine("        WHEN PURCHASEORDER.CARRIERTYPEID = 3 THEN")
'            .AppendLine("            'TERC'")
'            .AppendLine("    END PCARRIERTYPE,")
'            .AppendLine("    CASE")
'            .AppendLine("        WHEN JULIANDAY(PURCHASEORDER.FINALDELIVERY) - JULIANDAY(PURCHASEORDER.INITIALDELIVERY) <= 0 THEN")
'            .AppendLine("             'IMEDIATO'")
'            .AppendLine("        WHEN JULIANDAY(PURCHASEORDER.FINALDELIVERY) - JULIANDAY(PURCHASEORDER.INITIALDELIVERY) = 1 THEN")
'            .AppendLine("             '1 DIA'")
'            .AppendLine("         ELSE")
'            .AppendLine("             CAST(CAST(JULIANDAY(PURCHASEORDER.FINALDELIVERY) - JULIANDAY(PURCHASEORDER.INITIALDELIVERY) AS INTEGER) AS TEXT) || ' DIAS'")
'            .AppendLine("    END DELIVERYTIME,")
'            .AppendLine("    PURCHASEORDER.EXTERNALNOTE,")
'            .AppendLine("    PURCHASEORDER.CARRIERPRICE,")
'            .AppendLine("    PURCHASEORDER.DISCOUNT,")
'            .AppendLine("    PURCHASEORDER.EXPENSE,")
'            .AppendLine("    PURCHASEORDER.ICMSST,")
'            .AppendLine("    PURCHASEORDER.PHONE PPHONE,")
'            .AppendLine("    PURCHASEORDER.EMAIL PEMAIL,")
'            .AppendLine("    USER.NAME UNAME,  ")
'            .AppendLine("    '(62) 3924-6694' CSPHONE1,")
'            .AppendLine("    '(62) 9 9171-7968' CSPHONE2,")
'            .AppendLine("    'compras@reicolservice.com.br' CSEMAIL,")
'            .AppendLine("    COSTSHARING.NAME CSNAME,")
'            .AppendLine("    COSTSHARING.DOCUMENT1 CSDOC1,")
'            .AppendLine("    COSTSHARING.DOCUMENT2 CSDOC2,")
'            .AppendLine("    COSTSHARING.DOCUMENT3 CSDOC3,")
'            .AppendLine("    COSTSHARING.ADDRESS CSADDRESS,")
'            .AppendLine("    COSTSHARING.NUMBER CSNUMBER,")
'            .AppendLine("    COSTSHARING.COMPLEMENT CSCOMP,")
'            .AppendLine("    COSTSHARING.DISTRICT CSDISTRICT,")
'            .AppendLine("    COSTSHARING.CITY CSCITY,")
'            .AppendLine("    COSTSHARING.STATE CSSTATE,")
'            .AppendLine("    COSTSHARING.ZIPCODE CSZIPCODE,")
'            .AppendLine("    COSTSHARING.LOGOPATH CSLOGOPATH,")
'            .AppendLine("    COSTSHARINGLOCAL.ADDRESS CSLADDRESS,")
'            .AppendLine("    COSTSHARINGLOCAL.NUMBER CSLNUMBER,")
'            .AppendLine("    COSTSHARINGLOCAL.COMPLEMENT CSLCOMP,")
'            .AppendLine("    COSTSHARINGLOCAL.DISTRICT CSLDISTRICT,")
'            .AppendLine("    COSTSHARINGLOCAL.CITY CSLCITY,")
'            .AppendLine("    COSTSHARINGLOCAL.STATE CSLSTATE,")
'            .AppendLine("    COSTSHARINGLOCAL.ZIPCODE CSLZIPCODE,")
'            .AppendLine("    PROVIDER.NAME PNAME,")
'            .AppendLine("    PROVIDER.DOCUMENT1 PDOC1,")
'            .AppendLine("    PROVIDER.DOCUMENT2 PDOC2,")
'            .AppendLine("    PROVIDER.DOCUMENT3 PDOC3,")
'            .AppendLine("    PROVIDER.ADDRESS PADDRESS,")
'            .AppendLine("    PROVIDER.NUMBER PNUMBER,")
'            .AppendLine("    PROVIDER.COMPLEMENT PCOMP,")
'            .AppendLine("    PROVIDER.DISTRICT PDISTRICT,")
'            .AppendLine("    PROVIDER.CITY PCITY,")
'            .AppendLine("    PROVIDER.STATE PSTATE,")
'            .AppendLine("    PROVIDER.ZIPCODE PZIPCODE,")
'            .AppendLine("    CARRIER.NAME CNAME,")
'            .AppendLine("    CARRIER.DOCUMENT1 CDOC1,")
'            .AppendLine("    CASE")
'            .AppendLine("        WHEN COUNT(CARRIERCONTACT.ID) > 0 THEN")
'            .AppendLine("            CASE")
'            .AppendLine("                WHEN CARRIER.DEFAULTCONTACTID > 0 THEN")
'            .AppendLine("                    (SELECT PERSONCONTACT.PHONE1 FROM PERSONCONTACT WHERE PERSONCONTACT.ID = CARRIER.DEFAULTCONTACTID)")
'            .AppendLine("                ELSE")
'            .AppendLine("                     (SELECT PERSONCONTACT.PHONE1 FROM PERSONCONTACT WHERE PERSONCONTACT.PERSONID = CARRIER.ID LIMIT 1)")
'            .AppendLine("            END")
'            .AppendLine("    END CPHONE,")
'            .AppendLine("    CASE")
'            .AppendLine("        WHEN COUNT(CARRIERCONTACT.ID) > 0 THEN")
'            .AppendLine("            CASE")
'            .AppendLine("                WHEN CARRIER.DEFAULTCONTACTID > 0 THEN")
'            .AppendLine("                    (SELECT PERSONCONTACT.EMAIL1 FROM PERSONCONTACT WHERE PERSONCONTACT.ID = CARRIER.DEFAULTCONTACTID)")
'            .AppendLine("                ELSE")
'            .AppendLine("                     (SELECT PERSONCONTACT.EMAIL1 FROM PERSONCONTACT WHERE PERSONCONTACT.PERSONID = CARRIER.ID LIMIT 1)")
'            .AppendLine("            END")
'            .AppendLine("    END CEMAIL,")
'            .AppendLine("    PAYMENTTERM.NAME PTNAME")
'            .AppendLine("FROM PURCHASEORDER")
'            .AppendLine("LEFT JOIN USER ON USER.ID = PURCHASEORDER.USERID")
'            .AppendLine("LEFT JOIN COSTSHARING ON COSTSHARING.ID = PURCHASEORDER.COSTSHARINGID")
'            .AppendLine("LEFT JOIN COSTSHARINGLOCAL ON COSTSHARINGLOCAL.ID = PURCHASEORDER.COSTSHARINGLOCALID")
'            .AppendLine("LEFT JOIN PERSON PROVIDER ON PROVIDER.ID = PURCHASEORDER.PERSONID")
'            .AppendLine("LEFT JOIN PERSON CARRIER ON CARRIER.ID = PURCHASEORDER.CARRIERID")
'            .AppendLine("LEFT JOIN PERSONCONTACT CARRIERCONTACT ON CARRIERCONTACT.PERSONID = PURCHASEORDER.CARRIERID")
'            .AppendLine("LEFT JOIN PAYMENTTERM ON PAYMENTTERM.ID = PURCHASEORDER.PAYMENTTERMID")
'            .AppendLine("WHERE PURCHASEORDER.ID = @ORDERID;")
'        End With
'        SbItems = New System.Text.StringBuilder
'        With SbItems
'            .AppendLine("SELECT")
'            .AppendLine("    PURCHASEORDERITEM.QUANTITY,")
'            .AppendLine("    ITEMUNIT.INITIALS,")
'            .AppendLine("    ITEM.INTERNALCODE,")
'            .AppendLine("    ITEM.NAME,")
'            .AppendLine("    PURCHASEORDERITEM.PRICE,")
'            .AppendLine("    PURCHASEORDERITEM.DISCOUNT,")
'            .AppendLine("    PURCHASEORDERITEM.COMPLEMENT,")
'            .AppendLine("    PURCHASEORDERITEM.IPI,")
'            .AppendLine("    PURCHASEORDERITEM.ICMS")
'            .AppendLine("FROM PURCHASEORDERITEM")
'            .AppendLine("LEFT JOIN ITEMUNIT ON ITEMUNIT.ID = PURCHASEORDERITEM.ITEMUNITID")
'            .AppendLine("LEFT JOIN ITEM ON ITEM.ID = PURCHASEORDERITEM.ITEMID")
'            .AppendLine("WHERE PURCHASEORDERITEM.PURCHASEORDERID = @ORDERID;")
'        End With
'        'Try
'        Using Con As New System.Data.SQLite.SQLiteConnection(NetSige.Common.ConnectionString)
'            Con.Open()
'            Using Tran As System.Data.SQLite.SQLiteTransaction = Con.BeginTransaction(System.Data.IsolationLevel.Serializable)
'                Using ComOrder As New System.Data.SQLite.SQLiteCommand(SbOrder.ToString, Con)
'                    ComOrder.Transaction = Tran
'                    ComOrder.Parameters.AddWithValue("@ORDERID", Parameters(0))
'                    Using Adp As New System.Data.SQLite.SQLiteDataAdapter(ComOrder)
'                        Adp.Fill(OrderTable)
'                    End Using
'                End Using
'                Using ComItems As New System.Data.SQLite.SQLiteCommand(SbItems.ToString, Con)
'                    ComItems.Transaction = Tran
'                    ComItems.Parameters.AddWithValue("@ORDERID", Parameters(0))
'                    Using Adp As New System.Data.SQLite.SQLiteDataAdapter(ComItems)
'                        Adp.Fill(ItemsTable)
'                    End Using
'                End Using
'                Tran.Commit()
'            End Using
'        End Using
'        'Catch ex As Exception
'        '    Return New NetSige.Report.ReportResult With {.Sucesss = False, .Message = "Não foi possível carregar as informações necessarias para a composição do relatório", .Path = Nothing}
'        'End Try

'        If OrderTable.Rows.Count > 0 And ItemsTable.Rows.Count > 0 Then
'            Using WorkBook As New ClosedXML.Excel.XLWorkbook
'                WorkSheet = WorkBook.Worksheets.Add("PDC " & OrderTable.Rows(0).Item("POID").ToString.PadLeft(6, "0"))
'                With WorkSheet
'                    .Style.Alignment.SetVertical(ClosedXML.Excel.XLAlignmentVerticalValues.Center)
'                    .Rows.Height = 17
'                    .Style.Font.FontName = "Century Gothic"
'                    .SetShowGridLines(False)
'                End With
'                If System.IO.File.Exists(OrderTable.Rows(0).Item("CSLOGOPATH").ToString) Then
'                    Logo = WorkSheet.AddPicture(OrderTable.Rows(0).Item("CSLOGOPATH").ToString).MoveTo(1, 5).WithSize(205, 77)
'                End If
'                With WorkSheet.Range("D1")
'                    .Value = OrderTable.Rows(0).Item("CSNAME").ToString
'                    .Style.Font.Bold = True
'                    .Style.Font.FontSize = 12
'                End With
'                With WorkSheet.Range("O1")
'                    .Value = "EMISSÃO: " & CDate(OrderTable.Rows(0).Item("POCREATIONDATE").ToString).ToString("dd/MM/yyyy")
'                    .Style.Font.FontSize = 9
'                    .Style.Alignment.Horizontal = ClosedXML.Excel.XLAlignmentHorizontalValues.Right
'                End With
'                With SbTextHelper
'                    .Clear()
'                    .Append(String.Format("CNPJ: " & OrderTable.Rows(0).Item("CSDOC1").ToString))
'                    .Append(If(OrderTable.Rows(0).Item("CSDOC2").ToString <> Nothing, " IE: " & OrderTable.Rows(0).Item("CSDOC2").ToString, Nothing))
'                    .Append(If(OrderTable.Rows(0).Item("CSDOC3").ToString <> Nothing, " IM: " & OrderTable.Rows(0).Item("CSDOC3").ToString, Nothing))
'                End With
'                With WorkSheet.Range("D2")
'                    .Value = SbTextHelper.ToString
'                    .Style.Font.FontSize = 9
'                End With
'                With WorkSheet.Cell("O2")
'                    .Value = "SITUAÇÃO: " & OrderTable.Rows(0).Item("PAPPROVED").ToString
'                    .Style.Font.FontSize = 9
'                    .RichText.Substring(10, OrderTable.Rows(0).Item("PAPPROVED").ToString.Length).SetFontColor(If(OrderTable.Rows(0).Item("PAPPROVED").ToString = "APROVADO", ClosedXML.Excel.XLColor.DarkBlue, ClosedXML.Excel.XLColor.DarkRed))
'                    .RichText.Substring(10, OrderTable.Rows(0).Item("PAPPROVED").ToString.Length).SetBold(True)
'                    .Style.Alignment.Horizontal = ClosedXML.Excel.XLAlignmentHorizontalValues.Right
'                End With
'                With SbTextHelper
'                    .Clear()
'                    .AppendFormat("{0} ", If(OrderTable.Rows(0).Item("CSNUMBER").ToString <> Nothing, OrderTable.Rows(0).Item("CSADDRESS").ToString, OrderTable.Rows(0).Item("CSADDRESS").ToString & ","))
'                    .AppendFormat("{0} ", If(OrderTable.Rows(0).Item("CSNUMBER").ToString <> Nothing, "Nº " & OrderTable.Rows(0).Item("CSNUMBER").ToString & ",", Nothing))
'                    .AppendFormat("{0} ", If(OrderTable.Rows(0).Item("CSCOMP").ToString <> Nothing, OrderTable.Rows(0).Item("CSCOMP").ToString & ", ", Nothing))
'                    .AppendFormat("{0} ", OrderTable.Rows(0).Item("CSDISTRICT").ToString & ", ")
'                    .AppendFormat("{0} ", OrderTable.Rows(0).Item("CSCITY").ToString & "-")
'                    .AppendFormat("{0} ", OrderTable.Rows(0).Item("CSSTATE").ToString & ", ")
'                    .AppendFormat("CEP: {0}", OrderTable.Rows(0).Item("CSZIPCODE").ToString)
'                End With
'                With WorkSheet.Range("D3")
'                    .Value = SbTextHelper.ToString
'                    .Style.Font.FontSize = 9
'                End With
'                With SbTextHelper
'                    .Clear()
'                    .Append("TEL.: " & OrderTable.Rows(0).Item("CSPHONE1"))
'                    .AppendFormat("{0} ", If(OrderTable.Rows(0).Item("CSPHONE2").ToString <> Nothing, " / " & OrderTable.Rows(0).Item("CSPHONE2").ToString, Nothing))
'                    .AppendFormat("{0} ", If(OrderTable.Rows(0).Item("CSEMAIL").ToString <> Nothing, " - EMAIL: " & OrderTable.Rows(0).Item("CSEMAIL").ToString, Nothing))
'                End With
'                With WorkSheet.Range("D4")
'                    .Value = SbTextHelper.ToString
'                    .Style.Font.FontSize = 9
'                End With
'                With WorkSheet.Range("O4")
'                    .Value = "COMPRADOR: " & OrderTable.Rows(0).Item("UNAME").ToString
'                    .Style.Font.FontSize = 9
'                    .Style.Alignment.Horizontal = ClosedXML.Excel.XLAlignmentHorizontalValues.Right
'                End With
'                WorkSheet.Range("A4:O4").Style.Border.BottomBorder = ClosedXML.Excel.XLBorderStyleValues.Thin
'                With WorkSheet.Range("A5")
'                    .Value = "FORNECEDOR"
'                    .Style.Font.Bold = True
'                    .Style.Font.FontSize = 6
'                    .Style.Alignment.Vertical = ClosedXML.Excel.XLAlignmentVerticalValues.Bottom
'                End With
'                With WorkSheet.Range("A6")
'                    .Value = OrderTable.Rows(0).Item("PNAME").ToString
'                    .Style.Font.Bold = True
'                    .Style.Font.FontSize = 12
'                End With
'                With SbTextHelper
'                    .Clear()
'                    .Append(String.Format("CNPJ: " & OrderTable.Rows(0).Item("PDOC1").ToString))
'                    .Append(If(OrderTable.Rows(0).Item("PDOC2").ToString <> Nothing, " IE: " & OrderTable.Rows(0).Item("PDOC2").ToString, Nothing))
'                    .Append(If(OrderTable.Rows(0).Item("PDOC3").ToString <> Nothing, " IM: " & OrderTable.Rows(0).Item("PDOC3").ToString, Nothing))
'                End With
'                With WorkSheet.Range("A7")
'                    .Value = SbTextHelper.ToString
'                    .Style.Font.FontSize = 9
'                End With
'                With SbTextHelper
'                    .Clear()
'                    .AppendFormat("{0} ", If(OrderTable.Rows(0).Item("PNUMBER").ToString <> Nothing, OrderTable.Rows(0).Item("PADDRESS").ToString, OrderTable.Rows(0).Item("PADDRESS").ToString & ","))
'                    .AppendFormat("{0} ", If(OrderTable.Rows(0).Item("PNUMBER").ToString <> Nothing, "Nº " & OrderTable.Rows(0).Item("PNUMBER").ToString & ",", Nothing))
'                    .AppendFormat("{0} ", If(OrderTable.Rows(0).Item("PCOMP").ToString <> Nothing, OrderTable.Rows(0).Item("PCOMP").ToString & ", ", Nothing))
'                    .AppendFormat("{0} ", OrderTable.Rows(0).Item("PDISTRICT").ToString & ", ")
'                    .AppendFormat("{0} ", OrderTable.Rows(0).Item("PCITY").ToString & "-")
'                    .AppendFormat("{0} ", OrderTable.Rows(0).Item("PSTATE").ToString & ", ")
'                    .AppendFormat("CEP: {0}", OrderTable.Rows(0).Item("PZIPCODE").ToString)
'                End With
'                With WorkSheet.Range("A8")
'                    .Value = SbTextHelper.ToString
'                    .Style.Font.FontSize = 9
'                End With
'                With SbTextHelper
'                    .Clear()
'                    .Append("TEL.: " & OrderTable.Rows(0).Item("PPHONE"))
'                    .AppendFormat("{0} ", If(OrderTable.Rows(0).Item("PEMAIL").ToString <> Nothing, " - EMAIL: " & OrderTable.Rows(0).Item("PEMAIL").ToString, Nothing))
'                End With
'                With WorkSheet.Range("A9")
'                    .Value = SbTextHelper.ToString
'                    .Style.Font.FontSize = 9
'                End With
'                With WorkSheet.Range("A9:O9")
'                    .Style.Border.BottomBorder = ClosedXML.Excel.XLBorderStyleValues.Thin
'                End With
'                With WorkSheet.Range("A10:O11")
'                    .Merge()
'                    .Value = "PEDIDO DE COMPRA " & OrderTable.Rows(0).Item("POID").ToString.PadLeft(6, "0")
'                    .Style.Font.Bold = True
'                    .Style.Font.FontSize = 14
'                    .Style.Alignment.Horizontal = ClosedXML.Excel.XLAlignmentHorizontalValues.Center
'                    .Style.Border.BottomBorder = ClosedXML.Excel.XLBorderStyleValues.Thin
'                End With
'                WorkSheet.Range("A12").Value = "COD."
'                WorkSheet.Range("B12:H12").Merge()
'                WorkSheet.Range("B12:H12").Value = "NOME"
'                WorkSheet.Range("I12").Value = "QTD."
'                WorkSheet.Range("J12").Value = "UND."
'                WorkSheet.Range("K12").Value = "PREÇO"
'                WorkSheet.Range("L12").Value = "IPI"
'                WorkSheet.Range("M12").Value = "ICMS"
'                WorkSheet.Range("N12").Value = "DESC."
'                WorkSheet.Range("O12").Value = "TOTAL"
'                With WorkSheet.Range("A12:O12")
'                    .Style.Font.Bold = True
'                    .Style.Font.FontSize = 11
'                    .Style.Alignment.Horizontal = ClosedXML.Excel.XLAlignmentHorizontalValues.Center
'                    .Style.Border.InsideBorder = ClosedXML.Excel.XLBorderStyleValues.Hair
'                    .Style.Border.BottomBorder = ClosedXML.Excel.XLBorderStyleValues.Thin
'                End With
'                For RowItem As Integer = 0 To ItemsTable.Rows.Count - 1
'                    With WorkSheet.Range("A" & CurrentRow)
'                        .Value = ItemsTable.Rows(RowItem).Item("INTERNALCODE").ToString
'                        .Style.Alignment.Horizontal = ClosedXML.Excel.XLAlignmentHorizontalValues.Center
'                        .Style.Border.RightBorder = ClosedXML.Excel.XLBorderStyleValues.Hair
'                    End With
'                    With WorkSheet.Range("B" & CurrentRow & ":H" & CurrentRow)
'                        .Merge()
'                        .Value = ItemsTable.Rows(RowItem).Item("NAME").ToString
'                        .Style.Border.RightBorder = ClosedXML.Excel.XLBorderStyleValues.Hair
'                    End With
'                    With WorkSheet.Range("I" & CurrentRow)
'                        .Value = ItemsTable.Rows(RowItem).Item("QUANTITY") / 100
'                        .Style.Alignment.Horizontal = ClosedXML.Excel.XLAlignmentHorizontalValues.Right
'                        .Style.Border.RightBorder = ClosedXML.Excel.XLBorderStyleValues.Hair
'                        .Style.NumberFormat.Format = "#,##0.00"
'                    End With
'                    With WorkSheet.Range("J" & CurrentRow)
'                        .Value = ItemsTable.Rows(RowItem).Item("INITIALS").ToString
'                        .Style.Alignment.Horizontal = ClosedXML.Excel.XLAlignmentHorizontalValues.Center
'                        .Style.Border.RightBorder = ClosedXML.Excel.XLBorderStyleValues.Hair
'                    End With
'                    With WorkSheet.Range("K" & CurrentRow)
'                        .Value = ItemsTable.Rows(RowItem).Item("PRICE") / 100
'                        .Style.Alignment.Horizontal = ClosedXML.Excel.XLAlignmentHorizontalValues.Right
'                        .Style.Border.RightBorder = ClosedXML.Excel.XLBorderStyleValues.Hair
'                        .Style.NumberFormat.Format = "#,##0.00"
'                    End With
'                    With WorkSheet.Range("L" & CurrentRow)
'                        .Value = ItemsTable.Rows(RowItem).Item("IPI") / 100
'                        .Style.Alignment.Horizontal = ClosedXML.Excel.XLAlignmentHorizontalValues.Center
'                        .Style.Border.RightBorder = ClosedXML.Excel.XLBorderStyleValues.Hair
'                        .Style.NumberFormat.Format = "0%"
'                    End With
'                    With WorkSheet.Range("M" & CurrentRow)
'                        .Value = ItemsTable.Rows(RowItem).Item("ICMS") / 100
'                        .Style.Alignment.Horizontal = ClosedXML.Excel.XLAlignmentHorizontalValues.Center
'                        .Style.Border.RightBorder = ClosedXML.Excel.XLBorderStyleValues.Hair
'                        .Style.NumberFormat.Format = "0%"
'                    End With
'                    With WorkSheet.Range("N" & CurrentRow)
'                        .Value = (ItemsTable.Rows(RowItem).Item("DISCOUNT") / 100) * (ItemsTable.Rows(RowItem).Item("QUANTITY") / 100)
'                        .Style.Alignment.Horizontal = ClosedXML.Excel.XLAlignmentHorizontalValues.Right
'                        .Style.Border.RightBorder = ClosedXML.Excel.XLBorderStyleValues.Hair
'                        .Style.NumberFormat.Format = "#,##0.00"
'                    End With
'                    With WorkSheet.Range("O" & CurrentRow)
'                        .Value = ((ItemsTable.Rows(RowItem).Item("QUANTITY") / 100) * (ItemsTable.Rows(RowItem).Item("PRICE") / 100)) +
'                                 ((ItemsTable.Rows(RowItem).Item("QUANTITY") / 100) * (ItemsTable.Rows(RowItem).Item("PRICE") / 100)) * (ItemsTable.Rows(RowItem).Item("IPI") / 100) -
'                                  (ItemsTable.Rows(RowItem).Item("QUANTITY") / 100) * (ItemsTable.Rows(RowItem).Item("DISCOUNT") / 100)
'                        .Style.Alignment.Horizontal = ClosedXML.Excel.XLAlignmentHorizontalValues.Right
'                        .Style.NumberFormat.Format = "#,##0.00"
'                    End With
'                    CurrentRow += 1
'                Next RowItem
'                LastRow = System.Math.Ceiling(CurrentRow / 29) * 29
'                If LastRow - CurrentRow >= 7 Then
'                    CurrentRow = LastRow - 8
'                Else
'                    CurrentRow = LastRow
'                End If
'                With WorkSheet.Range("A" & CurrentRow & ":O" & CurrentRow)
'                    .Style.Border.BottomBorder = ClosedXML.Excel.XLBorderStyleValues.Thin
'                End With
'                For RowItem As Integer = 0 To ItemsTable.Rows.Count - 1
'                    ItemQuantity = ItemsTable.Rows(RowItem).Item("QUANTITY") / 100
'                    ItemPrice = ItemsTable.Rows(RowItem).Item("PRICE") / 100
'                    ItemIPI = ItemsTable.Rows(RowItem).Item("IPI") / 100
'                    ItemDiscount = ItemsTable.Rows(RowItem).Item("DISCOUNT") / 100
'                    TotalItem += ItemQuantity * ItemPrice
'                    TotalIPI += ItemQuantity * (ItemPrice * ItemIPI)
'                    TotalDiscount += ItemQuantity * ItemDiscount
'                Next RowItem
'                CarrierPrice = OrderTable.Rows(0).Item("CARRIERPRICE") / 100
'                OrderDiscount = OrderTable.Rows(0).Item("DISCOUNT") / 100
'                TotalDiscount += OrderDiscount
'                Expenses = OrderTable.Rows(0).Item("EXPENSE") / 100
'                ICMSST = OrderTable.Rows(0).Item("ICMSST") / 100
'                Total = TotalItem + TotalIPI + CarrierPrice + Expenses + ICMSST - TotalDiscount
'                CurrentRow += 1
'                With SbTextHelper
'                    .Clear()
'                    .Append("FRETE: ")
'                    .Append(OrderTable.Rows(0).Item("PCARRIERTYPE").ToString)
'                    .Append(" - ")
'                    .Append("TRANSPORTADORA: ")
'                    .Append(OrderTable.Rows(0).Item("CNAME").ToString)
'                    .Append(If(OrderTable.Rows(0).Item("CPHONE").ToString <> Nothing, " - ", Nothing))
'                    .Append(OrderTable.Rows(0).Item("CPHONE").ToString)
'                    .Append(" - ")
'                    .Append("CNPJ: ")
'                    .Append(OrderTable.Rows(0).Item("CDOC1").ToString)
'                End With
'                With WorkSheet.Cell(CurrentRow, 1)
'                    .Value = SbTextHelper.ToString
'                    .RichText.Substring(0, 6).Bold = True
'                End With
'                With WorkSheet.Cell(CurrentRow, 13)
'                    .Value = "ITENS:"
'                    .Style.Font.Bold = True
'                    .Style.Alignment.Horizontal = ClosedXML.Excel.XLAlignmentHorizontalValues.Right
'                End With
'                With WorkSheet.Range(CurrentRow, 14, CurrentRow, 15)
'                    .Merge()
'                    .Value = TotalItem
'                    .Style.Alignment.Horizontal = ClosedXML.Excel.XLAlignmentHorizontalValues.Right
'                    .Style.NumberFormat.Format = "#,##0.00"
'                End With
'                CurrentRow += 1
'                With SbTextHelper
'                    .Clear()
'                    .Append("LOCAL DE ENTREGA: ")
'                    .AppendFormat("{0} ", If(OrderTable.Rows(0).Item("CSLNUMBER").ToString <> Nothing, OrderTable.Rows(0).Item("CSLADDRESS").ToString, OrderTable.Rows(0).Item("CSLADDRESS").ToString & ","))
'                    .AppendFormat("{0} ", If(OrderTable.Rows(0).Item("CSLNUMBER").ToString <> Nothing, "Nº " & OrderTable.Rows(0).Item("CSLNUMBER").ToString & ",", Nothing))
'                    .AppendFormat("{0} ", If(OrderTable.Rows(0).Item("CSLCOMP").ToString <> Nothing, OrderTable.Rows(0).Item("CSLCOMP").ToString & ", ", Nothing))
'                    .AppendFormat("{0} ", OrderTable.Rows(0).Item("CSLDISTRICT").ToString & ", ")
'                    .AppendFormat("{0} ", OrderTable.Rows(0).Item("CSLCITY").ToString & "-")
'                    .AppendFormat("{0} ", OrderTable.Rows(0).Item("CSLSTATE").ToString & ", ")
'                    .AppendFormat("CEP: {0}", OrderTable.Rows(0).Item("CSLZIPCODE").ToString)
'                End With
'                With WorkSheet.Cell(CurrentRow, 1)
'                    .Value = SbTextHelper.ToString
'                    .RichText.Substring(0, 17).Bold = True
'                End With
'                With WorkSheet.Cell(CurrentRow, 13)
'                    .Value = "IMPOSTOS:"
'                    .Style.Font.Bold = True
'                    .Style.Alignment.Horizontal = ClosedXML.Excel.XLAlignmentHorizontalValues.Right
'                End With

'                With WorkSheet.Range(CurrentRow, 14, CurrentRow, 15)
'                    .Merge()
'                    .Value = TotalIPI + ICMSST
'                    .Style.Alignment.Horizontal = ClosedXML.Excel.XLAlignmentHorizontalValues.Right
'                    .Style.NumberFormat.Format = "#,##0.00"
'                End With
'                CurrentRow += 1
'                With WorkSheet.Cell(CurrentRow, 1)
'                    .Value = "PRAZO DE ENTREGA: " & OrderTable.Rows(0).Item("DELIVERYTIME").ToString
'                    .RichText.Substring(0, 17).Bold = True
'                End With
'                With WorkSheet.Cell(CurrentRow, 13)
'                    .Value = "FRETE:"
'                    .Style.Font.Bold = True
'                    .Style.Alignment.Horizontal = ClosedXML.Excel.XLAlignmentHorizontalValues.Right
'                End With
'                With WorkSheet.Range(CurrentRow, 14, CurrentRow, 15)
'                    .Merge()
'                    .Value = CarrierPrice
'                    .Style.Alignment.Horizontal = ClosedXML.Excel.XLAlignmentHorizontalValues.Right
'                    .Style.NumberFormat.Format = "#,##0.00"
'                End With
'                CurrentRow += 1
'                With WorkSheet.Cell(CurrentRow, 1)
'                    .Value = "PRAZO DE PAGAMENTO: " & OrderTable.Rows(0).Item("PTNAME").ToString
'                    .RichText.Substring(0, 19).Bold = True
'                End With
'                With WorkSheet.Cell(CurrentRow, 13)
'                    .Value = "DESPESAS:"
'                    .Style.Font.Bold = True
'                    .Style.Alignment.Horizontal = ClosedXML.Excel.XLAlignmentHorizontalValues.Right
'                End With
'                With WorkSheet.Range(CurrentRow, 14, CurrentRow, 15)
'                    .Merge()
'                    .Value = Expenses
'                    .Style.Alignment.Horizontal = ClosedXML.Excel.XLAlignmentHorizontalValues.Right
'                    .Style.NumberFormat.Format = "#,##0.00"
'                End With
'                CurrentRow += 1
'                With WorkSheet.Range(CurrentRow, 1, CurrentRow + 1, 11)
'                    .Merge()
'                    .Value = "OBSERVAÇÃO: " & OrderTable.Rows(0).Item("EXTERNALNOTE").ToString
'                    .Style.Alignment.Vertical = ClosedXML.Excel.XLAlignmentVerticalValues.Top
'                End With
'                WorkSheet.Cell(CurrentRow, 1).RichText.Substring(0, 11).Bold = True
'                With WorkSheet.Cell(CurrentRow, 13)
'                    .Value = "DESCONTO:"
'                    .Style.Font.Bold = True
'                    .Style.Alignment.Horizontal = ClosedXML.Excel.XLAlignmentHorizontalValues.Right
'                End With
'                With WorkSheet.Range(CurrentRow, 14, CurrentRow, 15)
'                    .Merge()
'                    .Value = TotalDiscount
'                    .Style.Alignment.Horizontal = ClosedXML.Excel.XLAlignmentHorizontalValues.Right
'                    .Style.NumberFormat.Format = "#,##0.00"
'                End With
'                CurrentRow += 1
'                With WorkSheet.Cell(CurrentRow, 13)
'                    .Value = "TOTAL:"
'                    .Style.Font.Bold = True
'                    .Style.Font.FontSize = 12
'                    .Style.Alignment.Horizontal = ClosedXML.Excel.XLAlignmentHorizontalValues.Right
'                End With
'                With WorkSheet.Range(CurrentRow, 14, CurrentRow, 15)
'                    .Merge()
'                    .Value = Total
'                    .Style.Font.Bold = True
'                    .Style.Font.FontSize = 12
'                    .Style.Alignment.Horizontal = ClosedXML.Excel.XLAlignmentHorizontalValues.Right
'                    .Style.NumberFormat.Format = "#,##0.00"
'                End With
'                WorkSheet.Range(CurrentRow, 1, CurrentRow, 15).Style.Border.BottomBorder = ClosedXML.Excel.XLBorderStyleValues.Thin
'                With SbTextHelper
'                    .Clear()
'                    .Append("ATENÇÃO: AUTORIZAMOS O FORNECIMENTO DOS MATERIAIS OU SERVIÇOS CONSTANTES NESTE PEDIDO DE COMPRA, ")
'                    .Append("NOS TERMOS DE SUA PROPOSTA, OBSERVANDO AS CONDIÇÕES ESPECIFICADAS, O ATENDIMENTO ")
'                    .Append("COMPLETO DE TODOS OS ITENS E A CITAÇÃO DO NÚMERO DESTE PEDIDO EM CADA NOTA FISCAL E RESPECTIVOS VOLUMES. ")
'                    .Append("ESTA TRANSAÇÃO ESTÁ CONDICIONADA À LEI Nº 8078/90 E DEMAIS LEGISLAÇÕES VIGENTES.")
'                End With
'                CurrentRow += 1
'                With WorkSheet.Range(CurrentRow, 1, CurrentRow + 1, 15)
'                    .Merge()
'                    .Value = SbTextHelper.ToString
'                    .Style.Alignment.Horizontal = ClosedXML.Excel.XLAlignmentHorizontalValues.Justify
'                    .Style.Alignment.Vertical = ClosedXML.Excel.XLAlignmentVerticalValues.Center
'                    .Style.Font.FontSize = 7
'                    .Style.Font.FontColor = ClosedXML.Excel.XLColor.DarkRed
'                End With
'                With WorkSheet.PageSetup
'                    .PaperSize = ClosedXML.Excel.XLPaperSize.A4Paper
'                    .PageOrientation = ClosedXML.Excel.XLPageOrientation.Landscape
'                    .Margins.SetBottom(1.9 / 2.54)
'                    .Margins.SetTop(1.9 / 2.54)
'                    .Margins.SetLeft(0.6 / 2.54)
'                    .Margins.SetRight(0.6 / 2.54)
'                    .PagesWide = 1
'                    .Header.Right.AddText("PÁGINA ", ClosedXML.Excel.XLHFOccurrence.AllPages)
'                    .Header.Right.AddText(ClosedXML.Excel.XLHFPredefinedText.PageNumber, ClosedXML.Excel.XLHFOccurrence.AllPages)
'                    .Header.Right.AddText(" DE ", ClosedXML.Excel.XLHFOccurrence.AllPages)
'                    .Header.Right.AddText(ClosedXML.Excel.XLHFPredefinedText.NumberOfPages, ClosedXML.Excel.XLHFOccurrence.AllPages)
'                End With
'                WorkSheet.Columns("A").Width = 11.57
'                WorkSheet.Columns("B").Width = 8.43
'                WorkSheet.Columns("C").Width = 8.43
'                WorkSheet.Columns("D").Width = 8
'                WorkSheet.Columns("E").Width = 8
'                WorkSheet.Columns("F").Width = 8
'                WorkSheet.Columns("G").Width = 7
'                WorkSheet.Columns("H").Width = 7.14
'                WorkSheet.Columns("I").Width = 12
'                WorkSheet.Columns("J").Width = 7
'                WorkSheet.Columns("K").Width = 12
'                WorkSheet.Columns("L").Width = 7
'                WorkSheet.Columns("M").Width = 7
'                WorkSheet.Columns("N").Width = 8.43
'                WorkSheet.Columns("O").Width = 12
'                TempFilePath = System.IO.Path.GetTempFileName() & ".xlsx"
'                WorkBook.SaveAs(TempFilePath)
'                SfdSave = New System.Windows.Forms.SaveFileDialog With {
'                    .Filter = "Planilha do Excel|*.xlsx",
'                    .DefaultExt = ".xlsx",
'                    .Title = "Salvar Pedido de Compra",
'                    .FileName = "Pedido de Compra " & OrderTable.Rows(0).Item("POID").ToString.PadLeft(6, "0")
'                }
'                If SfdSave.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
'                    System.IO.File.Copy(TempFilePath, SfdSave.FileName, True)
'                    If ControlLibrary.CMessageBox.Show("Deseja abrir o arquivo?", ControlLibrary.CMessageBox.CMessageBoxType.Question, ControlLibrary.CMessageBox.CMessageBoxButtons.YesNo) = System.Windows.Forms.DialogResult.Yes Then
'                        If System.IO.File.Exists(SfdSave.FileName) Then
'                            System.Diagnostics.Process.Start(SfdSave.FileName)
'                        Else
'                            ControlLibrary.CMessageBox.Show("Não foi possível abrir o arquivo. Ele pode ter sido movido ou excluído.", ControlLibrary.CMessageBox.CMessageBoxType.Information, ControlLibrary.CMessageBox.CMessageBoxButtons.OK)
'                        End If
'                    End If
'                End If
'                If System.IO.File.Exists(TempFilePath) Then System.IO.File.Delete(TempFilePath)
'                If System.IO.File.Exists(Microsoft.VisualBasic.Strings.Left(TempFilePath, TempFilePath.Length - 5)) Then System.IO.File.Delete(Microsoft.VisualBasic.Strings.Left(TempFilePath, TempFilePath.Length - 5))
'            End Using
'            Return New NetSige.Report.ReportResult With {.Sucesss = True, .Message = "Pedido de compra gerado com sucesso.", .Path = Nothing}
'        Else
'            Return New NetSige.Report.ReportResult With {.Sucesss = False, .Message = "Pedido de compra não encontrado.", .Path = Nothing}
'        End If
'    End Function
'End Class

