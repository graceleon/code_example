<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConversorDecimal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConversorDecimal))
        Me.gpbConversorHoras = New System.Windows.Forms.GroupBox()
        Me.txtValorConvertido = New System.Windows.Forms.TextBox()
        Me.btnConvertir = New System.Windows.Forms.Button()
        Me.rbtnSegundosConv = New System.Windows.Forms.RadioButton()
        Me.rbtnMinutosConv = New System.Windows.Forms.RadioButton()
        Me.rbtnHorasConv = New System.Windows.Forms.RadioButton()
        Me.txtValorConvertir = New System.Windows.Forms.TextBox()
        Me.gpbConversorHoras.SuspendLayout()
        Me.SuspendLayout()
        '
        'gpbConversorHoras
        '
        Me.gpbConversorHoras.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gpbConversorHoras.Controls.Add(Me.txtValorConvertido)
        Me.gpbConversorHoras.Controls.Add(Me.btnConvertir)
        Me.gpbConversorHoras.Controls.Add(Me.rbtnSegundosConv)
        Me.gpbConversorHoras.Controls.Add(Me.rbtnMinutosConv)
        Me.gpbConversorHoras.Controls.Add(Me.rbtnHorasConv)
        Me.gpbConversorHoras.Controls.Add(Me.txtValorConvertir)
        Me.gpbConversorHoras.Location = New System.Drawing.Point(12, 12)
        Me.gpbConversorHoras.Name = "gpbConversorHoras"
        Me.gpbConversorHoras.Size = New System.Drawing.Size(355, 108)
        Me.gpbConversorHoras.TabIndex = 0
        Me.gpbConversorHoras.TabStop = False
        Me.gpbConversorHoras.Text = "El valor representa"
        '
        'txtValorConvertido
        '
        Me.txtValorConvertido.Location = New System.Drawing.Point(141, 67)
        Me.txtValorConvertido.MaxLength = 50
        Me.txtValorConvertido.Name = "txtValorConvertido"
        Me.txtValorConvertido.Size = New System.Drawing.Size(166, 20)
        Me.txtValorConvertido.TabIndex = 5
        Me.txtValorConvertido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnConvertir
        '
        Me.btnConvertir.Location = New System.Drawing.Point(21, 65)
        Me.btnConvertir.Name = "btnConvertir"
        Me.btnConvertir.Size = New System.Drawing.Size(75, 23)
        Me.btnConvertir.TabIndex = 4
        Me.btnConvertir.Text = "Dar formato"
        Me.btnConvertir.UseVisualStyleBackColor = True
        '
        'rbtnSegundosConv
        '
        Me.rbtnSegundosConv.AutoSize = True
        Me.rbtnSegundosConv.Location = New System.Drawing.Point(268, 29)
        Me.rbtnSegundosConv.Name = "rbtnSegundosConv"
        Me.rbtnSegundosConv.Size = New System.Drawing.Size(73, 17)
        Me.rbtnSegundosConv.TabIndex = 3
        Me.rbtnSegundosConv.TabStop = True
        Me.rbtnSegundosConv.Text = "Segundos"
        Me.rbtnSegundosConv.UseVisualStyleBackColor = True
        '
        'rbtnMinutosConv
        '
        Me.rbtnMinutosConv.AutoSize = True
        Me.rbtnMinutosConv.Location = New System.Drawing.Point(200, 29)
        Me.rbtnMinutosConv.Name = "rbtnMinutosConv"
        Me.rbtnMinutosConv.Size = New System.Drawing.Size(62, 17)
        Me.rbtnMinutosConv.TabIndex = 2
        Me.rbtnMinutosConv.TabStop = True
        Me.rbtnMinutosConv.Text = "Minutos"
        Me.rbtnMinutosConv.UseVisualStyleBackColor = True
        '
        'rbtnHorasConv
        '
        Me.rbtnHorasConv.AutoSize = True
        Me.rbtnHorasConv.Location = New System.Drawing.Point(141, 29)
        Me.rbtnHorasConv.Name = "rbtnHorasConv"
        Me.rbtnHorasConv.Size = New System.Drawing.Size(53, 17)
        Me.rbtnHorasConv.TabIndex = 1
        Me.rbtnHorasConv.TabStop = True
        Me.rbtnHorasConv.Text = "Horas"
        Me.rbtnHorasConv.UseVisualStyleBackColor = True
        '
        'txtValorConvertir
        '
        Me.txtValorConvertir.Location = New System.Drawing.Point(6, 28)
        Me.txtValorConvertir.MaxLength = 50
        Me.txtValorConvertir.Name = "txtValorConvertir"
        Me.txtValorConvertir.Size = New System.Drawing.Size(115, 20)
        Me.txtValorConvertir.TabIndex = 0
        Me.txtValorConvertir.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'frmConversorDecimal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(379, 129)
        Me.Controls.Add(Me.gpbConversorHoras)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmConversorDecimal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Conversor Horas"
        Me.gpbConversorHoras.ResumeLayout(False)
        Me.gpbConversorHoras.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gpbConversorHoras As System.Windows.Forms.GroupBox
    Friend WithEvents rbtnSegundosConv As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnMinutosConv As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnHorasConv As System.Windows.Forms.RadioButton
    Friend WithEvents txtValorConvertir As System.Windows.Forms.TextBox
    Friend WithEvents txtValorConvertido As System.Windows.Forms.TextBox
    Friend WithEvents btnConvertir As System.Windows.Forms.Button
End Class
