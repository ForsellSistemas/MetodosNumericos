<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txt_x_esquerda = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmd_incluir = New System.Windows.Forms.Button()
        Me.txt_x_direita = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_y_baixo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_y_cima = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_numero_passos = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.listbox_passos = New System.Windows.Forms.ListBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.cmd_calcular_resultado = New System.Windows.Forms.Button()
        Me.txt_resultado = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'txt_x_esquerda
        '
        Me.txt_x_esquerda.Location = New System.Drawing.Point(12, 73)
        Me.txt_x_esquerda.Name = "txt_x_esquerda"
        Me.txt_x_esquerda.Size = New System.Drawing.Size(145, 20)
        Me.txt_x_esquerda.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "X Esquerda"
        '
        'cmd_incluir
        '
        Me.cmd_incluir.Location = New System.Drawing.Point(82, 155)
        Me.cmd_incluir.Name = "cmd_incluir"
        Me.cmd_incluir.Size = New System.Drawing.Size(228, 40)
        Me.cmd_incluir.TabIndex = 2
        Me.cmd_incluir.Text = "Incluir Passo"
        Me.cmd_incluir.UseVisualStyleBackColor = True
        '
        'txt_x_direita
        '
        Me.txt_x_direita.Location = New System.Drawing.Point(12, 118)
        Me.txt_x_direita.Name = "txt_x_direita"
        Me.txt_x_direita.Size = New System.Drawing.Size(145, 20)
        Me.txt_x_direita.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 102)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "X Direita"
        '
        'txt_y_baixo
        '
        Me.txt_y_baixo.Location = New System.Drawing.Point(199, 118)
        Me.txt_y_baixo.Name = "txt_y_baixo"
        Me.txt_y_baixo.Size = New System.Drawing.Size(145, 20)
        Me.txt_y_baixo.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(201, 102)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Y Baixo"
        '
        'txt_y_cima
        '
        Me.txt_y_cima.Location = New System.Drawing.Point(201, 73)
        Me.txt_y_cima.Name = "txt_y_cima"
        Me.txt_y_cima.Size = New System.Drawing.Size(145, 20)
        Me.txt_y_cima.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(201, 60)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Y cima"
        '
        'txt_numero_passos
        '
        Me.txt_numero_passos.Location = New System.Drawing.Point(12, 36)
        Me.txt_numero_passos.Name = "txt_numero_passos"
        Me.txt_numero_passos.Size = New System.Drawing.Size(145, 20)
        Me.txt_numero_passos.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 20)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Número de Passos"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txt_numero_passos)
        Me.GroupBox1.Controls.Add(Me.cmd_incluir)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txt_y_baixo)
        Me.GroupBox1.Controls.Add(Me.txt_x_esquerda)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txt_x_direita)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txt_y_cima)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(378, 202)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Percentual de probabilidade e passos"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(352, 122)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(15, 13)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "%"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(352, 77)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(15, 13)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "%"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(163, 122)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(15, 13)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "%"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(163, 77)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(15, 13)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "%"
        '
        'listbox_passos
        '
        Me.listbox_passos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.listbox_passos.FormattingEnabled = True
        Me.listbox_passos.Location = New System.Drawing.Point(0, 202)
        Me.listbox_passos.Name = "listbox_passos"
        Me.listbox_passos.Size = New System.Drawing.Size(378, 197)
        Me.listbox_passos.TabIndex = 5
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(378, 202)
        Me.Panel1.TabIndex = 6
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.txt_resultado)
        Me.Panel2.Controls.Add(Me.cmd_calcular_resultado)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 399)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(378, 51)
        Me.Panel2.TabIndex = 7
        '
        'cmd_calcular_resultado
        '
        Me.cmd_calcular_resultado.Location = New System.Drawing.Point(12, 3)
        Me.cmd_calcular_resultado.Name = "cmd_calcular_resultado"
        Me.cmd_calcular_resultado.Size = New System.Drawing.Size(131, 40)
        Me.cmd_calcular_resultado.TabIndex = 2
        Me.cmd_calcular_resultado.Text = "Calcular Resultado"
        Me.cmd_calcular_resultado.UseVisualStyleBackColor = True
        '
        'txt_resultado
        '
        Me.txt_resultado.Location = New System.Drawing.Point(166, 14)
        Me.txt_resultado.Name = "txt_resultado"
        Me.txt_resultado.Size = New System.Drawing.Size(178, 20)
        Me.txt_resultado.TabIndex = 3
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(378, 450)
        Me.Controls.Add(Me.listbox_passos)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txt_x_esquerda As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cmd_incluir As Button
    Friend WithEvents txt_x_direita As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_y_baixo As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_y_cima As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_numero_passos As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents listbox_passos As ListBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents cmd_calcular_resultado As Button
    Friend WithEvents txt_resultado As TextBox
End Class
