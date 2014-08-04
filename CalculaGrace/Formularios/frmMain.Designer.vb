<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.gpbOferta = New System.Windows.Forms.GroupBox()
        Me.gpbIntervalo = New System.Windows.Forms.GroupBox()
        Me.gpbFrecuencia = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.gpbDensidad = New System.Windows.Forms.GroupBox()
        Me.gpbTrenes = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'gpbOferta
        '
        Me.gpbOferta.Location = New System.Drawing.Point(7, 5)
        Me.gpbOferta.Name = "gpbOferta"
        Me.gpbOferta.Size = New System.Drawing.Size(441, 191)
        Me.gpbOferta.TabIndex = 0
        Me.gpbOferta.TabStop = False
        Me.gpbOferta.Text = "Cálculo de la Oferta"
        '
        'gpbIntervalo
        '
        Me.gpbIntervalo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gpbIntervalo.Location = New System.Drawing.Point(7, 399)
        Me.gpbIntervalo.Name = "gpbIntervalo"
        Me.gpbIntervalo.Size = New System.Drawing.Size(441, 191)
        Me.gpbIntervalo.TabIndex = 1
        Me.gpbIntervalo.TabStop = False
        Me.gpbIntervalo.Text = "Cálculo del Intervalo"
        '
        'gpbFrecuencia
        '
        Me.gpbFrecuencia.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gpbFrecuencia.Location = New System.Drawing.Point(7, 202)
        Me.gpbFrecuencia.Name = "gpbFrecuencia"
        Me.gpbFrecuencia.Size = New System.Drawing.Size(441, 191)
        Me.gpbFrecuencia.TabIndex = 2
        Me.gpbFrecuencia.TabStop = False
        Me.gpbFrecuencia.Text = "Cálculo de la Frecuencia"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 5
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 0.5258641!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.68534!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.577592!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.68534!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 0.5258641!))
        Me.TableLayoutPanel1.Controls.Add(Me.gpbFrecuencia, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.gpbOferta, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.gpbIntervalo, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.gpbDensidad, 3, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.gpbTrenes, 3, 2)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 5
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 0.5!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 0.5!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(919, 598)
        Me.TableLayoutPanel1.TabIndex = 4
        '
        'gpbDensidad
        '
        Me.gpbDensidad.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gpbDensidad.Location = New System.Drawing.Point(468, 5)
        Me.gpbDensidad.Name = "gpbDensidad"
        Me.gpbDensidad.Size = New System.Drawing.Size(441, 191)
        Me.gpbDensidad.TabIndex = 3
        Me.gpbDensidad.TabStop = False
        Me.gpbDensidad.Text = "Cálculo de la Densidad"
        '
        'gpbTrenes
        '
        Me.gpbTrenes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gpbTrenes.Location = New System.Drawing.Point(468, 202)
        Me.gpbTrenes.Name = "gpbTrenes"
        Me.gpbTrenes.Size = New System.Drawing.Size(441, 191)
        Me.gpbTrenes.TabIndex = 4
        Me.gpbTrenes.TabStop = False
        Me.gpbTrenes.Text = "Datos de Trenes necesarios"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(919, 598)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Calculos Varios"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gpbOferta As System.Windows.Forms.GroupBox
    Friend WithEvents gpbIntervalo As System.Windows.Forms.GroupBox
    Friend WithEvents gpbFrecuencia As System.Windows.Forms.GroupBox
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents gpbDensidad As System.Windows.Forms.GroupBox
    Friend WithEvents gpbTrenes As System.Windows.Forms.GroupBox

End Class
