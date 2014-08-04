Imports System.IO
Imports Excel = Microsoft.Office.Interop.Excel

Public Class frmDemanda
#Region "Campos"
    Friend WithEvents DThoja As New DataTable("Hoja")
    Private _cargando As Boolean = False
#End Region

#Region "Variables"
    'Variables para Excel
    Dim misValue As Object = System.Reflection.Missing.Value ' valor nulo de excel
    Dim oExcel As New Excel.Application
    Dim oLibro As Excel.Workbook
    Dim oHoja As Excel.Worksheet
    Dim oFilas As Excel.ListRows
    Dim oColumnas As Excel.ListColumns
    Dim oFila As Excel.ListRow
    Dim oColumna As Excel.ListColumn
    Dim oCelda As Excel.Range
#End Region

#Region "Métodos"
    ''' <summary>
    ''' Método que importa los datos de un excel a un dataGrid
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub importar_excel()
        Try
            _cargando = True
            Dim Area As Excel.Range = oHoja.UsedRange
            DThoja = New DataTable("Hoja")

            For i As Integer = 1 To Area.Columns.Count - 1
                DThoja.Columns.Add((i).ToString)
            Next

            For fila As Integer = 1 To Area.Rows.Count - 1
                Dim dr As DataRow = DThoja.NewRow()
                For columna As Integer = 1 To Area.Columns.Count - 1
                    oCelda = CType(Area.Cells(fila, columna), Excel.Range)
                    dr.Item(columna - 1) = oCelda.Text
                Next
                DThoja.Rows.Add(dr)
            Next
            _cargando = False
            dgDemandas.DataSource = DThoja
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    ''' <summary>
    ''' Método que permite liberar los objetos utilizados de la memoria
    ''' </summary>
    ''' <param name="obj"></param>
    ''' <remarks></remarks>
    Private Sub releaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub
    'Private Sub WorkbookSaveAs(ByVal Libro As Object)
    '    If Libro.FileFormat = Excel.XlFileFormat.xlWorkbookNormal Then
    '        Libro.SaveAs("C:\xlsCopy.xls", _
    '            Excel.XlFileFormat.xlXMLSpreadsheet, _
    '            AccessMode:=Excel.XlSaveAsAccessMode.xlNoChange)
    '    End If
    'End Sub
#End Region

#Region "Eventos"
    ''' <summary>
    ''' Evento que permite buscar la ruta de un archivo excel para mostrarlo en el dataGrid
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        Try
            ' Se abre un OpenFileDialog para  buscar el archivo excel
            With Me.ofdOpen
                .Title = "Seleccionar archivos"
                .Filter = "Todos los archivos (*.xls)|*.xls"
                .Multiselect = False
                .InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
                If .ShowDialog = Windows.Forms.DialogResult.OK Then
                    Me.txtArchivo.Text = .FileName
                End If
                ' Muestro las hojas del archivo en el combobox
                If My.Computer.FileSystem.FileExists(Me.txtArchivo.Text) Then
                    oLibro = oExcel.Workbooks.Open(txtArchivo.Text)
                    cbHojas.DisplayMember = "Name"
                    cbHojas.Items.Clear()
                    For Each Hoja As Excel.Worksheet In oLibro.Sheets
                        cbHojas.Items.Add(Hoja)
                    Next
                Else
                    MessageBox.Show("Ruta Inválida")
                End If
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    ''' <summary>
    ''' Evento que permite mostrar las hojas del libro excel cargado
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub cbHojas_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbHojas.SelectedIndexChanged
        If cbHojas.SelectedIndex >= 0 Then
            oHoja = cbHojas.SelectedItem
            'btnCargar_Click(btnCargar, New System.EventArgs())
        End If
    End Sub
    ''' <summary>
    ''' Evento que permite guardar los cambios del archivo excel 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Try
            If Me.txtArchivo.Text = "" OrElse Me.txtArchivo.Text Is Nothing Then
                MessageBox.Show("Debe seleccionar un archivo")
            Else
                ' 1º --> Alternativa simple para guardar
                'WorkbookSaveAs(oLibro)

                ' 2º --> Alternativa del SaveFileDialog
                sfdSave.Title = "Guardar Archivo como..."
                sfdSave.Filter = "Todos los archivos (*.xls)|*.xls"
                sfdSave.FilterIndex = 2
                sfdSave.RestoreDirectory = True

                If sfdSave.ShowDialog() = DialogResult.OK Then
                    oLibro.SaveAs(sfdSave.FileName)
                End If
            End If
        Catch ex As Exception
            'MessageBox.Show(ex.Message)
        End Try
    End Sub
    'Private Sub dgDemandas_CurrentCellChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgDemandas.CurrentCellChanged
    '    Try
    '        Dim row As Integer = dgDemandas.CurrentCell.RowNumber
    '        Dim column As Integer = dgDemandas.CurrentCell.ColumnNumber
    '        oCelda = oHoja.UsedRange.Cells(row + 1, column + 1)
    '        oCelda.Value = dgDemandas.Item(dgDemandas.CurrentCell)
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message)
    '    End Try
    'End Sub
    ''' <summary>
    ''' Evento que permite cargar los datos de la hoja seleccionada del archivo
    ''' excel en el dataGrid
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnCargar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCargar.Click
        Try
            If Me.txtArchivo.Text Is Nothing OrElse Me.txtArchivo.Text = "" Then
                MessageBox.Show("Debe seleccionar un archivo")
            Else
                Me.Cursor = Cursors.WaitCursor
                Me.gpbDemandasProyectadas.Enabled = False
                importar_excel()
                Me.Cursor = Cursors.Default
                Me.gpbDemandasProyectadas.Enabled = True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    ''' <summary>
    ''' Evento que cierra el formulario y con ello limpia la memoria del uso del excel
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Try
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            Try
                releaseObject(oExcel)
                releaseObject(oLibro)
                releaseObject(oHoja)
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End Try
    End Sub
    ''' <summary>
    ''' Evento que permite cambiar el valor del dataGrid cuando ello sucede
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub DThoja_RowChanged(ByVal sender As Object, ByVal e As System.Data.DataRowChangeEventArgs) Handles DThoja.RowChanged
        If Not _cargando Then
            Dim nfila As Integer = DThoja.Rows.IndexOf(e.Row)
            Dim Fila As Excel.Range = oHoja.UsedRange.Rows(nfila + 1)

            For columna As Integer = 1 To e.Row.ItemArray.Length
                Fila.Cells(1, columna) = e.Row.Item(columna - 1)
            Next
        End If
    End Sub
