<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Label1 = New Label()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Times New Roman", 26.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label1.Location = New Point(181, 55)
        Label1.Name = "Label1"
        Label1.Size = New Size(415, 41)
        Label1.TabIndex = 0
        Label1.Text = "OPERACIONES BÁSICAS"
        ' 
        ' Button1
        ' 
        Button1.BackColor = SystemColors.ButtonFace
        Button1.Font = New Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Button1.ForeColor = SystemColors.ControlText
        Button1.ImageAlign = ContentAlignment.MiddleLeft
        Button1.Location = New Point(341, 126)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 28)
        Button1.TabIndex = 1
        Button1.Text = "SUMA"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = SystemColors.ButtonFace
        Button2.Font = New Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Button2.Location = New Point(341, 202)
        Button2.Name = "Button2"
        Button2.Size = New Size(75, 27)
        Button2.TabIndex = 2
        Button2.Text = "RESTA"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = SystemColors.ButtonFace
        Button3.Font = New Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Button3.Location = New Point(301, 275)
        Button3.Name = "Button3"
        Button3.Size = New Size(154, 26)
        Button3.TabIndex = 3
        Button3.Text = "MULTIPLICACIÓN"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button4
        ' 
        Button4.BackColor = SystemColors.ButtonFace
        Button4.Font = New Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Button4.Location = New Point(330, 352)
        Button4.Name = "Button4"
        Button4.Size = New Size(86, 26)
        Button4.TabIndex = 4
        Button4.Text = "DIVISIÓN"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Coral
        ClientSize = New Size(800, 450)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Label1)
        ForeColor = SystemColors.ControlText
        Name = "Form2"
        Text = "Form2"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
End Class
