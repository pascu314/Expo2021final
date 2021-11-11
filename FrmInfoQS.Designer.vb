<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmInfoQS
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmInfoQS))
        Me.LblTituloQS = New System.Windows.Forms.Label()
        Me.BtnVolverQS = New System.Windows.Forms.Button()
        Me.LblInfo1 = New System.Windows.Forms.Label()
        Me.LblInfo2 = New System.Windows.Forms.Label()
        Me.LblTitulo2 = New System.Windows.Forms.Label()
        Me.LblTitulo3 = New System.Windows.Forms.Label()
        Me.LblInfo3 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.SuspendLayout()
        '
        'LblTituloQS
        '
        Me.LblTituloQS.AutoSize = True
        Me.LblTituloQS.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LblTituloQS.Location = New System.Drawing.Point(12, 25)
        Me.LblTituloQS.Name = "LblTituloQS"
        Me.LblTituloQS.Size = New System.Drawing.Size(542, 30)
        Me.LblTituloQS.TabIndex = 0
        Me.LblTituloQS.Text = "¿Qué son los algoritmos de planificación de procesos?"
        '
        'BtnVolverQS
        '
        Me.BtnVolverQS.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnVolverQS.Location = New System.Drawing.Point(651, 504)
        Me.BtnVolverQS.Name = "BtnVolverQS"
        Me.BtnVolverQS.Size = New System.Drawing.Size(75, 23)
        Me.BtnVolverQS.TabIndex = 1
        Me.BtnVolverQS.Text = "VOLVER"
        Me.BtnVolverQS.UseVisualStyleBackColor = False
        '
        'LblInfo1
        '
        Me.LblInfo1.AutoSize = True
        Me.LblInfo1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LblInfo1.Location = New System.Drawing.Point(19, 70)
        Me.LblInfo1.Name = "LblInfo1"
        Me.LblInfo1.Size = New System.Drawing.Size(664, 63)
        Me.LblInfo1.TabIndex = 2
        Me.LblInfo1.Text = resources.GetString("LblInfo1.Text")
        '
        'LblInfo2
        '
        Me.LblInfo2.AutoSize = True
        Me.LblInfo2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LblInfo2.Location = New System.Drawing.Point(17, 210)
        Me.LblInfo2.Name = "LblInfo2"
        Me.LblInfo2.Size = New System.Drawing.Size(682, 42)
        Me.LblInfo2.TabIndex = 3
        Me.LblInfo2.Text = " Su principal objetivo consiste en el máximo aprovechamiento del sistema, lo que " &
    "implica proveer" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " un buen servicio a los procesos existentes en un momento dado." &
    " " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'LblTitulo2
        '
        Me.LblTitulo2.AutoSize = True
        Me.LblTitulo2.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LblTitulo2.Location = New System.Drawing.Point(12, 167)
        Me.LblTitulo2.Name = "LblTitulo2"
        Me.LblTitulo2.Size = New System.Drawing.Size(307, 30)
        Me.LblTitulo2.TabIndex = 4
        Me.LblTitulo2.Text = "¿Cuál es su principal objetivo?"
        '
        'LblTitulo3
        '
        Me.LblTitulo3.AutoSize = True
        Me.LblTitulo3.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LblTitulo3.Location = New System.Drawing.Point(12, 273)
        Me.LblTitulo3.Name = "LblTitulo3"
        Me.LblTitulo3.Size = New System.Drawing.Size(202, 30)
        Me.LblTitulo3.TabIndex = 5
        Me.LblTitulo3.Text = "¿Qué tipos existen?"
        '
        'LblInfo3
        '
        Me.LblInfo3.AutoSize = True
        Me.LblInfo3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LblInfo3.Location = New System.Drawing.Point(18, 316)
        Me.LblInfo3.Name = "LblInfo3"
        Me.LblInfo3.Size = New System.Drawing.Size(679, 147)
        Me.LblInfo3.TabIndex = 6
        Me.LblInfo3.Text = resources.GetString("LblInfo3.Text")
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel1.Location = New System.Drawing.Point(35, 377)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(88, 2)
        Me.Panel1.TabIndex = 7
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel2.Location = New System.Drawing.Point(35, 442)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(109, 2)
        Me.Panel2.TabIndex = 8
        '
        'FrmInfoQS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleTurquoise
        Me.ClientSize = New System.Drawing.Size(750, 539)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.LblInfo3)
        Me.Controls.Add(Me.LblTitulo3)
        Me.Controls.Add(Me.LblTitulo2)
        Me.Controls.Add(Me.LblInfo2)
        Me.Controls.Add(Me.LblInfo1)
        Me.Controls.Add(Me.BtnVolverQS)
        Me.Controls.Add(Me.LblTituloQS)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmInfoQS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "INFORMACIÓN "
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblTituloQS As Label
    Friend WithEvents BtnVolverQS As Button
    Friend WithEvents LblInfo1 As Label
    Friend WithEvents LblInfo2 As Label
    Friend WithEvents LblTitulo2 As Label
    Friend WithEvents LblTitulo3 As Label
    Friend WithEvents LblInfo3 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
End Class
