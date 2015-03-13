<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.chkb_add = New System.Windows.Forms.CheckBox()
        Me.chkb_sub = New System.Windows.Forms.CheckBox()
        Me.chkb_mult = New System.Windows.Forms.CheckBox()
        Me.chkb_div = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tb_token1 = New System.Windows.Forms.TextBox()
        Me.tb_token2 = New System.Windows.Forms.TextBox()
        Me.tb_token3 = New System.Windows.Forms.TextBox()
        Me.tb_token4 = New System.Windows.Forms.TextBox()
        Me.tb_token5 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(33, 39)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'chkb_add
        '
        Me.chkb_add.AutoSize = True
        Me.chkb_add.Location = New System.Drawing.Point(154, 15)
        Me.chkb_add.Name = "chkb_add"
        Me.chkb_add.Size = New System.Drawing.Size(64, 17)
        Me.chkb_add.TabIndex = 2
        Me.chkb_add.Text = "Addition"
        Me.chkb_add.UseVisualStyleBackColor = True
        '
        'chkb_sub
        '
        Me.chkb_sub.AutoSize = True
        Me.chkb_sub.Location = New System.Drawing.Point(154, 39)
        Me.chkb_sub.Name = "chkb_sub"
        Me.chkb_sub.Size = New System.Drawing.Size(80, 17)
        Me.chkb_sub.TabIndex = 3
        Me.chkb_sub.Text = "Subtraktion"
        Me.chkb_sub.UseVisualStyleBackColor = True
        '
        'chkb_mult
        '
        Me.chkb_mult.AutoSize = True
        Me.chkb_mult.Location = New System.Drawing.Point(240, 15)
        Me.chkb_mult.Name = "chkb_mult"
        Me.chkb_mult.Size = New System.Drawing.Size(87, 17)
        Me.chkb_mult.TabIndex = 4
        Me.chkb_mult.Text = "Multiplikation"
        Me.chkb_mult.UseVisualStyleBackColor = True
        '
        'chkb_div
        '
        Me.chkb_div.AutoSize = True
        Me.chkb_div.Location = New System.Drawing.Point(240, 39)
        Me.chkb_div.Name = "chkb_div"
        Me.chkb_div.Size = New System.Drawing.Size(63, 17)
        Me.chkb_div.TabIndex = 5
        Me.chkb_div.Text = "Division"
        Me.chkb_div.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(363, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 20)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Label1"
        '
        'tb_token1
        '
        Me.tb_token1.Location = New System.Drawing.Point(5, 13)
        Me.tb_token1.Name = "tb_token1"
        Me.tb_token1.Size = New System.Drawing.Size(29, 20)
        Me.tb_token1.TabIndex = 7
        '
        'tb_token2
        '
        Me.tb_token2.Location = New System.Drawing.Point(33, 13)
        Me.tb_token2.Name = "tb_token2"
        Me.tb_token2.Size = New System.Drawing.Size(29, 20)
        Me.tb_token2.TabIndex = 8
        '
        'tb_token3
        '
        Me.tb_token3.Location = New System.Drawing.Point(61, 13)
        Me.tb_token3.Name = "tb_token3"
        Me.tb_token3.Size = New System.Drawing.Size(29, 20)
        Me.tb_token3.TabIndex = 9
        '
        'tb_token4
        '
        Me.tb_token4.Location = New System.Drawing.Point(89, 13)
        Me.tb_token4.Name = "tb_token4"
        Me.tb_token4.Size = New System.Drawing.Size(29, 20)
        Me.tb_token4.TabIndex = 10
        '
        'tb_token5
        '
        Me.tb_token5.Location = New System.Drawing.Point(117, 13)
        Me.tb_token5.Name = "tb_token5"
        Me.tb_token5.Size = New System.Drawing.Size(31, 20)
        Me.tb_token5.TabIndex = 11
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(363, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 20)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Label2"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(534, 82)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tb_token5)
        Me.Controls.Add(Me.tb_token4)
        Me.Controls.Add(Me.tb_token3)
        Me.Controls.Add(Me.tb_token2)
        Me.Controls.Add(Me.tb_token1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.chkb_div)
        Me.Controls.Add(Me.chkb_mult)
        Me.Controls.Add(Me.chkb_sub)
        Me.Controls.Add(Me.chkb_add)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents chkb_add As System.Windows.Forms.CheckBox
    Friend WithEvents chkb_sub As System.Windows.Forms.CheckBox
    Friend WithEvents chkb_mult As System.Windows.Forms.CheckBox
    Friend WithEvents chkb_div As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tb_token1 As System.Windows.Forms.TextBox
    Friend WithEvents tb_token2 As System.Windows.Forms.TextBox
    Friend WithEvents tb_token3 As System.Windows.Forms.TextBox
    Friend WithEvents tb_token4 As System.Windows.Forms.TextBox
    Friend WithEvents tb_token5 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label

End Class
