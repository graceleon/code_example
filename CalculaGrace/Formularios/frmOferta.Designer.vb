<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOferta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOferta))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnLimpia = New System.Windows.Forms.Button()
        Me.lblOfertaDef = New System.Windows.Forms.Label()
        Me.gpbOferta = New System.Windows.Forms.GroupBox()
        Me.btnCantidadTrenes = New System.Windows.Forms.Button()
        Me.txtCapacidadTrenes = New System.Windows.Forms.TextBox()
        Me.txtFrecuencia = New System.Windows.Forms.TextBox()
        Me.btnOferta = New System.Windows.Forms.Button()
        Me.txtOfertaResultado = New System.Windows.Forms.TextBox()
        Me.lblCapacidadTrenes = New System.Windows.Forms.Label()
        Me.lblFrecuencia = New System.Windows.Forms.Label()
        Me.gpbOfertaFueraBucle = New System.Windows.Forms.GroupBox()
        Me.btnOfertaFB = New System.Windows.Forms.Button()
        Me.txtOfertaResultadoFB = New System.Windows.Forms.TextBox()
        Me.txtFrecFB = New System.Windows.Forms.TextBox()
        Me.lblFrecFB = New System.Windows.Forms.Label()
        Me.txtCapacidadTrenesFB = New System.Windows.Forms.TextBox()
        Me.lblCapacidadTrenesFB = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.gpbOferta.SuspendLayout()
        Me.gpbOfertaFueraBucle.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.945112!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 91.08062!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.802744!))
        Me.TableLayoutPanel1.Controls.Add(Me.btnLimpia, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lblOfertaDef, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.gpbOferta, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.gpbOfertaFueraBucle, 1, 3)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(2, 5, 2, 5)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 5
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.177216!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36.07595!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.113924!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.93671!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.063291!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(583, 316)
        Me.TableLayoutPanel1.TabIndex = 14
        '
        'btnLimpia
        '
        Me.btnLimpia.BackColor = System.Drawing.SystemColors.Window
        Me.btnLimpia.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnLimpia.Image = Global.CalculaGrace.My.Resources.Resources.Clear1
        Me.btnLimpia.Location = New System.Drawing.Point(557, 3)
        Me.btnLimpia.Name = "btnLimpia"
        Me.btnLimpia.Size = New System.Drawing.Size(23, 23)
        Me.btnLimpia.TabIndex = 69
        Me.btnLimpia.UseVisualStyleBackColor = False
        '
        'lblOfertaDef
        '
        Me.lblOfertaDef.AutoSize = True
        Me.lblOfertaDef.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblOfertaDef.Location = New System.Drawing.Point(26, 0)
        Me.lblOfertaDef.Name = "lblOfertaDef"
        Me.lblOfertaDef.Size = New System.Drawing.Size(525, 29)
        Me.lblOfertaDef.TabIndex = 70
        Me.lblOfertaDef.Text = "Oferta: Se mide por tramo de línea, por ahora"
        Me.lblOfertaDef.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'gpbOferta
        '
        Me.gpbOferta.Controls.Add(Me.btnCantidadTrenes)
        Me.gpbOferta.Controls.Add(Me.txtCapacidadTrenes)
        Me.gpbOferta.Controls.Add(Me.txtFrecuencia)
        Me.gpbOferta.Controls.Add(Me.btnOferta)
        Me.gpbOferta.Controls.Add(Me.txtOfertaResultado)
        Me.gpbOferta.Controls.Add(Me.lblCapacidadTrenes)
        Me.gpbOferta.Controls.Add(Me.lblFrecuencia)
        Me.gpbOferta.Location = New System.Drawing.Point(26, 32)
        Me.gpbOferta.Name = "gpbOferta"
        Me.gpbOferta.Size = New System.Drawing.Size(525, 108)
        Me.gpbOferta.TabIndex = 71
        Me.gpbOferta.TabStop = False
        Me.gpbOferta.Text = "Oferta Normal"
        '
        'btnCantidadTrenes
        '
        Me.btnCantidadTrenes.Location = New System.Drawing.Point(289, 72)
        Me.btnCantidadTrenes.Name = "btnCantidadTrenes"
        Me.btnCantidadTrenes.Size = New System.Drawing.Size(69, 23)
        Me.btnCantidadTrenes.TabIndex = 32
        Me.btnCantidadTrenes.Text = "Calcular"
        Me.btnCantidadTrenes.UseVisualStyleBackColor = True
        '
        'txtCapacidadTrenes
        '
        Me.txtCapacidadTrenes.Location = New System.Drawing.Point(171, 72)
        Me.txtCapacidadTrenes.MaxLength = 10
        Me.txtCapacidadTrenes.Name = "txtCapacidadTrenes"
        Me.txtCapacidadTrenes.Size = New System.Drawing.Size(100, 24)
        Me.txtCapacidadTrenes.TabIndex = 31
        Me.txtCapacidadTrenes.Text = "0"
        '
        'txtFrecuencia
        '
        Me.txtFrecuencia.Location = New System.Drawing.Point(171, 26)
        Me.txtFrecuencia.MaxLength = 10
        Me.txtFrecuencia.Name = "txtFrecuencia"
        Me.txtFrecuencia.Size = New System.Drawing.Size(100, 24)
        Me.txtFrecuencia.TabIndex = 30
        Me.txtFrecuencia.Text = "0"
        '
        'btnOferta
        '
        Me.btnOferta.BackColor = System.Drawing.Color.Thistle
        Me.btnOferta.Location = New System.Drawing.Point(430, 25)
        Me.btnOferta.Name = "btnOferta"
        Me.btnOferta.Size = New System.Drawing.Size(67, 23)
        Me.btnOferta.TabIndex = 26
        Me.btnOferta.Text = "Oferta"
        Me.btnOferta.UseVisualStyleBackColor = False
        '
        'txtOfertaResultado
        '
        Me.txtOfertaResultado.BackColor = System.Drawing.Color.Thistle
        Me.txtOfertaResultado.Location = New System.Drawing.Point(417, 71)
        Me.txtOfertaResultado.MaxLength = 15
        Me.txtOfertaResultado.Name = "txtOfertaResultado"
        Me.txtOfertaResultado.ReadOnly = True
        Me.txtOfertaResultado.Size = New System.Drawing.Size(100, 24)
        Me.txtOfertaResultado.TabIndex = 27
        Me.txtOfertaResultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblCapacidadTrenes
        '
        Me.lblCapacidadTrenes.AutoSize = True
        Me.lblCapacidadTrenes.Location = New System.Drawing.Point(33, 76)
        Me.lblCapacidadTrenes.Name = "lblCapacidadTrenes"
        Me.lblCapacidadTrenes.Size = New System.Drawing.Size(103, 16)
        Me.lblCapacidadTrenes.TabIndex = 29
        Me.lblCapacidadTrenes.Text = "Capacidad Trenes"
        '
        'lblFrecuencia
        '
        Me.lblFrecuencia.AutoSize = True
        Me.lblFrecuencia.Location = New System.Drawing.Point(33, 30)
        Me.lblFrecuencia.Name = "lblFrecuencia"
        Me.lblFrecuencia.Size = New System.Drawing.Size(66, 16)
        Me.lblFrecuencia.TabIndex = 28
        Me.lblFrecuencia.Text = "Frecuencia"
        '
        'gpbOfertaFueraBucle
        '
        Me.gpbOfertaFueraBucle.Controls.Add(Me.btnOfertaFB)
        Me.gpbOfertaFueraBucle.Controls.Add(Me.txtOfertaResultadoFB)
        Me.gpbOfertaFueraBucle.Controls.Add(Me.txtFrecFB)
        Me.gpbOfertaFueraBucle.Controls.Add(Me.lblFrecFB)
        Me.gpbOfertaFueraBucle.Controls.Add(Me.txtCapacidadTrenesFB)
        Me.gpbOfertaFueraBucle.Controls.Add(Me.lblCapacidadTrenesFB)
        Me.gpbOfertaFueraBucle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gpbOfertaFueraBucle.Location = New System.Drawing.Point(26, 159)
        Me.gpbOfertaFueraBucle.Name = "gpbOfertaFueraBucle"
        Me.gpbOfertaFueraBucle.Size = New System.Drawing.Size(525, 136)
        Me.gpbOfertaFueraBucle.TabIndex = 72
        Me.gpbOfertaFueraBucle.TabStop = False
        Me.gpbOfertaFueraBucle.Text = "Oferta Fuera de Bucle"
        '
        'btnOfertaFB
        '
        Me.btnOfertaFB.BackColor = System.Drawing.Color.Thistle
        Me.btnOfertaFB.Location = New System.Drawing.Point(430, 42)
        Me.btnOfertaFB.Name = "btnOfertaFB"
        Me.btnOfertaFB.Size = New System.Drawing.Size(67, 23)
        Me.btnOfertaFB.TabIndex = 39
        Me.btnOfertaFB.Text = "Oferta"
        Me.btnOfertaFB.UseVisualStyleBackColor = False
        '
        'txtOfertaResultadoFB
        '
        Me.txtOfertaResultadoFB.BackColor = System.Drawing.Color.Thistle
        Me.txtOfertaResultadoFB.Location = New System.Drawing.Point(417, 87)
        Me.txtOfertaResultadoFB.MaxLength = 15
        Me.txtOfertaResultadoFB.Name = "txtOfertaResultadoFB"
        Me.txtOfertaResultadoFB.ReadOnly = True
        Me.txtOfertaResultadoFB.Size = New System.Drawing.Size(100, 24)
        Me.txtOfertaResultadoFB.TabIndex = 40
        Me.txtOfertaResultadoFB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtFrecFB
        '
        Me.txtFrecFB.Location = New System.Drawing.Point(171, 41)
        Me.txtFrecFB.MaxLength = 10
        Me.txtFrecFB.Name = "txtFrecFB"
        Me.txtFrecFB.Size = New System.Drawing.Size(100, 24)
        Me.txtFrecFB.TabIndex = 38
        Me.txtFrecFB.Text = "0"
        '
        'lblFrecFB
        '
        Me.lblFrecFB.AutoSize = True
        Me.lblFrecFB.Location = New System.Drawing.Point(33, 44)
        Me.lblFrecFB.Name = "lblFrecFB"
        Me.lblFrecFB.Size = New System.Drawing.Size(132, 16)
        Me.lblFrecFB.TabIndex = 37
        Me.lblFrecFB.Text = "Frecuencia Fuera Bucle"
        '
        'txtCapacidadTrenesFB
        '
        Me.txtCapacidadTrenesFB.Location = New System.Drawing.Point(171, 87)
        Me.txtCapacidadTrenesFB.MaxLength = 10
        Me.txtCapacidadTrenesFB.Name = "txtCapacidadTrenesFB"
        Me.txtCapacidadTrenesFB.Size = New System.Drawing.Size(100, 24)
        Me.txtCapacidadTrenesFB.TabIndex = 36
        Me.txtCapacidadTrenesFB.Text = "0"
        '
        'lblCapacidadTrenesFB
        '
        Me.lblCapacidadTrenesFB.AutoSize = True
        Me.lblCapacidadTrenesFB.Location = New System.Drawing.Point(33, 90)
        Me.lblCapacidadTrenesFB.Name = "lblCapacidadTrenesFB"
        Me.lblCapacidadTrenesFB.Size = New System.Drawing.Size(103, 16)
        Me.lblCapacidadTrenesFB.TabIndex = 35
        Me.lblCapacidadTrenesFB.Text = "Capacidad Trenes"
        '
        'frmOferta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(583, 316)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("Taffy", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmOferta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Oferta"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.gpbOferta.ResumeLayout(False)
        Me.gpbOferta.PerformLayout()
        Me.gpbOfertaFueraBucle.ResumeLayout(False)
        Me.gpbOfertaFueraBucle.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btnLimpia As System.Windows.Forms.Button
    Friend WithEvents lblOfertaDef As System.Windows.Forms.Label
    Friend WithEvents gpbOferta As System.Windows.Forms.GroupBox
    Friend WithEvents txtCapacidadTrenes As System.Windows.Forms.TextBox
    Friend WithEvents txtFrecuencia As System.Windows.Forms.TextBox
    Friend WithEvents btnOferta As System.Windows.Forms.Button
    Friend WithEvents txtOfertaResultado As System.Windows.Forms.TextBox
    Friend WithEvents lblCapacidadTrenes As System.Windows.Forms.Label
    Friend WithEvents lblFrecuencia As System.Windows.Forms.Label
    Friend WithEvents gpbOfertaFueraBucle As System.Windows.Forms.GroupBox
    Friend WithEvents btnOfertaFB As System.Windows.Forms.Button
    Friend WithEvents txtOfertaResultadoFB As System.Windows.Forms.TextBox
    Friend WithEvents txtFrecFB As System.Windows.Forms.TextBox
    Friend WithEvents lblFrecFB As System.Windows.Forms.Label
    Friend WithEvents txtCapacidadTrenesFB As System.Windows.Forms.TextBox
    Friend WithEvents lblCapacidadTrenesFB As System.Windows.Forms.Label
    Friend WithEvents btnCantidadTrenes As System.Windows.Forms.Button



End Class
