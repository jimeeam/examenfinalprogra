<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form4))
        Label1 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        Button1 = New Button()
        Button2 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Showcard Gothic", 26.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(333, 39)
        Label1.Name = "Label1"
        Label1.Size = New Size(129, 44)
        Label1.TabIndex = 0
        Label1.Text = "RESTA"
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = Color.RosyBrown
        TextBox1.Location = New Point(346, 137)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(100, 23)
        TextBox1.TabIndex = 1
        ' 
        ' TextBox2
        ' 
        TextBox2.BackColor = Color.RosyBrown
        TextBox2.Location = New Point(346, 215)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(100, 23)
        TextBox2.TabIndex = 2
        ' 
        ' TextBox3
        ' 
        TextBox3.BackColor = Color.RosyBrown
        TextBox3.Location = New Point(346, 376)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(100, 23)
        TextBox3.TabIndex = 3
        ' 
        ' Button1
        ' 
        Button1.BackColor = SystemColors.ButtonFace
        Button1.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.Location = New Point(361, 303)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 4
        Button1.Text = "operar"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = SystemColors.ButtonFace
        Button2.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Button2.Location = New Point(672, 397)
        Button2.Name = "Button2"
        Button2.Size = New Size(75, 23)
        Button2.TabIndex = 5
        Button2.Text = "atrás"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Form4
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Tomato
        ClientSize = New Size(800, 450)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Form4"
        Text = "Form4"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
