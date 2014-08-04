<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDemanda
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDemanda))
        Me.gpbDemandasProyectadas = New System.Windows.Forms.GroupBox()
        Me.cbHojas = New System.Windows.Forms.ComboBox()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.btnCargar = New System.Windows.Forms.Button()
        Me.lblHoja = New System.Windows.Forms.Label()
        Me.txtArchivo = New System.Windows.Forms.TextBox()
        Me.lblArchivo = New System.Windows.Forms.Label()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.dgDemandas = New System.Windows.Forms.DataGrid()
        Me.ofdOpen = New System.Windows.Forms.OpenFileDialog()
        Me.sfdSave = New System.Windows.Forms.SaveFileDialog()
        Me.gpbDemandasProyectadas.SuspendLayout()
        CType(Me.dgDemandas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gpbDemandasProyectadas
        '
        Me.gpbDemandasProyectadas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gpbDemandasProyectadas.Controls.Add(Me.cbHojas)
        Me.gpbDemandasProyectadas.Controls.Add(Me.btnGuardar)
        Me.gpbDemandasProyectadas.Controls.Add(Me.btnCerrar)
        Me.gpbDemandasProyectadas.Controls.Add(Me.btnCargar)
        Me.gpbDemandasProyectadas.Controls.Add(Me.lblHoja)
        Me.gpbDemandasProyectadas.Controls.Add(Me.txtArchivo)
        Me.gpbDemandasProyectadas.Controls.Add(Me.lblArchivo)
        Me.gpbDemandasProyectadas.Controls.Add(Me.btnBuscar)
        Me.gpbDemandasProyectadas.Controls.Add(Me.dgDemandas)
        Me.gpbDemandasProyectadas.Location = New System.Drawing.Point(12, 12)
        Me.gpbDemandasProyectadas.Name = "gpbDemandasProyectadas"
        Me.gpbDemandasProyectadas.Size = New System.Drawing.Size(764, 462)
        Me.gpbDemandasProyectadas.TabIndex = 0
        Me.gpbDemandasProyectadas.TabStop = False
        Me.gpbDemandasProyectadas.Text = "Demandas Proyectadas"
        '
        'cbHojas
        '
        Me.cbHojas.FormattingEnabled = True
        Me.cbHojas.Location = New System.Drawing.Point(72, 425)
        Me.cbHojas.Name = "cbHojas"
        Me.cbHojas.Size = New System.Drawing.Size(207, 21)
        Me.cbHojas.TabIndex = 9
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(671, 382)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(81, 23)
        Me.btnGuardar.TabIndex = 8
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btnCerrar
        '
        Me.btnCerrar.Location = New System.Drawing.Point(671, 423)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(81, 23)
        Me.btnCerrar.TabIndex = 7
        Me.btnCerrar.Text = "Salir"
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'btnCargar
        '
        Me.btnCargar.Location = New System.Drawing.Point(304, 423)
        Me.btnCargar.Name = "btnCargar"
        Me.btnCargar.Size = New System.Drawing.Size(81, 23)
        Me.btnCargar.TabIndex = 6
        Me.btnCargar.Text = "Cargar"
        Me.btnCargar.UseVisualStyleBackColor = True
        '
        'lblHoja
        '
        Me.lblHoja.AutoSize = True
        Me.lblHoja.Location = New System.Drawing.Point(14, 428)
        Me.lblHoja.Name = "lblHoja"
        Me.lblHoja.Size = New System.Drawing.Size(29, 13)
        Me.lblHoja.TabIndex = 4
        Me.lblHoja.Text = "Hoja"
        '
        'txtArchivo
        '
        Me.txtArchivo.Location = New System.Drawing.Point(72, 384)
        Me.txtArchivo.Name = "txtArchivo"
        Me.txtArchivo.Size = New System.Drawing.Size(427, 20)
        Me.txtArchivo.TabIndex = 3
        '
        'lblArchivo
        '
        Me.lblArchivo.AutoSize = True
        Me.lblArchivo.Location = New System.Drawing.Point(14, 387)
        Me.lblArchivo.Name = "lblArchivo"
        Me.lblArchivo.Size = New System.Drawing.Size(43, 13)
        Me.lblArchivo.TabIndex = 2
        Me.lblArchivo.Text = "Archivo"
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(505, 384)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(35, 20)
        Me.btnBuscar.TabIndex = 1
        Me.btnBuscar.Text = " . . . "
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'dgDemandas
        '
        Me.dgDemandas.AlternatingBackColor = System.Drawing.Color.Silver
        Me.dgDemandas.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgDemandas.BackColor = System.Drawing.Color.White
        Me.dgDemandas.CaptionBackColor = System.Drawing.Color.Maroon
        Me.dgDemandas.CaptionFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.dgDemandas.CaptionForeColor = System.Drawing.Color.White
        Me.dgDemandas.DataMember = ""
        Me.dgDemandas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.dgDemandas.ForeColor = System.Drawing.Color.Black
        Me.dgDemandas.GridLineColor = System.Drawing.Color.Silver
        Me.dgDemandas.HeaderBackColor = System.Drawing.Color.Silver
        Me.dgDemandas.HeaderFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.dgDemandas.HeaderForeColor = System.Drawing.Color.Black
        Me.dgDemandas.LinkColor = System.Drawing.Color.Maroon
        Me.dgDemandas.Location = New System.Drawing.Point(6, 19)
        Me.dgDemandas.Name = "dgDemandas"
        Me.dgDemandas.ParentRowsBackColor = System.Drawing.Color.Silver
        Me.dgDemandas.ParentRowsForeColor = System.Drawing.Color.Black
        Me.dgDemandas.SelectionBackColor = System.Drawing.Color.Maroon
        Me.dgDemandas.SelectionForeColor = System.Drawing.Color.White
        Me.dgDemandas.Size = New System.Drawing.Size(752, 357)
        Me.dgDemandas.TabIndex = 0
        '
        'ofdOpen
        '
        Me.ofdOpen.FileName = "Prueba"
        '
        'sfdSave
        '
        Me.sfdSave.FileName = "Prueba"
        '
        'frmDemanda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(788, 486)
        Me.Controls.Add(Me.gpbDemandasProyectadas)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmDemanda"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Demandas Proyectadas"
        Me.gpbDemandasProyectadas.ResumeLayout(False)
        Me.gpbDemandasProyectadas.PerformLayout()
        CType(Me.dgDemandas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gpbDemandasProyectadas As System.Windows.Forms.GroupBox
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents dgDemandas As System.Windows.Forms.DataGrid
    Friend WithEvents ofdOpen As System.Windows.Forms.OpenFileDialog
    Friend WithEvents lblHoja As System.Windows.Forms.Label
    Friend WithEvents txtArchivo As System.Windows.Forms.TextBox
    Friend WithEvents lblArchivo As System.Windows.Forms.Label
    Friend WithEvents btnCargar As System.Windows.Forms.Button
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents cbHojas As System.Windows.Forms.ComboBox
    Friend WithEvents sfdSave As System.Windows.Forms.SaveFileDialog
End Class
