<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFrecuencia
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFrecuencia))
        Me.gpbFrecFB = New System.Windows.Forms.GroupBox()
        Me.btnFrecuenciaFB = New System.Windows.Forms.Button()
        Me.txtFrecuenciaResultadoFB = New System.Windows.Forms.TextBox()
        Me.txtIntervaloFB = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNbucleFB = New System.Windows.Forms.TextBox()
        Me.lblNbucleFB = New System.Windows.Forms.Label()
        Me.lblFrecuenciaDef = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.gpbFrecNormal = New System.Windows.Forms.GroupBox()
        Me.btnFrecuenciaNormal = New System.Windows.Forms.Button()
        Me.txtFrecuenciaResultadoNormal = New System.Windows.Forms.TextBox()
        Me.lblLineas = New System.Windows.Forms.Label()
        Me.txtInyecciones = New System.Windows.Forms.TextBox()
        Me.lblInyecciones = New System.Windows.Forms.Label()
        Me.txtIntervalo = New System.Windows.Forms.TextBox()
        Me.lblIntervalo = New System.Windows.Forms.Label()
        Me.rbtnNoBucleF = New System.Windows.Forms.RadioButton()
        Me.txtFrecuenciaResultado = New System.Windows.Forms.TextBox()
        Me.btnFrecuencia = New System.Windows.Forms.Button()
        Me.txtVueltaBucle = New System.Windows.Forms.TextBox()
        Me.txtNbucleF = New System.Windows.Forms.TextBox()
        Me.txtVueltaLargaF = New System.Windows.Forms.TextBox()
        Me.txtNumeroTrenes = New System.Windows.Forms.TextBox()
        Me.lblNbucleF = New System.Windows.Forms.Label()
        Me.lblVueltaBucle = New System.Windows.Forms.Label()
        Me.lblVueltaLargaF = New System.Windows.Forms.Label()
        Me.rbtnBucleFrec = New System.Windows.Forms.RadioButton()
        Me.lblNumeroTrenes = New System.Windows.Forms.Label()
        Me.gpbFrecFB.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.gpbFrecNormal.SuspendLayout()
        Me.SuspendLayout()
        '
        'gpbFrecFB
        '
        Me.gpbFrecFB.Controls.Add(Me.btnFrecuenciaFB)
        Me.gpbFrecFB.Controls.Add(Me.txtFrecuenciaResultadoFB)
        Me.gpbFrecFB.Controls.Add(Me.txtIntervaloFB)
        Me.gpbFrecFB.Controls.Add(Me.Label1)
        Me.gpbFrecFB.Controls.Add(Me.txtNbucleFB)
        Me.gpbFrecFB.Controls.Add(Me.lblNbucleFB)
        Me.gpbFrecFB.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gpbFrecFB.Location = New System.Drawing.Point(21, 277)
        Me.gpbFrecFB.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.gpbFrecFB.Name = "gpbFrecFB"
        Me.gpbFrecFB.Padding = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.gpbFrecFB.Size = New System.Drawing.Size(531, 92)
        Me.gpbFrecFB.TabIndex = 1
        Me.gpbFrecFB.TabStop = False
        Me.gpbFrecFB.Text = "Frecuencia Fuera de Bucle"
        '
        'btnFrecuenciaFB
        '
        Me.btnFrecuenciaFB.BackColor = System.Drawing.Color.Khaki
        Me.btnFrecuenciaFB.Location = New System.Drawing.Point(426, 24)
        Me.btnFrecuenciaFB.Name = "btnFrecuenciaFB"
        Me.btnFrecuenciaFB.Size = New System.Drawing.Size(95, 29)
        Me.btnFrecuenciaFB.TabIndex = 11
        Me.btnFrecuenciaFB.Text = "Frecuencia"
        Me.btnFrecuenciaFB.UseVisualStyleBackColor = False
        '
        'txtFrecuenciaResultadoFB
        '
        Me.txtFrecuenciaResultadoFB.BackColor = System.Drawing.Color.Khaki
        Me.txtFrecuenciaResultadoFB.Location = New System.Drawing.Point(426, 59)
        Me.txtFrecuenciaResultadoFB.MaxLength = 15
        Me.txtFrecuenciaResultadoFB.Name = "txtFrecuenciaResultadoFB"
        Me.txtFrecuenciaResultadoFB.ReadOnly = True
        Me.txtFrecuenciaResultadoFB.Size = New System.Drawing.Size(95, 24)
        Me.txtFrecuenciaResultadoFB.TabIndex = 48
        Me.txtFrecuenciaResultadoFB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtIntervaloFB
        '
        Me.txtIntervaloFB.Location = New System.Drawing.Point(242, 49)
        Me.txtIntervaloFB.MaxLength = 10
        Me.txtIntervaloFB.Name = "txtIntervaloFB"
        Me.txtIntervaloFB.Size = New System.Drawing.Size(100, 24)
        Me.txtIntervaloFB.TabIndex = 10
        Me.txtIntervaloFB.Text = "0"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(198, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(202, 16)
        Me.Label1.TabIndex = 42
        Me.Label1.Text = "Intervalo largo o fuera de Bucle (seg)"
        '
        'txtNbucleFB
        '
        Me.txtNbucleFB.Location = New System.Drawing.Point(41, 49)
        Me.txtNbucleFB.MaxLength = 10
        Me.txtNbucleFB.Name = "txtNbucleFB"
        Me.txtNbucleFB.Size = New System.Drawing.Size(100, 24)
        Me.txtNbucleFB.TabIndex = 9
        Me.txtNbucleFB.Text = "0"
        '
        'lblNbucleFB
        '
        Me.lblNbucleFB.AutoSize = True
        Me.lblNbucleFB.Location = New System.Drawing.Point(64, 30)
        Me.lblNbucleFB.Name = "lblNbucleFB"
        Me.lblNbucleFB.Size = New System.Drawing.Size(54, 16)
        Me.lblNbucleFB.TabIndex = 36
        Me.lblNbucleFB.Text = "N (bucle)"
        '
        'lblFrecuenciaDef
        '
        Me.lblFrecuenciaDef.AutoSize = True
        Me.lblFrecuenciaDef.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblFrecuenciaDef.Font = New System.Drawing.Font("Taffy", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFrecuenciaDef.Location = New System.Drawing.Point(21, 0)
        Me.lblFrecuenciaDef.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblFrecuenciaDef.Name = "lblFrecuenciaDef"
        Me.lblFrecuenciaDef.Size = New System.Drawing.Size(531, 29)
        Me.lblFrecuenciaDef.TabIndex = 11
        Me.lblFrecuenciaDef.Text = "Frecuencia: número de trenes que pasan por un tramo, por hora"
        Me.lblFrecuenciaDef.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.430532!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 91.93825!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.802744!))
        Me.TableLayoutPanel1.Controls.Add(Me.btnLimpiar, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.gpbFrecFB, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.gpbFrecNormal, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.lblFrecuenciaDef, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 5
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.49354!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 59.94832!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.100775!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.83979!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.421053!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(583, 387)
        Me.TableLayoutPanel1.TabIndex = 12
        '
        'btnLimpiar
        '
        Me.btnLimpiar.BackColor = System.Drawing.SystemColors.Window
        Me.btnLimpiar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnLimpiar.Image = Global.CalculaGrace.My.Resources.Resources.Clear1
        Me.btnLimpiar.Location = New System.Drawing.Point(557, 3)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(23, 23)
        Me.btnLimpiar.TabIndex = 48
        Me.btnLimpiar.UseVisualStyleBackColor = False
        '
        'gpbFrecNormal
        '
        Me.gpbFrecNormal.Controls.Add(Me.btnFrecuenciaNormal)
        Me.gpbFrecNormal.Controls.Add(Me.txtFrecuenciaResultadoNormal)
        Me.gpbFrecNormal.Controls.Add(Me.lblLineas)
        Me.gpbFrecNormal.Controls.Add(Me.txtInyecciones)
        Me.gpbFrecNormal.Controls.Add(Me.lblInyecciones)
        Me.gpbFrecNormal.Controls.Add(Me.txtIntervalo)
        Me.gpbFrecNormal.Controls.Add(Me.lblIntervalo)
        Me.gpbFrecNormal.Controls.Add(Me.rbtnNoBucleF)
        Me.gpbFrecNormal.Controls.Add(Me.txtFrecuenciaResultado)
        Me.gpbFrecNormal.Controls.Add(Me.btnFrecuencia)
        Me.gpbFrecNormal.Controls.Add(Me.txtVueltaBucle)
        Me.gpbFrecNormal.Controls.Add(Me.txtNbucleF)
        Me.gpbFrecNormal.Controls.Add(Me.txtVueltaLargaF)
        Me.gpbFrecNormal.Controls.Add(Me.txtNumeroTrenes)
        Me.gpbFrecNormal.Controls.Add(Me.lblNbucleF)
        Me.gpbFrecNormal.Controls.Add(Me.lblVueltaBucle)
        Me.gpbFrecNormal.Controls.Add(Me.lblVueltaLargaF)
        Me.gpbFrecNormal.Controls.Add(Me.rbtnBucleFrec)
        Me.gpbFrecNormal.Controls.Add(Me.lblNumeroTrenes)
        Me.gpbFrecNormal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gpbFrecNormal.Location = New System.Drawing.Point(21, 33)
        Me.gpbFrecNormal.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.gpbFrecNormal.Name = "gpbFrecNormal"
        Me.gpbFrecNormal.Padding = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.gpbFrecNormal.Size = New System.Drawing.Size(531, 224)
        Me.gpbFrecNormal.TabIndex = 0
        Me.gpbFrecNormal.TabStop = False
        Me.gpbFrecNormal.Text = "Frecuencia Normal"
        '
        'btnFrecuenciaNormal
        '
        Me.btnFrecuenciaNormal.BackColor = System.Drawing.Color.Khaki
        Me.btnFrecuenciaNormal.Location = New System.Drawing.Point(426, 159)
        Me.btnFrecuenciaNormal.Name = "btnFrecuenciaNormal"
        Me.btnFrecuenciaNormal.Size = New System.Drawing.Size(95, 29)
        Me.btnFrecuenciaNormal.TabIndex = 8
        Me.btnFrecuenciaNormal.Text = "Frecuencia"
        Me.btnFrecuenciaNormal.UseVisualStyleBackColor = False
        '
        'txtFrecuenciaResultadoNormal
        '
        Me.txtFrecuenciaResultadoNormal.BackColor = System.Drawing.Color.Khaki
        Me.txtFrecuenciaResultadoNormal.Location = New System.Drawing.Point(426, 194)
        Me.txtFrecuenciaResultadoNormal.MaxLength = 15
        Me.txtFrecuenciaResultadoNormal.Name = "txtFrecuenciaResultadoNormal"
        Me.txtFrecuenciaResultadoNormal.ReadOnly = True
        Me.txtFrecuenciaResultadoNormal.Size = New System.Drawing.Size(95, 24)
        Me.txtFrecuenciaResultadoNormal.TabIndex = 46
        Me.txtFrecuenciaResultadoNormal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblLineas
        '
        Me.lblLineas.AutoSize = True
        Me.lblLineas.Font = New System.Drawing.Font("Taffy", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLineas.ForeColor = System.Drawing.Color.Blue
        Me.lblLineas.Location = New System.Drawing.Point(4, 140)
        Me.lblLineas.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblLineas.Name = "lblLineas"
        Me.lblLineas.Size = New System.Drawing.Size(533, 16)
        Me.lblLineas.TabIndex = 44
        Me.lblLineas.Text = "---------------------------------------------------------------------------------" & _
            "------------------------"
        Me.lblLineas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtInyecciones
        '
        Me.txtInyecciones.Location = New System.Drawing.Point(303, 179)
        Me.txtInyecciones.MaxLength = 10
        Me.txtInyecciones.Name = "txtInyecciones"
        Me.txtInyecciones.Size = New System.Drawing.Size(100, 24)
        Me.txtInyecciones.TabIndex = 7
        Me.txtInyecciones.Text = "0"
        '
        'lblInyecciones
        '
        Me.lblInyecciones.AutoSize = True
        Me.lblInyecciones.Location = New System.Drawing.Point(228, 182)
        Me.lblInyecciones.Name = "lblInyecciones"
        Me.lblInyecciones.Size = New System.Drawing.Size(68, 16)
        Me.lblInyecciones.TabIndex = 42
        Me.lblInyecciones.Text = "Inyecciones"
        '
        'txtIntervalo
        '
        Me.txtIntervalo.Location = New System.Drawing.Point(92, 179)
        Me.txtIntervalo.MaxLength = 10
        Me.txtIntervalo.Name = "txtIntervalo"
        Me.txtIntervalo.Size = New System.Drawing.Size(100, 24)
        Me.txtIntervalo.TabIndex = 6
        Me.txtIntervalo.Text = "0"
        '
        'lblIntervalo
        '
        Me.lblIntervalo.AutoSize = True
        Me.lblIntervalo.Location = New System.Drawing.Point(5, 182)
        Me.lblIntervalo.Name = "lblIntervalo"
        Me.lblIntervalo.Size = New System.Drawing.Size(84, 16)
        Me.lblIntervalo.TabIndex = 40
        Me.lblIntervalo.Text = "Intervalo (seg)"
        '
        'rbtnNoBucleF
        '
        Me.rbtnNoBucleF.AutoSize = True
        Me.rbtnNoBucleF.Checked = True
        Me.rbtnNoBucleF.Location = New System.Drawing.Point(163, 24)
        Me.rbtnNoBucleF.Name = "rbtnNoBucleF"
        Me.rbtnNoBucleF.Size = New System.Drawing.Size(102, 20)
        Me.rbtnNoBucleF.TabIndex = 39
        Me.rbtnNoBucleF.TabStop = True
        Me.rbtnNoBucleF.Text = "No tiene Bucle"
        Me.rbtnNoBucleF.UseVisualStyleBackColor = True
        '
        'txtFrecuenciaResultado
        '
        Me.txtFrecuenciaResultado.BackColor = System.Drawing.Color.Khaki
        Me.txtFrecuenciaResultado.Location = New System.Drawing.Point(426, 101)
        Me.txtFrecuenciaResultado.MaxLength = 15
        Me.txtFrecuenciaResultado.Name = "txtFrecuenciaResultado"
        Me.txtFrecuenciaResultado.ReadOnly = True
        Me.txtFrecuenciaResultado.Size = New System.Drawing.Size(95, 24)
        Me.txtFrecuenciaResultado.TabIndex = 38
        Me.txtFrecuenciaResultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnFrecuencia
        '
        Me.btnFrecuencia.BackColor = System.Drawing.Color.Khaki
        Me.btnFrecuencia.Location = New System.Drawing.Point(426, 59)
        Me.btnFrecuencia.Name = "btnFrecuencia"
        Me.btnFrecuencia.Size = New System.Drawing.Size(95, 29)
        Me.btnFrecuencia.TabIndex = 5
        Me.btnFrecuencia.Text = "Frecuencia"
        Me.btnFrecuencia.UseVisualStyleBackColor = False
        '
        'txtVueltaBucle
        '
        Me.txtVueltaBucle.Location = New System.Drawing.Point(302, 101)
        Me.txtVueltaBucle.MaxLength = 10
        Me.txtVueltaBucle.Name = "txtVueltaBucle"
        Me.txtVueltaBucle.Size = New System.Drawing.Size(100, 24)
        Me.txtVueltaBucle.TabIndex = 4
        Me.txtVueltaBucle.Text = "0"
        '
        'txtNbucleF
        '
        Me.txtNbucleF.Location = New System.Drawing.Point(92, 101)
        Me.txtNbucleF.MaxLength = 10
        Me.txtNbucleF.Name = "txtNbucleF"
        Me.txtNbucleF.Size = New System.Drawing.Size(100, 24)
        Me.txtNbucleF.TabIndex = 2
        Me.txtNbucleF.Text = "0"
        '
        'txtVueltaLargaF
        '
        Me.txtVueltaLargaF.Location = New System.Drawing.Point(302, 62)
        Me.txtVueltaLargaF.MaxLength = 10
        Me.txtVueltaLargaF.Name = "txtVueltaLargaF"
        Me.txtVueltaLargaF.Size = New System.Drawing.Size(100, 24)
        Me.txtVueltaLargaF.TabIndex = 3
        Me.txtVueltaLargaF.Text = "0"
        '
        'txtNumeroTrenes
        '
        Me.txtNumeroTrenes.Location = New System.Drawing.Point(92, 62)
        Me.txtNumeroTrenes.MaxLength = 10
        Me.txtNumeroTrenes.Name = "txtNumeroTrenes"
        Me.txtNumeroTrenes.Size = New System.Drawing.Size(100, 24)
        Me.txtNumeroTrenes.TabIndex = 1
        Me.txtNumeroTrenes.Text = "0"
        '
        'lblNbucleF
        '
        Me.lblNbucleF.AutoSize = True
        Me.lblNbucleF.Location = New System.Drawing.Point(18, 104)
        Me.lblNbucleF.Name = "lblNbucleF"
        Me.lblNbucleF.Size = New System.Drawing.Size(54, 16)
        Me.lblNbucleF.TabIndex = 32
        Me.lblNbucleF.Text = "N (bucle)"
        '
        'lblVueltaBucle
        '
        Me.lblVueltaBucle.AutoSize = True
        Me.lblVueltaBucle.Location = New System.Drawing.Point(198, 104)
        Me.lblVueltaBucle.Name = "lblVueltaBucle"
        Me.lblVueltaBucle.Size = New System.Drawing.Size(103, 16)
        Me.lblVueltaBucle.TabIndex = 31
        Me.lblVueltaBucle.Text = "Vuelta Bucle (seg)"
        '
        'lblVueltaLargaF
        '
        Me.lblVueltaLargaF.AutoSize = True
        Me.lblVueltaLargaF.Location = New System.Drawing.Point(198, 65)
        Me.lblVueltaLargaF.Name = "lblVueltaLargaF"
        Me.lblVueltaLargaF.Size = New System.Drawing.Size(105, 16)
        Me.lblVueltaLargaF.TabIndex = 30
        Me.lblVueltaLargaF.Text = "Vuelta Larga (seg)"
        '
        'rbtnBucleFrec
        '
        Me.rbtnBucleFrec.AutoSize = True
        Me.rbtnBucleFrec.Location = New System.Drawing.Point(21, 24)
        Me.rbtnBucleFrec.Name = "rbtnBucleFrec"
        Me.rbtnBucleFrec.Size = New System.Drawing.Size(85, 20)
        Me.rbtnBucleFrec.TabIndex = 29
        Me.rbtnBucleFrec.TabStop = True
        Me.rbtnBucleFrec.Text = "Tiene Bucle"
        Me.rbtnBucleFrec.UseVisualStyleBackColor = True
        '
        'lblNumeroTrenes
        '
        Me.lblNumeroTrenes.AutoSize = True
        Me.lblNumeroTrenes.Location = New System.Drawing.Point(18, 65)
        Me.lblNumeroTrenes.Name = "lblNumeroTrenes"
        Me.lblNumeroTrenes.Size = New System.Drawing.Size(59, 16)
        Me.lblNumeroTrenes.TabIndex = 28
        Me.lblNumeroTrenes.Text = "Nº Trenes"
        '
        'frmFrecuencia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(583, 387)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("Taffy", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmFrecuencia"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Frecuencia"
        Me.gpbFrecFB.ResumeLayout(False)
        Me.gpbFrecFB.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.gpbFrecNormal.ResumeLayout(False)
        Me.gpbFrecNormal.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gpbFrecFB As System.Windows.Forms.GroupBox
    Friend WithEvents lblFrecuenciaDef As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents gpbFrecNormal As System.Windows.Forms.GroupBox
    Friend WithEvents txtFrecuenciaResultadoNormal As System.Windows.Forms.TextBox
    Friend WithEvents lblLineas As System.Windows.Forms.Label
    Friend WithEvents txtInyecciones As System.Windows.Forms.TextBox
    Friend WithEvents lblInyecciones As System.Windows.Forms.Label
    Friend WithEvents txtIntervalo As System.Windows.Forms.TextBox
    Friend WithEvents lblIntervalo As System.Windows.Forms.Label
    Friend WithEvents rbtnNoBucleF As System.Windows.Forms.RadioButton
    Friend WithEvents txtFrecuenciaResultado As System.Windows.Forms.TextBox
    Friend WithEvents btnFrecuencia As System.Windows.Forms.Button
    Friend WithEvents txtVueltaBucle As System.Windows.Forms.TextBox
    Friend WithEvents txtNbucleF As System.Windows.Forms.TextBox
    Friend WithEvents txtVueltaLargaF As System.Windows.Forms.TextBox
    Friend WithEvents txtNumeroTrenes As System.Windows.Forms.TextBox
    Friend WithEvents lblNbucleF As System.Windows.Forms.Label
    Friend WithEvents lblVueltaBucle As System.Windows.Forms.Label
    Friend WithEvents lblVueltaLargaF As System.Windows.Forms.Label
    Friend WithEvents rbtnBucleFrec As System.Windows.Forms.RadioButton
    Friend WithEvents lblNumeroTrenes As System.Windows.Forms.Label
    Friend WithEvents btnFrecuenciaNormal As System.Windows.Forms.Button
    Friend WithEvents btnFrecuenciaFB As System.Windows.Forms.Button
    Friend WithEvents txtFrecuenciaResultadoFB As System.Windows.Forms.TextBox
    Friend WithEvents txtIntervaloFB As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNbucleFB As System.Windows.Forms.TextBox
    Friend WithEvents lblNbucleFB As System.Windows.Forms.Label
    Friend WithEvents btnLimpiar As System.Windows.Forms.Button
End Class
