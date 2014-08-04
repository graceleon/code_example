<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConversorUnidades
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConversorUnidades))
        Me.gpbSegundos = New System.Windows.Forms.GroupBox()
        Me.lblSegConv = New System.Windows.Forms.Label()
        Me.lblSegundos = New System.Windows.Forms.Label()
        Me.txtSegConvertido = New System.Windows.Forms.TextBox()
        Me.btnCalculaSeg = New System.Windows.Forms.Button()
        Me.rbtnSegHoras = New System.Windows.Forms.RadioButton()
        Me.rbtnSegMinutos = New System.Windows.Forms.RadioButton()
        Me.txtSegundos = New System.Windows.Forms.TextBox()
        Me.gpbMinutos = New System.Windows.Forms.GroupBox()
        Me.lblMinConv = New System.Windows.Forms.Label()
        Me.lblMinutos = New System.Windows.Forms.Label()
        Me.txtMinConvertido = New System.Windows.Forms.TextBox()
        Me.btnCalculaMin = New System.Windows.Forms.Button()
        Me.rbtnMinHoras = New System.Windows.Forms.RadioButton()
        Me.rbtnMinSegundos = New System.Windows.Forms.RadioButton()
        Me.txtMinutos = New System.Windows.Forms.TextBox()
        Me.gpbHoras = New System.Windows.Forms.GroupBox()
        Me.lblHrConv = New System.Windows.Forms.Label()
        Me.lblHoras = New System.Windows.Forms.Label()
        Me.txtHrConvertida = New System.Windows.Forms.TextBox()
        Me.btnCalculaHrs = New System.Windows.Forms.Button()
        Me.rbtnHrMinutos = New System.Windows.Forms.RadioButton()
        Me.rbtnHrSegundos = New System.Windows.Forms.RadioButton()
        Me.txtHoras = New System.Windows.Forms.TextBox()
        Me.gpbSegundos.SuspendLayout()
        Me.gpbMinutos.SuspendLayout()
        Me.gpbHoras.SuspendLayout()
        Me.SuspendLayout()
        '
        'gpbSegundos
        '
        Me.gpbSegundos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gpbSegundos.Controls.Add(Me.lblSegConv)
        Me.gpbSegundos.Controls.Add(Me.lblSegundos)
        Me.gpbSegundos.Controls.Add(Me.txtSegConvertido)
        Me.gpbSegundos.Controls.Add(Me.btnCalculaSeg)
        Me.gpbSegundos.Controls.Add(Me.rbtnSegHoras)
        Me.gpbSegundos.Controls.Add(Me.rbtnSegMinutos)
        Me.gpbSegundos.Controls.Add(Me.txtSegundos)
        Me.gpbSegundos.Location = New System.Drawing.Point(12, 12)
        Me.gpbSegundos.Name = "gpbSegundos"
        Me.gpbSegundos.Size = New System.Drawing.Size(350, 99)
        Me.gpbSegundos.TabIndex = 0
        Me.gpbSegundos.TabStop = False
        Me.gpbSegundos.Text = "SEGUNDOS"
        '
        'lblSegConv
        '
        Me.lblSegConv.AutoSize = True
        Me.lblSegConv.Location = New System.Drawing.Point(298, 65)
        Me.lblSegConv.Name = "lblSegConv"
        Me.lblSegConv.Size = New System.Drawing.Size(0, 13)
        Me.lblSegConv.TabIndex = 6
        '
        'lblSegundos
        '
        Me.lblSegundos.AutoSize = True
        Me.lblSegundos.Location = New System.Drawing.Point(117, 31)
        Me.lblSegundos.Name = "lblSegundos"
        Me.lblSegundos.Size = New System.Drawing.Size(35, 13)
        Me.lblSegundos.TabIndex = 5
        Me.lblSegundos.Text = "(Seg.)"
        '
        'txtSegConvertido
        '
        Me.txtSegConvertido.Location = New System.Drawing.Point(192, 62)
        Me.txtSegConvertido.Name = "txtSegConvertido"
        Me.txtSegConvertido.Size = New System.Drawing.Size(100, 20)
        Me.txtSegConvertido.TabIndex = 4
        '
        'btnCalculaSeg
        '
        Me.btnCalculaSeg.Location = New System.Drawing.Point(192, 26)
        Me.btnCalculaSeg.Name = "btnCalculaSeg"
        Me.btnCalculaSeg.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculaSeg.TabIndex = 3
        Me.btnCalculaSeg.Text = "Convertir"
        Me.btnCalculaSeg.UseVisualStyleBackColor = True
        '
        'rbtnSegHoras
        '
        Me.rbtnSegHoras.AutoSize = True
        Me.rbtnSegHoras.Location = New System.Drawing.Point(102, 65)
        Me.rbtnSegHoras.Name = "rbtnSegHoras"
        Me.rbtnSegHoras.Size = New System.Drawing.Size(62, 17)
        Me.rbtnSegHoras.TabIndex = 2
        Me.rbtnSegHoras.TabStop = True
        Me.rbtnSegHoras.Text = "a Horas"
        Me.rbtnSegHoras.UseVisualStyleBackColor = True
        '
        'rbtnSegMinutos
        '
        Me.rbtnSegMinutos.AutoSize = True
        Me.rbtnSegMinutos.Location = New System.Drawing.Point(15, 65)
        Me.rbtnSegMinutos.Name = "rbtnSegMinutos"
        Me.rbtnSegMinutos.Size = New System.Drawing.Size(71, 17)
        Me.rbtnSegMinutos.TabIndex = 1
        Me.rbtnSegMinutos.TabStop = True
        Me.rbtnSegMinutos.Text = "a Minutos"
        Me.rbtnSegMinutos.UseVisualStyleBackColor = True
        '
        'txtSegundos
        '
        Me.txtSegundos.Location = New System.Drawing.Point(15, 28)
        Me.txtSegundos.Name = "txtSegundos"
        Me.txtSegundos.Size = New System.Drawing.Size(100, 20)
        Me.txtSegundos.TabIndex = 0
        '
        'gpbMinutos
        '
        Me.gpbMinutos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gpbMinutos.Controls.Add(Me.lblMinConv)
        Me.gpbMinutos.Controls.Add(Me.lblMinutos)
        Me.gpbMinutos.Controls.Add(Me.txtMinConvertido)
        Me.gpbMinutos.Controls.Add(Me.btnCalculaMin)
        Me.gpbMinutos.Controls.Add(Me.rbtnMinHoras)
        Me.gpbMinutos.Controls.Add(Me.rbtnMinSegundos)
        Me.gpbMinutos.Controls.Add(Me.txtMinutos)
        Me.gpbMinutos.Location = New System.Drawing.Point(12, 117)
        Me.gpbMinutos.Name = "gpbMinutos"
        Me.gpbMinutos.Size = New System.Drawing.Size(350, 99)
        Me.gpbMinutos.TabIndex = 1
        Me.gpbMinutos.TabStop = False
        Me.gpbMinutos.Text = "MINUTOS"
        '
        'lblMinConv
        '
        Me.lblMinConv.AutoSize = True
        Me.lblMinConv.Location = New System.Drawing.Point(298, 65)
        Me.lblMinConv.Name = "lblMinConv"
        Me.lblMinConv.Size = New System.Drawing.Size(0, 13)
        Me.lblMinConv.TabIndex = 6
        '
        'lblMinutos
        '
        Me.lblMinutos.AutoSize = True
        Me.lblMinutos.Location = New System.Drawing.Point(117, 31)
        Me.lblMinutos.Name = "lblMinutos"
        Me.lblMinutos.Size = New System.Drawing.Size(33, 13)
        Me.lblMinutos.TabIndex = 5
        Me.lblMinutos.Text = "(Min.)"
        '
        'txtMinConvertido
        '
        Me.txtMinConvertido.Location = New System.Drawing.Point(192, 62)
        Me.txtMinConvertido.Name = "txtMinConvertido"
        Me.txtMinConvertido.Size = New System.Drawing.Size(100, 20)
        Me.txtMinConvertido.TabIndex = 4
        '
        'btnCalculaMin
        '
        Me.btnCalculaMin.Location = New System.Drawing.Point(192, 26)
        Me.btnCalculaMin.Name = "btnCalculaMin"
        Me.btnCalculaMin.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculaMin.TabIndex = 3
        Me.btnCalculaMin.Text = "Convertir"
        Me.btnCalculaMin.UseVisualStyleBackColor = True
        '
        'rbtnMinHoras
        '
        Me.rbtnMinHoras.AutoSize = True
        Me.rbtnMinHoras.Location = New System.Drawing.Point(102, 65)
        Me.rbtnMinHoras.Name = "rbtnMinHoras"
        Me.rbtnMinHoras.Size = New System.Drawing.Size(62, 17)
        Me.rbtnMinHoras.TabIndex = 2
        Me.rbtnMinHoras.TabStop = True
        Me.rbtnMinHoras.Text = "a Horas"
        Me.rbtnMinHoras.UseVisualStyleBackColor = True
        '
        'rbtnMinSegundos
        '
        Me.rbtnMinSegundos.AutoSize = True
        Me.rbtnMinSegundos.Location = New System.Drawing.Point(15, 65)
        Me.rbtnMinSegundos.Name = "rbtnMinSegundos"
        Me.rbtnMinSegundos.Size = New System.Drawing.Size(82, 17)
        Me.rbtnMinSegundos.TabIndex = 1
        Me.rbtnMinSegundos.TabStop = True
        Me.rbtnMinSegundos.Text = "a Segundos"
        Me.rbtnMinSegundos.UseVisualStyleBackColor = True
        '
        'txtMinutos
        '
        Me.txtMinutos.Location = New System.Drawing.Point(15, 28)
        Me.txtMinutos.Name = "txtMinutos"
        Me.txtMinutos.Size = New System.Drawing.Size(100, 20)
        Me.txtMinutos.TabIndex = 0
        '
        'gpbHoras
        '
        Me.gpbHoras.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gpbHoras.Controls.Add(Me.lblHrConv)
        Me.gpbHoras.Controls.Add(Me.lblHoras)
        Me.gpbHoras.Controls.Add(Me.txtHrConvertida)
        Me.gpbHoras.Controls.Add(Me.btnCalculaHrs)
        Me.gpbHoras.Controls.Add(Me.rbtnHrMinutos)
        Me.gpbHoras.Controls.Add(Me.rbtnHrSegundos)
        Me.gpbHoras.Controls.Add(Me.txtHoras)
        Me.gpbHoras.Location = New System.Drawing.Point(12, 222)
        Me.gpbHoras.Name = "gpbHoras"
        Me.gpbHoras.Size = New System.Drawing.Size(350, 99)
        Me.gpbHoras.TabIndex = 7
        Me.gpbHoras.TabStop = False
        Me.gpbHoras.Text = "HORAS"
        '
        'lblHrConv
        '
        Me.lblHrConv.AutoSize = True
        Me.lblHrConv.Location = New System.Drawing.Point(298, 65)
        Me.lblHrConv.Name = "lblHrConv"
        Me.lblHrConv.Size = New System.Drawing.Size(0, 13)
        Me.lblHrConv.TabIndex = 6
        '
        'lblHoras
        '
        Me.lblHoras.AutoSize = True
        Me.lblHoras.Location = New System.Drawing.Point(117, 31)
        Me.lblHoras.Name = "lblHoras"
        Me.lblHoras.Size = New System.Drawing.Size(32, 13)
        Me.lblHoras.TabIndex = 5
        Me.lblHoras.Text = "(Hrs.)"
        '
        'txtHrConvertida
        '
        Me.txtHrConvertida.Location = New System.Drawing.Point(192, 62)
        Me.txtHrConvertida.Name = "txtHrConvertida"
        Me.txtHrConvertida.Size = New System.Drawing.Size(100, 20)
        Me.txtHrConvertida.TabIndex = 4
        '
        'btnCalculaHrs
        '
        Me.btnCalculaHrs.Location = New System.Drawing.Point(192, 26)
        Me.btnCalculaHrs.Name = "btnCalculaHrs"
        Me.btnCalculaHrs.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculaHrs.TabIndex = 3
        Me.btnCalculaHrs.Text = "Convertir"
        Me.btnCalculaHrs.UseVisualStyleBackColor = True
        '
        'rbtnHrMinutos
        '
        Me.rbtnHrMinutos.AutoSize = True
        Me.rbtnHrMinutos.Location = New System.Drawing.Point(102, 65)
        Me.rbtnHrMinutos.Name = "rbtnHrMinutos"
        Me.rbtnHrMinutos.Size = New System.Drawing.Size(71, 17)
        Me.rbtnHrMinutos.TabIndex = 2
        Me.rbtnHrMinutos.TabStop = True
        Me.rbtnHrMinutos.Text = "a Minutos"
        Me.rbtnHrMinutos.UseVisualStyleBackColor = True
        '
        'rbtnHrSegundos
        '
        Me.rbtnHrSegundos.AutoSize = True
        Me.rbtnHrSegundos.Location = New System.Drawing.Point(15, 65)
        Me.rbtnHrSegundos.Name = "rbtnHrSegundos"
        Me.rbtnHrSegundos.Size = New System.Drawing.Size(82, 17)
        Me.rbtnHrSegundos.TabIndex = 1
        Me.rbtnHrSegundos.TabStop = True
        Me.rbtnHrSegundos.Text = "a Segundos"
        Me.rbtnHrSegundos.UseVisualStyleBackColor = True
        '
        'txtHoras
        '
        Me.txtHoras.Location = New System.Drawing.Point(15, 28)
        Me.txtHoras.Name = "txtHoras"
        Me.txtHoras.Size = New System.Drawing.Size(100, 20)
        Me.txtHoras.TabIndex = 0
        '
        'frmConversorUnidades
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(374, 332)
        Me.Controls.Add(Me.gpbHoras)
        Me.Controls.Add(Me.gpbMinutos)
        Me.Controls.Add(Me.gpbSegundos)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmConversorUnidades"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Conversor de unidades"
        Me.gpbSegundos.ResumeLayout(False)
        Me.gpbSegundos.PerformLayout()
        Me.gpbMinutos.ResumeLayout(False)
        Me.gpbMinutos.PerformLayout()
        Me.gpbHoras.ResumeLayout(False)
        Me.gpbHoras.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gpbSegundos As System.Windows.Forms.GroupBox
    Friend WithEvents lblSegConv As System.Windows.Forms.Label
    Friend WithEvents lblSegundos As System.Windows.Forms.Label
    Friend WithEvents txtSegConvertido As System.Windows.Forms.TextBox
    Friend WithEvents btnCalculaSeg As System.Windows.Forms.Button
    Friend WithEvents rbtnSegHoras As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnSegMinutos As System.Windows.Forms.RadioButton
    Friend WithEvents txtSegundos As System.Windows.Forms.TextBox
    Friend WithEvents gpbMinutos As System.Windows.Forms.GroupBox
    Friend WithEvents lblMinConv As System.Windows.Forms.Label
    Friend WithEvents lblMinutos As System.Windows.Forms.Label
    Friend WithEvents txtMinConvertido As System.Windows.Forms.TextBox
    Friend WithEvents btnCalculaMin As System.Windows.Forms.Button
    Friend WithEvents rbtnMinHoras As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnMinSegundos As System.Windows.Forms.RadioButton
    Friend WithEvents txtMinutos As System.Windows.Forms.TextBox
    Friend WithEvents gpbHoras As System.Windows.Forms.GroupBox
    Friend WithEvents lblHrConv As System.Windows.Forms.Label
    Friend WithEvents lblHoras As System.Windows.Forms.Label
    Friend WithEvents txtHrConvertida As System.Windows.Forms.TextBox
    Friend WithEvents btnCalculaHrs As System.Windows.Forms.Button
    Friend WithEvents rbtnHrMinutos As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnHrSegundos As System.Windows.Forms.RadioButton
    Friend WithEvents txtHoras As System.Windows.Forms.TextBox
End Class
