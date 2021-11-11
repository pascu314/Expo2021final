<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmInfoPrioridades
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmInfoPrioridades))
        Me.BtnVolverPRIORIDADES = New System.Windows.Forms.Button()
        Me.LblTituloQS = New System.Windows.Forms.Label()
        Me.LblInfo1 = New System.Windows.Forms.Label()
        Me.LblTitulo2 = New System.Windows.Forms.Label()
        Me.LblInfo2 = New System.Windows.Forms.Label()
        Me.LblTitulo3 = New System.Windows.Forms.Label()
        Me.LblInfo3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BtnVolverPRIORIDADES
        '
        Me.BtnVolverPRIORIDADES.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnVolverPRIORIDADES.Location = New System.Drawing.Point(663, 504)
        Me.BtnVolverPRIORIDADES.Name = "BtnVolverPRIORIDADES"
        Me.BtnVolverPRIORIDADES.Size = New System.Drawing.Size(75, 23)
        Me.BtnVolverPRIORIDADES.TabIndex = 7
        Me.BtnVolverPRIORIDADES.Text = "VOLVER"
        Me.BtnVolverPRIORIDADES.UseVisualStyleBackColor = False
        '
        'LblTituloQS
        '
        Me.LblTituloQS.AutoSize = True
        Me.LblTituloQS.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LblTituloQS.Location = New System.Drawing.Point(12, 29)
        Me.LblTituloQS.Name = "LblTituloQS"
        Me.LblTituloQS.Size = New System.Drawing.Size(396, 30)
        Me.LblTituloQS.TabIndex = 9
        Me.LblTituloQS.Text = "¿Qué significa que sea por prioridades?"
        '
        'LblInfo1
        '
        Me.LblInfo1.AutoSize = True
        Me.LblInfo1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LblInfo1.Location = New System.Drawing.Point(25, 68)
        Me.LblInfo1.Name = "LblInfo1"
        Me.LblInfo1.Size = New System.Drawing.Size(657, 84)
        Me.LblInfo1.TabIndex = 10
        Me.LblInfo1.Text = resources.GetString("LblInfo1.Text")
        '
        'LblTitulo2
        '
        Me.LblTitulo2.AutoSize = True
        Me.LblTitulo2.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LblTitulo2.Location = New System.Drawing.Point(12, 173)
        Me.LblTitulo2.Name = "LblTitulo2"
        Me.LblTitulo2.Size = New System.Drawing.Size(98, 30)
        Me.LblTitulo2.TabIndex = 11
        Me.LblTitulo2.Text = "Ejemplo:"
        '
        'LblInfo2
        '
        Me.LblInfo2.AutoSize = True
        Me.LblInfo2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LblInfo2.Location = New System.Drawing.Point(25, 212)
        Me.LblInfo2.Name = "LblInfo2"
        Me.LblInfo2.Size = New System.Drawing.Size(705, 105)
        Me.LblInfo2.TabIndex = 12
        Me.LblInfo2.Text = resources.GetString("LblInfo2.Text")
        '
        'LblTitulo3
        '
        Me.LblTitulo3.AutoSize = True
        Me.LblTitulo3.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LblTitulo3.Location = New System.Drawing.Point(12, 346)
        Me.LblTitulo3.Name = "LblTitulo3"
        Me.LblTitulo3.Size = New System.Drawing.Size(413, 30)
        Me.LblTitulo3.TabIndex = 13
        Me.LblTitulo3.Text = "¿Cúal es el problema con este algoritmo?"
        '
        'LblInfo3
        '
        Me.LblInfo3.AutoSize = True
        Me.LblInfo3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LblInfo3.Location = New System.Drawing.Point(25, 386)
        Me.LblInfo3.Name = "LblInfo3"
        Me.LblInfo3.Size = New System.Drawing.Size(697, 84)
        Me.LblInfo3.TabIndex = 14
        Me.LblInfo3.Text = resources.GetString("LblInfo3.Text")
        '
        'FrmInfoPrioridades
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleTurquoise
        Me.ClientSize = New System.Drawing.Size(750, 539)
        Me.Controls.Add(Me.LblInfo3)
        Me.Controls.Add(Me.LblTitulo3)
        Me.Controls.Add(Me.LblInfo2)
        Me.Controls.Add(Me.LblTitulo2)
        Me.Controls.Add(Me.LblInfo1)
        Me.Controls.Add(Me.LblTituloQS)
        Me.Controls.Add(Me.BtnVolverPRIORIDADES)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmInfoPrioridades"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "INFORMACIÓN ""POR PRIORIDADES"""
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnVolverPRIORIDADES As Button
    Friend WithEvents LblTituloQS As Label
    Friend WithEvents LblInfo1 As Label
    Friend WithEvents LblTitulo2 As Label
    Friend WithEvents LblInfo2 As Label
    Friend WithEvents LblTitulo3 As Label
    Friend WithEvents LblInfo3 As Label
End Class