#End Region

#Region "Ejemplo de Exportación de Excel con ADODB"
    ''    Private Sub exportar_Datagrid(ByVal Datagrid As DataGrid, ByVal n_Filas As Long)
    ''        On Error GoTo Error_Handler

    ''        Dim i, j As New Integer
    ''        Dim path As String = Me.txtArchivo.Text

    ''        ' Se coloca el cursor de espera mientras se exportan los datos   
    ''        Me.Cursor = Cursors.WaitCursor

    ''        If n_Filas = 0 Then
    ''            MsgBox("No hay datos para exportar a excel. Se ha indicado 0 en el parámetro Filas ") : Exit Sub
    ''        Else

    ''            ' Se crea una nueva instancia de Excel   
    ''            oExcel = CreateObject("Excel.Application")
    ''            ' Se agrega nuevo libro   
    ''            oLibro = oExcel.Workbooks.Open(Path)

    ''            ' Se hace referencia a la Hoja activa (la que añade por defecto Excel)   
    ''            oHoja = oExcel.ActiveSheet

    ''            Dim iCol As Integer = 0
    ''            Dim NCampos As Integer
    ''            ' Se recorren las columnas del Datagrid
    ''            Dim nFilas As Integer = dgDemandas.DataBindings.Count
    ''            Dim ncolumnas As Integer = dgDemandas.TableStyles.Item(0).GridColumnStyles.Count

    ''            For i = 0 To dgDemandas.CurrentRowIndex - 1
    ''                If dgDemandas.Columns(i).Visible Then
    ''                    ' Se incrementa el índice de la columna   
    ''                    iCol = iCol + 1
    ''                    ' Se obtiene el Caption de la columna   
    ''                    oHoja.Cells(1, iCol) = dgDemandas.Columns(i).Caption
    ''                    ' Se recorren las filas   
    ''                    For j = 0 To n_Filas - 1
    ''                        ' -- Asignar el valor a la celda del Excel   
    ''                        Obj_Hoja.Cells(j + 2, iCol) = _
    ''                            dgDemandas.Item(j + 2, iCol)
    ''                        Datagrid.Columns(i).CellValue(Datagrid.GetBookmark(j))
    ''                    Next
    ''                End If
    ''            Next

    ''            ' -- Hacer excel visible   
    ''            Obj_Excel.Visible = True

    ''            ' -- Opcional : colocar en negrita y de color rojo los enbezados en la hoja   
    ''            With Obj_Hoja
    ''                .Rows(1).Font.Bold = True
    ''                .Rows(1).Font.Color = vbRed
    ''                ' -- Autoajustar las cabeceras   
    ''                .Columns("A:Z").AutoFit()
    ''            End With
    ''        End If

    ''        ' -- Eliminar las variables de objeto excel   
    ''        Obj_Hoja = Nothing
    ''        Obj_Libro = Nothing
    ''        Obj_Excel = Nothing

    ''        ' -- Restaurar cursor   
    ''        Me.MousePointer = vbDefault

    ''        Exit Sub

    ''        ' -- Error   
    ''Error_Handler:

    ''        MsgBox(Err.Description, vbCritical)
    ''        On Error Resume Next

    ''        Obj_Hoja = Nothing
    ''        Obj_Libro = Nothing
    ''        Obj_Excel = Nothing
    ''        Me.MousePointer = vbDefault

    ''    End Sub


    ''    ' -------------------------------------------------------------------------------   
    ''    ' \\ -- Fin   
    ''    ' -------------------------------------------------------------------------------   
    ''    Private Sub Form_Unload(ByVal Cancel As Integer)

    ''        On Error Resume Next
    ''        ' -- Cerrar y eliminar recordset   
    ''        If rs.State = adStateOpen Then rs.Close()
    ''        If Not rs Is Nothing Then rs = Nothing
    ''        ' -- cerrar y Eliminar la conexión   
    ''        If cnn.State = adStateOpen Then cnn.Close()
    ''        cnn = Nothing
    ''    End Sub
    ''    ' -------------------------------------------------------------------------------   
    ''    ' \\ -- Botón para Ejecutar la función que exporta los datos del datagrid a excel   
    ''    ' -------------------------------------------------------------------------------   
    ''    Private Sub Command1_Click()
    ''        Call exportar_Datagrid(DataGrid1, DataGrid1.ApproxCount)
    ''    End Sub
    ''    ' -------------------------------------------------------------------------------   
    ''    ' \\ -- Inicio   
    ''    ' -------------------------------------------------------------------------------   
    ''    Private Sub Form_Load()

    ''        On Error GoTo Error_Handler

    ''        ' -- Crear nueva conexión a la base de datos   
    ''        cnn = New Connection

    ''        ' -- Abrir la base de datos.   
    ''        cnn.Open("PROVIDER=Microsoft.Jet.OLEDB.4.0;Data Source=" & App.Path & "\data\bd1.mdb")

    ''        ' -- Crear nuevo objeto Recordset   
    ''        rs = New Recordset
    ''        ' -- Configurar recordset   
    ''        With rs
    ''            .CursorLocation = adUseClient
    ''        End With
    ''        ' -- Cargar el recordset ( ESPECIFICAR LA CONSULTA SQL )   
    ''        rs.Open("Select * From tabla1", cnn, adOpenStatic, adLockOptimistic)

    ''        ' -- Enlazar el datagrid con el recordset anterior   
    ''        DataGrid1.DataSource = rs


    ''        Command1.Caption = " Exportar datagrid a Excel "

    ''        ' -- Errores   
    ''        Exit Sub
    ''Error_Handler:
    ''        MsgBox(Err.Description, vbCritical, "Error en Form Load")
    ''    End Sub
#End Region

#Region "Otro ejemplo"
    ''    Dim strconn As String
    ''    strconn = "Provider=Microsoft.Jet.Oledb.4.0; data source= " + txtArchivo.Text + ";Extended properties=""Excel 8.0;hdr=yes;imex=1"""
    ''    Dim mconn As New OleDbConnection(strconn)
    ''    Dim ad As New OleDbDataAdapter("Select * from [" & txtHoja.Text & "$]", mconn)
    ''    mconn.Open()
    ''    ad.Fill(dt)
    ''    mconn.Close()
    ''    Me.dgDemandas.DataSource = dt
#End Region

End Class