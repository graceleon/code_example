Public Class frmDemanda2

    '    ' -----------------------------------------------------------------------------------------   
    '    ' \\ --  Descripción       : Exportar DataGrid a Excel   
    '    ' \\ --  Controles         : Un Datagrid, un CommandButton y la referencia a ADO   
    '    ' \\ --  Autor             : Luciano Lodola -- http://www.recursosvisualbasic.com.ar/   
    '    ' -----------------------------------------------------------------------------------------   

    '    ' -- Variables para la base de datos   
    '    Dim cnn As Connection
    '    Dim rs As Recordset
    '    ' -- Variables para Excel   
    '    Dim Obj_Excel As Object
    '    Dim Obj_Libro As Object
    '    Dim Obj_Hoja As Object

    '    ' -----------------------------------------------------------------------------------------   
    '    ' \\ -- Sub para exportar   
    '    ' -----------------------------------------------------------------------------------------   
    '    Private Sub exportar_Datagrid(ByVal Datagrid As DataGrid, ByVal n_Filas As Long)

    '        On Error GoTo Error_Handler

    '        Dim i As Integer
    '        Dim j As Integer

    '        ' -- Colocar el cursor de espera mientras se exportan los datos   
    '        Me.MousePointer = vbHourglass

    '        If n_Filas = 0 Then
    '            MsgBox("No hay datos para exportar a excel. Se ha indicado 0 en el parámetro Filas ") : Exit Sub
    '        Else

    '            ' -- Crear nueva instancia de Excel   
    '            Obj_Excel = CreateObject("Excel.Application")
    '            ' -- Agregar nuevo libro   
    '            Obj_Libro = Obj_Excel.Workbooks.Open(Path)

    '            ' -- Referencia a la Hoja activa ( la que añade por defecto Excel )   
    '            Obj_Hoja = Obj_Excel.ActiveSheet

    '            iCol = 0
    '            ' --  Recorrer el Datagrid ( Las columnas )   
    '            For i = 0 To Datagrid.Columns.Count - 1
    '                If Datagrid.Columns(i).Visible Then
    '                    ' -- Incrementar índice de columna   
    '                    iCol = iCol + 1
    '                    ' -- Obtener el caption de la columna   
    '                    Obj_Hoja.Cells(1, iCol) = Datagrid.Columns(i).Caption
    '                    ' -- Recorrer las filas   
    '                    For j = 0 To n_Filas - 1
    '                        ' -- Asignar el valor a la celda del Excel   
    '                        Obj_Hoja.Cells(j + 2, iCol) = _
    '                        Datagrid.Columns(i).CellValue(Datagrid.GetBookmark(j))
    '                    Next
    '                End If
    '            Next

    '            ' -- Hacer excel visible   
    '            Obj_Excel.Visible = True

    '            ' -- Opcional : colocar en negrita y de color rojo los enbezados en la hoja   
    '            With Obj_Hoja
    '                .Rows(1).Font.Bold = True
    '                .Rows(1).Font.Color = vbRed
    '                ' -- Autoajustar las cabeceras   
    '                .Columns("A:Z").AutoFit()
    '            End With
    '        End If

    '        ' -- Eliminar las variables de objeto excel   
    '        Obj_Hoja = Nothing
    '        Obj_Libro = Nothing
    '        Obj_Excel = Nothing

    '        ' -- Restaurar cursor   
    '        Me.MousePointer = vbDefault

    '        Exit Sub

    '        ' -- Error   
    'Error_Handler:

    '        MsgBox(Err.Description, vbCritical)
    '        On Error Resume Next

    '        Obj_Hoja = Nothing
    '        Obj_Libro = Nothing
    '        Obj_Excel = Nothing
    '        Me.MousePointer = vbDefault

    '    End Sub

    '    ' -------------------------------------------------------------------------------   
    '    ' \\ -- Botón para Ejecutar la función que exporta los datos del datagrid a excel   
    '    ' -------------------------------------------------------------------------------   
    '    Private Sub Command1_Click()
    '        Call exportar_Datagrid(DataGrid1, DataGrid1.ApproxCount)
    '    End Sub
    '    ' -------------------------------------------------------------------------------   
    '    ' \\ -- Inicio   
    '    ' -------------------------------------------------------------------------------   
    '    Private Sub Form_Load()

    '        On Error GoTo Error_Handler

    '        ' -- Crear nueva conexión a la base de datos   
    '        cnn = New Connection

    '        ' -- Abrir la base de datos.   
    '        cnn.Open("PROVIDER=Microsoft.Jet.OLEDB.4.0;Data Source=" & App.Path & "\data\bd1.mdb")

    '        ' -- Crear nuevo objeto Recordset   
    '        rs = New Recordset
    '        ' -- Configurar recordset   
    '        With rs
    '            .CursorLocation = adUseClient
    '        End With
    '        ' -- Cargar el recordset ( ESPECIFICAR LA CONSULTA SQL )   
    '        rs.Open("Select * From tabla1", cnn, adOpenStatic, adLockOptimistic)

    '        ' -- Enlazar el datagrid con el recordset anterior   
    '        DataGrid1.DataSource = rs


    '        Command1.Caption = " Exportar datagrid a Excel "

    '        ' -- Errores   
    '        Exit Sub
    'Error_Handler:
    '        MsgBox(Err.Description, vbCritical, "Error en Form Load")
    '    End Sub
    '    ' -------------------------------------------------------------------------------   
    '    ' \\ -- Fin   
    '    ' -------------------------------------------------------------------------------   
    '    Private Sub Form_Unload(ByVal Cancel As Integer)

    '        On Error Resume Next
    '        ' -- Cerrar y eliminar recordset   
    '        If rs.State = adStateOpen Then rs.Close()
    '        If Not rs Is Nothing Then rs = Nothing
    '        ' -- cerrar y Eliminar la conexión   
    '        If cnn.State = adStateOpen Then cnn.Close()
    '        cnn = Nothing
    '    End Sub

    Private Sub frmDemanda2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class